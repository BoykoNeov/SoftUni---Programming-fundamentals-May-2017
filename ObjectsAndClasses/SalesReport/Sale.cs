using System;
using System.Linq;

namespace SalesReport
{
    public class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }

        public static Sale ReadSale(string input)
        {
            Sale returnSale = new Sale();
            string[] splitedInput = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            returnSale.Town = splitedInput[0];
            returnSale.Product = splitedInput[1];
            returnSale.Price = double.Parse(splitedInput[2]);
            returnSale.Quantity = double.Parse(splitedInput[3]);

            return returnSale;
        }
    }
}
