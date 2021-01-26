using System;
using System.ComponentModel.Design;
using System.Net;

namespace OOP1
{
    public class ProductMenager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " Eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " Güncellendi.");
        }
    }
}