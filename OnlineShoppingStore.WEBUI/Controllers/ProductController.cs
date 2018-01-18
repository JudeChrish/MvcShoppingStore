using OnlineShoppingStore.Domain.Abstract;
using OnlineShoppingStore.WEBUI.Models;
using System.Linq;
using System.Web.Mvc;

namespace OnlineShoppingStore.WEBUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository productRepository;
        private int PageSize = 3;
        public ProductController(IProductRepository repository)
        {
            productRepository = repository;
        }

        // GET: Product
        public ViewResult AllProducts(string CurrCategory, int Page = 1)
        {

            ProductListViewModel productListViewModel = new ProductListViewModel
            {
                Products = productRepository.Products.Where(w => w.Category == null || w.Category == CurrCategory)
                .OrderBy(p => p.ProductId).Skip((Page - 1) * PageSize).Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = Page,
                    ItemsPerPage = PageSize,
                    TotalItems = productRepository.Products.Count()
                },
                CurrentCategory = CurrCategory
            };
            return View(productListViewModel);
        }
    }
}