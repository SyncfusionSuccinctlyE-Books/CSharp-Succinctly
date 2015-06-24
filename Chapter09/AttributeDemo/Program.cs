using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var cart = new ShoppingCart();

            cart.Add("chips");

            var prices = new decimal[] { 1.25m, 3.50m, 9.10m };
            
            //cart.CalculateTax(prices);
        }
    }
}
