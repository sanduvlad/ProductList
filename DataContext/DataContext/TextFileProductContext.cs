using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataContext.Models;
using System.IO;

namespace ShopList.DataContext
{
    
    public class TextFileProductContext : IProductContext
    {
        private string FileLocation = @"D:/ProductList.txt";
        private StreamReader streamReader;
        StreamWriter streamWriter;

        public List<Product> GetProducts()
        {
            streamReader = new StreamReader(FileLocation);
            string[] lines = streamReader.
                ReadToEnd().Split(new string[] { "\n" }, StringSplitOptions.None).ToArray<string>();
            List<Product> products = new List<Product>();

            try
            {

                foreach (string prod in lines)
                {
                    if (prod != string.Empty)
                    {
                        Product p = new Product();
                        p.Name = prod.Split(' ')[0];
                        p.Description = prod.Split(' ')[1];
                        p.Price = Convert.ToDouble(prod.Split(' ')[2]);

                        products.Add(p);
                    }
                }
            }
            catch
            {
                products.Clear();
                products.Add(new Product
                {
                    Name = "There was an error on proccesing the text file",
                    Description = "-",
                    Price = 0
                });
                //streamReader.Close();
            }

            streamReader.Close();

            return products;
            
        }

        public void SaveProduct(Product product)
        {
            streamWriter = new StreamWriter(FileLocation, true);
            streamWriter.Write(Environment.NewLine);
            streamWriter.Write(product.Name + " " +
                product.Description + " " + product.Price);
            streamWriter.Close();
        }
    }
}