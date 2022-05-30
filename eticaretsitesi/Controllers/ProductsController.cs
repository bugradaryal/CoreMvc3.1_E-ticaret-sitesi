using Microsoft.AspNetCore.Mvc;
using eticaretsitesi.Models;

namespace eticaretsitesi.Controllers
{
    public class ProductsController : Controller
    {
        private ProductUnitOfWork Data { get; }
        public ProductsController(ProductContext ctx)
        {
            this.Data = new ProductUnitOfWork(ctx);
        }
        public IActionResult List(ProductGridDTO values)
        {
            var builder = new ProductsGridBuilder(HttpContext.Session, values,
                nameof(OfficeProduct.Name));

            var options = new ProductQueryOptions {
                Include = "Type",
                OrderByDirection = builder.CurrentRoute.SortDirection,
                PageNumber = builder.CurrentRoute.PageNumber,
                PageSize = builder.CurrentRoute.PageSize
            };
            options.SortFilter(builder);

            var vm = new ProductListViewModel {
                Products = this.Data.Products.List(options),
                ProductTypes = this.Data.Types.List(new QueryOptions<ProductType> {
                    OrderBy = g => g.Name
                }),
                Images = this.Data.Images.List(new QueryOptions<Image>()),
                CurrentRoute = builder.CurrentRoute,
                TotalPages = builder.GetTotalPages(this.Data.Products.Count)
            };

            return View(vm);
        }
        [HttpPost]
        public RedirectToActionResult Filter(string[] filter, bool clear = false)
        {
            var builder = new ProductsGridBuilder(HttpContext.Session);

            if (clear)
            {
                builder.ClearFilterSegments();
            }
            else
            {
                builder.LoadFilterSegments(filter);
            }

            builder.SaveRouteSegments();
            return RedirectToAction("List", builder.CurrentRoute);
        }
        public ViewResult Details(int id)
        {
            var product = this.Data.Products.Get(new QueryOptions<OfficeProduct> {
                Include = "Type",
                Where = b => b.OfficeProductId == id
            });
            var image = this.Data.Images.Get(product.ImageId);
            ViewBag.Url = image.Url();
            return View(product);
        }
    }
}