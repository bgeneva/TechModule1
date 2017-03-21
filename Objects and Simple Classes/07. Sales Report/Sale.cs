using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sales_Report
{
    public class Sale
    {
        //Write a class Sale holding the following data: 
        //town, product, price, quantity
        public string Town { get; set; }

        public string Product { get; set; }

        public decimal Price { get; set; }

        public decimal Quantity { get; set; }

        public static Sale Parse(string inputLine)
        {
            var saleParts = inputLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            return new Sale
            {
                Town = saleParts[0],
                Product = saleParts[1],
                Price = decimal.Parse(saleParts[2]),
                Quantity = decimal.Parse(saleParts[3])
            };
        }
    }
}
