using System.IO;
using eticaretsitesi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eticaretsitesi.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class ProductsController : Controller
    {
        private ProductUnitOfWork Data { get; }
        public ProductsController(ProductContext ctx)
        {
            this.Data = new ProductUnitOfWork(ctx);
        }
        public IActionResult Index()
        {
            var search = new SearchData(TempData);
            search.Clear();

            return View();
        }
        [HttpPost]
        public RedirectToActionResult Search(SearchViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var search = new SearchData(TempData) {
                    SearchTerm = vm.SearchTerm,
                    Type = vm.Type
                };
                return RedirectToAction("Search");
            }

            return RedirectToAction("Index");
        }
        [HttpGet]
        public ViewResult Search()
        {
            var search = new SearchData(TempData);

            if (search.HasSearchTerm)
            {
                var vm = new SearchViewModel {
                    SearchTerm = search.SearchTerm
                };

                var options = new QueryOptions<OfficeProduct> {
                    Include = "Type"
                };
                if (search.IsProduct)
                {
                    options.Where = b => b.Name.Contains(vm.SearchTerm);
                    vm.Header = $"Ürün adı için arama sonuçları '{vm.SearchTerm}'";
                }

                if (search.IsType)
                {
                    options.Where = b => b.ProductTypeId.Contains(vm.SearchTerm);
                    vm.Header = $"Ürün tipi için arama sonuçları '{vm.SearchTerm}'";
                }

                vm.Products = this.Data.Products.List(options);
                return View("SearchResults", vm);
            }

            return View("Index");
        }
        [HttpGet]
        public ViewResult Add(int id)
        {
            return this.getProduct(id, "Add");
        }
        [HttpPost]
        public IActionResult Add(ProductViewModel vm)
        {
            if (ModelState.IsValid)
            {
                if (Request.Form.Files.Count == 0)
                {
                    this.load(vm, "Add");
                    ModelState.AddModelError("", "Lütfen Resim Seçiniz.");
                    return View("Product", vm);
                }

                foreach (var file in Request.Form.Files)
                {
                    var img = new Image();
                    img.Title = file.FileName;

                    var ms = new MemoryStream();
                    file.CopyTo(ms);
                    img.Data = ms.ToArray();

                    ms.Close();
                    ms.Dispose();

                    this.Data.Images.Insert(img);
                    this.Data.Save();

                    vm.Product.ImageId = img.ImageId;
                }

                this.Data.Products.Insert(vm.Product);
                this.Data.Save();

                TempData["message"] = $"{vm.Product.Name} Ürünlere Eklendi.";
                return RedirectToAction("Index");
            }

            this.load(vm, "Add");
            return View("Product", vm);
        }
        [HttpGet]
        public ViewResult Edit(int id)
        {
            return this.getProduct(id, "Edit");
        }
        [HttpPost]
        public IActionResult Edit(ProductViewModel vm)
        {
            if (ModelState.IsValid)
            {
                this.Data.Products.Update(vm.Product);
                this.Data.Save();

                TempData["message"] = $"{vm.Product.Name} Güncellendi.";
                return RedirectToAction("Search");
            }

            this.load(vm, "Edit");
            return View("Product", vm);
        }
        [HttpGet]
        public ViewResult Delete(int id)
        {
            return this.getProduct(id, "Delete");
        }
        [HttpPost]
        public IActionResult Delete(ProductViewModel vm)
        {
            this.Data.Products.Delete(vm.Product);
            this.Data.Save();
            TempData["message"] = $"{vm.Product.Name} Ürünlerden Silindi.";
            return RedirectToAction("Search");
        }

        private ViewResult getProduct(int id, string operation)
        {
            var product = new ProductViewModel();
            this.load(product, operation, id);
            return View("Product", product);
        }

        private void load(ProductViewModel vm, string op, int? id = null)
        {
            if (Operation.IsAdd(op))
            {
                vm.Product = new OfficeProduct();
            }
            else
            {
                vm.Product = this.Data.Products.Get(new QueryOptions<OfficeProduct> {
                    Include = "Type",
                    Where = op => op.OfficeProductId == (id ?? vm.Product.OfficeProductId)
                });
            }

            vm.Types = this.Data.Types.List(new QueryOptions<ProductType> {
                OrderBy = pt => pt.Name
            });
        }
    }
}