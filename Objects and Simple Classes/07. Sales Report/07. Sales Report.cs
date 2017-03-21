using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sales_Report
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var result = new SortedDictionary<string, decimal>();


            for (int i = 0; i < n; i++)
            {
                var currentSaleString = Console.ReadLine();
                var currentSale = Sale.Parse(currentSaleString);

                if (!result.ContainsKey(currentSale.Town))
                {
                    result[currentSale.Town] = 0;
                }
                result[currentSale.Town] += currentSale.Price * currentSale.Quantity;
              
            }

            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value:F2}");
            }

        }

       
    }
}
