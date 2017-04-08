using System;
using System.Linq;

public class RotateArrayByReversion
{
    public static void Main()
    {
        string[] ReversionArray = Console.ReadLine()
            .Split(new char[] { ' ', ';', '!', ',', '?', '.', '/', '\\' }, StringSplitOptions.
            RemoveEmptyEntries).
            ToArray();

        int d = int.Parse(Console.ReadLine()) % ReversionArray.Length;

        Array.Reverse(ReversionArray, 0, d);
        Array.Reverse(ReversionArray, d+1, ReversionArray.Length - d - 1);
        Array.Reverse(ReversionArray);


        Console.WriteLine(string.Join(" ", ReversionArray));
    }
}