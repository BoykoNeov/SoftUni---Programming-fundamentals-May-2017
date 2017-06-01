using System;
using System.Text;

public class PrintPartOfASCIITable
{
    public static void Main()
    {
        int startIndex = int.Parse(Console.ReadLine());
        int endIndex = int.Parse(Console.ReadLine());

        StringBuilder result = new StringBuilder();
        for (int letter = startIndex; letter <=endIndex ; letter++)
        {
            result.Append((char)letter);
            result.Append(" ");
        }

        Console.WriteLine(result);
    }
}