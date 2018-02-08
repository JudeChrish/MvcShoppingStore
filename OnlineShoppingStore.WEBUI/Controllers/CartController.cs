using OnlineShoppingStore.Domain.Abstract;
using OnlineShoppingStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShoppingStore.Domain.Helpers;
using OnlineShoppingStore.WEBUI.Models;

namespace OnlineShoppingStore.WEBUI.Controllers
{
    public class CartController : Controller
    {
        private IProductRepository repository;
        private Carthelper CartHelper;
        
        public CartController(IProductRepository productRepository)
        {
            repository = productRepository;
        }

        public RedirectToRouteResult AddToCart(int ProductId, string returnUrl)
        {
            Product product = repository.Products.FirstOrDefault(p => p.ProductId == ProductId);
            if(product != null)
            {
                //Cart CartSession = (Cart)Session["Cart"];
                //CartHelper.GetCart(CartSession).AddItem(product, 1);
                GetCart().AddItem(product,1);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        public RedirectToRouteResult RemoveProduct(int ProductId, string returnUrl)
        {
            Product product = repository.Products.FirstOrDefault(f => f.ProductId == ProductId);
            if(product != null)
            {
                Cart cart = (Cart)Session["Cart"];
                CartHelper.GetCart(cart).RemoveItem(product, 1);
            }
            return RedirectToAction("Index", new { returnUrl });
        }
        
        // GET: Cart
        public ViewResult Index(string ReturnUrl)
        {
            //Cart cart = CartHelper.GetCart((Cart)Session["Cart"]);
            Cart cart = GetCart();
            CartIndexViewModel indexViewModel = new CartIndexViewModel();
            indexViewModel.cart = cart;
            indexViewModel.ReturnUlr = ReturnUrl;

            return View(indexViewModel);
        }

        public Cart GetCart()
        {
            Cart cart = (Cart)Session["Cart"];
            if (cart == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }
            return cart;
        }
    }
}