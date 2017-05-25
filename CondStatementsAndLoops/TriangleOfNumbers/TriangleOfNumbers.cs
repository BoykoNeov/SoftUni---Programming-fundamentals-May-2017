/// <summary>
/// Write a program, which receives a number – n, and prints a triangle from 1 to n
/// </summary>
using System;
using System.Text;
public class TriangleOfNumbers
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        for (int i = 1; i <= n; i++)
        {
            StringBuilder sb = new StringBuilder();

            for (int j = 0; j < i; j++)
            {
                sb.Append(i);
                sb.Append(" ");
            }

            Console.WriteLine(sb.ToString().Trim());
        }
    }
}