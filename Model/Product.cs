using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Model
{
    internal class Product
    {
        private int _prodId;
        private string _prodName;
        private double _prodPrice;
        private double _prodDiscountPercent;
        private const double discountMax = 40;
        private const double discountMin = 20;
        public int Id { set { _prodId = value; } get { return _prodId; } }
        public string Name { set { _prodName = value; } get { return _prodName; } }
        public double Price { set { _prodPrice = value; } get {return _prodPrice;} }
        public double DiscountPercent { 
            set {  _prodDiscountPercent = value;
                if (value > discountMax)
                    _prodDiscountPercent = 40;
                else if (value < discountMin)
                    _prodDiscountPercent = 20;
                else
                    _prodDiscountPercent = value;
            } 
            get { return _prodDiscountPercent;} 
        }
        public Product()//default constructor
        {
            Console.WriteLine("Default constructor");
        }
        public Product(int id, string name, double price, double discountPercent):this()//parameterized constructor
        {
            Id = id;
            Name = name;
            Price = price;
            DiscountPercent = discountPercent;
        }

        public double PriceAfterDiscount() {
            return _prodPrice - (_prodPrice * _prodDiscountPercent) / 100;
        }
    }
}
