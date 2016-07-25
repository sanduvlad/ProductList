using DataContext.Models;
using ShopList.DataContext;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace ShopList.Controllers
{
    public class ShoplistController : Controller
    {
        IProductContext productContext;
        public ShoplistController()
        {
            productContext = new TextFileProductContext();
        }

        // GET: Shoplist
        public ActionResult Index()
        {
            var products = productContext.GetProducts();
            return View();
        }

        public ActionResult Add()
        {            
            return PartialView();
        }

        [HttpPost]
        public ActionResult Save(Product model)
        {
            productContext.SaveProduct(model);
            return RedirectToAction("Index");
        }

        public ActionResult ProductList()
        {
            //if (products == null)
              var  products = productContext.GetProducts();

            return PartialView(products);
        }
    }
}