using System;
using System.Linq;
using System.Collections.Generic;

/// <summary>
/// For this task, you can use your solution from Inventory Matcher.
/// You will again receive 3 arrays – one with strings, one with longs
/// and one with decimals.Again, the price and quantity correspond to a name, which is located on same index as the name.
/// This time only the arrays containing the names and the array containing 
/// the prices will have the same length.If in the quantities array there is no index, which corresponds to the name, you should assume the quantity is 0.
/// On top of that the products, which you receive after the arrays will contain
/// not only a string for the name, but also a long, which is the quantity that must be ordered. 
/// If you have enough quantity, calculate the total price by multiplying the
/// ordered quantity times the price and print it in the following format:
/// {quantity ordered}
/// x {product name} costs {total price of the order}
/// Format the price to the 2nd decimal place.Do not forget to decrease the quantity of the product.
/// If you do not have enough quantities print:
/// We do not have enough { product name}
/// Input
/// On the first line, you will receive array of strings, which represent the names of the products.
/// On the second line, you will receive array of longs, which represent the quantities of the products.
/// On the third line, you will receive array of decimals, which represent the prices of the products.
/// Constraints
/// The name and price arrays will always have the same length.
/// You will always receive existing products
/// </summary>
public class UpgradedMatcher
{
    public static void Main()
    {
        string[] productNames = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        long[] productQuantity = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(long.Parse)
            .ToArray();

        decimal[] productPrice = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(decimal.Parse)
            .ToArray();

        Dictionary<string, decimal[]> products = new Dictionary<string, decimal[]>();

        foreach (string product in productNames)
        {
            products.Add(product, new decimal[2]);
            products[product][1] = productPrice[Array.IndexOf(productNames, product)];

            try
            {
                products[product][0] = productQuantity[Array.IndexOf(productNames, product)];
            }
            catch
            {
                products[product][0] = 0;
            }
        }

        string currentProduct = string.Empty;

        while ((currentProduct = Console.ReadLine()) != "done")
        {
            string[] parameters = currentProduct.Split();
            string paramProduct = parameters[0];
            long paramQuantity = long.Parse(parameters[1]);

            if (products[paramProduct][0] >= paramQuantity)
            {
                decimal paramPrice = products[paramProduct][1];
                Console.WriteLine($"{paramProduct} x {paramQuantity} costs {paramQuantity * paramPrice:f2}");

                products[paramProduct][0] -= paramQuantity;
            }
            else
            {
                Console.WriteLine($"We do not have enough {paramProduct}");
            }
        }
    }
}