using System;

/// <summary>
/// get the bigger of three numbers using recursion
/// </summary>
public class GetMax
{
    public static void Main()
    {
       int result = GetMaxMethod(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
        int c = int.Parse(Console.ReadLine());
        if (c > result) result = c;
        Console.WriteLine(result);
    }

    public static int GetMaxMethod(int a , int b)
    {
        if (a > b) return a;
        else return b;
    }
}