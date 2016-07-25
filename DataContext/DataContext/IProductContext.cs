using DataContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopList.DataContext
{
    public interface IProductContext
    {
        List<Product> GetProducts();

        void SaveProduct(Product product);
    }
}
