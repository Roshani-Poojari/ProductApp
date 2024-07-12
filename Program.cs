using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductApp.Model;

namespace ProductApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(1,"Television",50000,10);
            Console.WriteLine($"Product id: {product1.Id} \n" +
                $"Product name: {product1.Name} \n" +
                $"Actual price: {product1.Price} \n" +
                $"Discount %: {product1.DiscountPercent} \n" +
                $"Price after discount: {product1.PriceAfterDiscount()}");


            Console.WriteLine("========================================================================");

            Product product2 = new Product(2,"Smart phone",19000,50);
            Console.WriteLine($"Product id: {product2.Id} \n" +
                $"Product name: {product2.Name} \n" +
                $"Actual price: {product2.Price} \n" +
                $"Discount %: {product2.DiscountPercent} \n" +
                $"Price after discount: {product2.PriceAfterDiscount()}");

        }
    }
}
