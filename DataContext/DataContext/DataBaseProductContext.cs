using ShopList.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataContext.Models;

namespace DataContext.DataContext
{
    class DataBaseProductContext : IProductContext
    {
        public List<Product> GetProducts()
        {
            return null;
        }

        public void SaveProduct(Product product)
        {
            
        }
    }
}
