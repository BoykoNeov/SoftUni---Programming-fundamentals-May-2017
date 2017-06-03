/// <summary>
/// Write a program, which combines n characters and prints on a single line the combinations of these characters
/// </summary>
using System;

public class MakeAWord
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char[] inputs = new char[n];
        for (int i = 0; i < n; i++)
        {
            inputs[i] = (char)Console.Read();
            Console.ReadLine();
        }

        Console.Write("The word is: ");
        foreach (char letter in inputs)
        {
            Console.Write(letter);
        }

        Console.WriteLine();
    }
}