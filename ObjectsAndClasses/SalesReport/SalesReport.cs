// Read a list of sales and calculate and print the total sales by town as shown in the output.
// Order alphabetically the towns in the output.

using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesReport
{
    public class SalesReport
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Sale[] totalSales = new Sale[n];
            Dictionary<string, double> citySales = new Dictionary<string, double>();

            for (int i = 0; i < n; i++)
            {
                totalSales[i] = new Sale();
                totalSales[i] = Sale.ReadSale(Console.ReadLine());

                if (!citySales.ContainsKey(totalSales[i].Town))
                {
                    citySales[totalSales[i].Town] = totalSales[i].Price * totalSales[i].Quantity;
                }
                else
                {
                    citySales[totalSales[i].Town] += totalSales[i].Price * totalSales[i].Quantity;
                }
            }

            foreach (var kvpSales in citySales.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{kvpSales.Key} -> {kvpSales.Value:f2}");
            }
        }
    }
}