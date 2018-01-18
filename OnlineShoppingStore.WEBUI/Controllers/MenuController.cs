using OnlineShoppingStore.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShoppingStore.WEBUI.Controllers
{
    public class MenuController : Controller
    {
        private IProductRepository Repo;

       public MenuController(IProductRepository ProdRepo)
        {
            Repo = ProdRepo;
        }
        // GET: Menu
        public PartialViewResult Menu(string category)
        {
            ViewBag.SelectedCateory = category;
            IEnumerable<string> Categories = Repo.Products.Select(c => c.Category).Distinct().OrderBy(x => x);
            return PartialView(Categories);
        }
    }
}