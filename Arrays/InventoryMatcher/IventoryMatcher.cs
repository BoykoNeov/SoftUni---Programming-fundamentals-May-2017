using System;
using System.Linq;

/// <summary>
/// You will be given three arrays on different lines. The first one will contain strings, which will represent the name of products. Second one will contain longs and will represent the quantities of the products. The third one will contain double and represents the price of the product. 
/// After which, you will be given names of products on new lines, until you receive the command “done”. For each given product name print:
/// {name of the product} costs: {price}; Available quantity: {quantity}
/// The names, prices and quantities of the products are in the same indices in the 3 arrays.
/// Input
/// On the first line, you will receive an array of strings, which represent the names of the products.
/// On the second line, you will receive an array of longs, which represent the quantities of the products.
/// On the third line, you will receive an array of decimals, which represent the prices of the products.
/// Constraints
/// The three arrays will always have the same length.
/// You will always receive existing products
/// </summary>
public class IventoryMatcher
{
    public static void Main()
    {
        string[] productNames = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.None)
            .ToArray();

        long[] productQuantity = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.None)
            .Select(long.Parse)
            .ToArray();

        decimal[] productPrice = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.None)
            .Select(decimal.Parse)
            .ToArray();

        string currentProduct = string.Empty;

        while ((currentProduct = Console.ReadLine()) != "done")
        {
            int seekedIndex = Array.IndexOf(productNames, currentProduct);
            long currentQuantity = productQuantity[seekedIndex];
            decimal currentPrice = productPrice[seekedIndex];
            Console.WriteLine($"{currentProduct} costs: {currentPrice}; Available quantity: {currentQuantity}");
        }
    }
}