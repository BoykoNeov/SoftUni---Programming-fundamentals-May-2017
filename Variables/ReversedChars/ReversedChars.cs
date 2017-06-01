using System;

public class ReversedChars
{
    public static void Main()
    {
        char[] output = new char[3];
        output[0] = char.Parse(Console.ReadLine());
        output[1] = char.Parse(Console.ReadLine());
        output[2] = char.Parse(Console.ReadLine());

        for (int i = output.Length-1; i >= 0; i--)
        {
            Console.Write(output[i]);
        }
    }
}