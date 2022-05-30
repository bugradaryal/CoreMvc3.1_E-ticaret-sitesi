using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using eticaretsitesi.Models;
using MimeKit;
using MimeKit.Utils;
using MailKit.Net.Smtp;
using MailKit.Security;
using System.Reflection;

namespace eticaretsitesi.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        private Repository<Product> Data { get; }
        public CartController(ProductContext ctx)
        {
            this.Data = new Repository<Product>(ctx);
        }
        private Cart getCart()
        {
            var cart = new Cart(HttpContext);
            cart.Load(this.Data);
            return cart;
        }
        public ViewResult Index()
        {
            var cart = this.getCart();
            var builder = new ProductsGridBuilder(HttpContext.Session);

            var vm = new CartViewModel {
                List = cart.List,
                Subtotal = cart.Subtotal,
                BookGridRoute = builder.CurrentRoute
            };
            return View(vm);
        }
        [HttpPost]
        public RedirectToActionResult Add(int id)
        {
            var product = this.Data.Get(new QueryOptions<Product> {
                Include = "Type",
                Where = b => b.ProductId == id
            });
            if (product == null)
            {
                TempData["message"] = "Sepete Eklenemiyor.";
            }
            else
            {
                var dto = new ProductDTO();
                dto.Load(product);
                var item = new CartItem {
                    Product = dto,
                    Quantity = 1
                };

                var cart = this.getCart();
                cart.Add(item);
                cart.Save();

                TempData["message"] = $"{product.Name} Sepete Eklendi";
            }

            var builder = new ProductsGridBuilder(HttpContext.Session);
            return RedirectToAction("List", "Products", builder.CurrentRoute);
        }
        [HttpPost]
        public RedirectToActionResult Remove(int id)
        {
            var cart = this.getCart();
            var item = cart.GetById(id);
            cart.Remove(item);
            cart.Save();

            TempData["message"] = $"{item.Product.Name} Sepetten Kaldırıldı.";
            return RedirectToAction("Index");
        }
        [HttpPost]
        public RedirectToActionResult Clear()
        {
            var cart = this.getCart();
            cart.Clear();
            cart.Save();

            TempData["message"] = "Sepet Temizlendi.";
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var cart = this.getCart();
            var item = cart.GetById(id);
            if (item == null)
            {
                TempData["message"] = "Sepet öğesi bulunamadı";
                return RedirectToAction("Index");
            }

            return View(item);
        }
        [HttpPost]
        public RedirectToActionResult Edit(CartItem item)
        {
            var cart = this.getCart();
            cart.Edit(item);
            cart.Save();

            TempData["message"] = $"{item.Product.Name} Güncellendi";
            return RedirectToAction("Index");
        }
        public IActionResult Checkout()
        {
            var cart = this.getCart();
            if(cart.Count != null)
            {
                return View("Checkout");
            }
            else
            {
                TempData["message"] = "Sepet Boş!";
                return RedirectToAction("Index");
            }
        }
        public IActionResult Checkout_done(string adsoyad,string eposta, string tel, string adres)
        {
            var cart = this.getCart();
            var message = new MimeMessage();
            var builder = new BodyBuilder();

            string textbody=string.Empty;

            textbody += @"
                        <div>
                            <b>Satın alımla ilgili herhangi bir bilginiz hatalıysa veya satın alımı siz gerçekleştirmediyseniz bize ""Bize Ulaşın"" bölümü üzerinden ulaşabilirsiniz.</b>
                            <div>
                                <b style='color:darkred; font-size: 25px;'>Satın alım bilgileri:</b>
                            </div>
                            <div style='margin-top:1.2vh'>
                                <div>
                                    <p><b>Kişi Adı: </b>" + adsoyad + @"</p>
                                </div>
                                <div>
                                    <p><b>Eposta Adresi: </b>" + eposta + @"</p>
                                </div>
                                <div>
                                    <p><b>Telefon Numarası: </b>" + tel + @"</p>
                                </div>
                                <div>
                                    <b>Adres bilgileri:</b>
                                </div>
                                <div>
                                    <p>" + adres + @"</p>
                                </div>
                            </div>
                         </div>
                         <div style='margin-top:1.2vh'>
                             <div>
                                 <b style='color: darkred; margin-top: 2vh; margin-bottom:5vh; font-size: 25px;'>Satın alınan ürünler:</b>
                             </div>
                     ";
                foreach (var x in cart.List)
                {
                    textbody += @"
                                      <div style='margin-top:1vh;'>
                                           <div style='  border: 2px solid black; border-radius:5px; padding:5px; height:auto; width:40vw'>
                                                <p>Ürün adı: </b>" + x.Product.Name + @"</p>
                                                <p>Ürün Fiyatı: </b>" + x.Product.Price + @"</p>
                                                <p>Adet: </b>" + x.Quantity + @"</p>
                                                <p>Toplam Fiyatı: </b>" + x.Subtotal + @"</p>
                                          </div>
                                      </div>
                                ";
                }

            textbody += @"
                                </div>
                            ";
            builder.HtmlBody = textbody;
            InternetAddressList list = new InternetAddressList();
            list.Add(new MailboxAddress(string.Empty, eposta));
            list.Add(new MailboxAddress(string.Empty, "bugraverify@gmail.com"));
            message.From.Add(new MailboxAddress("Bilgilendirme", "bugraverify@gmail.com"));
            message.To.AddRange(list);
            message.Subject = "E-Ticaret Sitesi, Satın alım bilgilendirme işlemi.";
            message.Body = builder.ToMessageBody();



            using (var client = new SmtpClient())
            {
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                client.Connect("smtp.gmail.com", 465, SecureSocketOptions.SslOnConnect);
                client.Authenticate("bugraverify@gmail.com", "31082000B");

                client.Send(message);
                client.Disconnect(true);
            }

            cart.Clear();
            cart.Save();
            
            return View();
        }
    }
}