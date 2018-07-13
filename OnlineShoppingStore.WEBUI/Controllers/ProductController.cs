using OnlineShoppingStore.Domain.Abstract;
using OnlineShoppingStore.Domain.Entities;
using OnlineShoppingStore.WEBUI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace OnlineShoppingStore.WEBUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository productRepository;
        private int PageSize = 3;
        private IEnumerable<Product> FilteredProduct;
        public ProductController(IProductRepository repository)
        {
            productRepository = repository;
        }

        // GET: Product
        public ViewResult AllProducts(string CurrCategory, int Page = 1)
        {
            FilteredProduct = productRepository.Products.OrderBy(p => p.ProductId).Skip((Page - 1) * PageSize).Take(PageSize);

            if (CurrCategory != "All")
            {
                FilteredProduct = productRepository.Products.Where(w => w.Category == null || w.Category == CurrCategory)
                                .OrderBy(p => p.ProductId).Skip((Page - 1) * PageSize).Take(PageSize);
            }

            ProductListViewModel productListViewModel = new ProductListViewModel
            {
                //Products = productRepository.Products.Where(w => w.Category == null || w.Category == CurrCategory)
                //.OrderBy(p => p.ProductId).Skip((Page - 1) * PageSize).Take(PageSize)
                Products = FilteredProduct,
                PagingInfo = new PagingInfo
                {
                    CurrentPage = Page,
                    ItemsPerPage = PageSize,
                    TotalItems = productRepository.Products.Where(w => w.Category == CurrCategory).Count()
                },
                CurrentCategory = CurrCategory
            };
            return View(productListViewModel);
        }
    }
}