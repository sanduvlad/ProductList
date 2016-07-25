using DataContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopList.DataContext
{
    public class SessionProductContext : IProductContext
    {
        public List<Product> GetProducts()
        {
            var products = HttpContext.Current.Session["products"];

            if (products is List<Product>)
                return products as List<Product>;
            else return null;
        }

        public void SaveProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}