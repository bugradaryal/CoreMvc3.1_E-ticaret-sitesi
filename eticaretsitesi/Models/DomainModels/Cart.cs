using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;

namespace eticaretsitesi.Models
{
    public class Cart
    {
        private const string CartKey = "mycart";
        private const string CountKey = "mycount";
        private List<CartItem> Items { get; set; }
        private List<CartItemDTO> StoredItems { get; set; }
        private ISession Session { get; }
        private IRequestCookieCollection RequestCookies { get; }
        private IResponseCookies ResponseCookies { get; }
        public double Subtotal => this.Items.Sum(i => i.Subtotal);
        public int? Count => this.Session.GetInt32(CountKey) ?? this.RequestCookies.GetInt32(CountKey);
        public IEnumerable<CartItem> List => this.Items;
        public Cart(HttpContext ctx)
        {
            this.Session = ctx.Session;
            this.RequestCookies = ctx.Request.Cookies;
            this.ResponseCookies = ctx.Response.Cookies;
        }
        public void Load(Repository<Product> data)
        {
            this.Items = this.Session.GetObject<List<CartItem>>(CartKey);
            if (this.Items == null)
            {
                this.Items = new List<CartItem>();
                this.StoredItems = this.RequestCookies.GetObject<List<CartItemDTO>>(CartKey);
            }

            if (this.StoredItems?.Count > this.Items?.Count)
            {
                foreach (var storedItem in this.StoredItems)
                {
                    var book = data.Get(new QueryOptions<Product> {
                        Include = "Type",
                        Where = b => b.ProductId == storedItem.ProductId
                    });
                    if (book != null)
                    {
                        var dto = new ProductDTO();
                        dto.Load(book);

                        var item = new CartItem {
                            Product = dto,
                            Quantity = storedItem.Quantity
                        };
                        this.Items.Add(item);
                    }
                }

                this.Save();
            }
        }
        public CartItem GetById(int id)
        {
            return this.Items.FirstOrDefault(ci => ci.Product.ProductId == id);
        }
        public void Add(CartItem item)
        {
            var itemInCart = this.GetById(item.Product.ProductId);

            if (itemInCart == null)
            {
                this.Items.Add(item);
            }
            else
            {
                itemInCart.Quantity += 1;
            }
        }
        public void Edit(CartItem item)
        {
            var itemInCart = this.GetById(item.Product.ProductId);
            if (itemInCart != null)
            {
                itemInCart.Quantity = item.Quantity;
            }
        }
        public void Remove(CartItem item)
        {
            this.Items.Remove(item);
        }
        public void Clear()
        {
            this.Items.Clear();
        }
        public void Save()
        {
            if (this.Items.Count == 0)
            {
                this.Session.Remove(CartKey);
                this.Session.Remove(CountKey);
                this.ResponseCookies.Delete(CartKey);
                this.ResponseCookies.Delete(CountKey);
            }
            else
            {
                this.Session.SetObject(CartKey, this.Items);
                this.Session.SetInt32(CountKey, this.Items.Count);
                this.ResponseCookies.SetObject(CartKey, this.Items.ToDTO());
                this.ResponseCookies.SetInt32(CountKey, this.Items.Count);
            }
        }
    }
}