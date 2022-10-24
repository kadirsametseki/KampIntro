using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            //instance creation
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product
            {
                Id = 2,
                CategoryId = 5,
                UnitsInStock = 5,
                ProductName = "Kalem",
                UnitPrice = 35
            };

            //PascalCase    //camelCase
            //case sensitive
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Update(product2);
            Console.WriteLine(product1.CategoryId);

            //int, decimal, float, double, bool - değer tip
            //array, class, interface - referans tip
            //ref out

        }
    }
}