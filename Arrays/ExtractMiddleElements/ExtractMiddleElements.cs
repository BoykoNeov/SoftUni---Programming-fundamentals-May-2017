using System;
using System.Linq;

public class ExtractMiddleElements
{
    public static void Main()
    {
        int[] intArray = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        if (intArray.Length == 1)
        {
            Console.WriteLine(intArray[0]);
        }

       else if (intArray.Length > 1 && (intArray.Length % 2 == 0))
        {
            int position = (intArray.Length - 2) / 2;
            Console.WriteLine($"{{ {intArray[position]} , {intArray[position+1]} }}");
        }

        else if (intArray.Length > 1 && (intArray.Length % 2 != 0))
        {
            int position = (intArray.Length - 3) / 2;
            Console.WriteLine($"{{ {intArray[position]} , {intArray[position + 1]} , {intArray[position + 2]} }}");
        }
    }
}