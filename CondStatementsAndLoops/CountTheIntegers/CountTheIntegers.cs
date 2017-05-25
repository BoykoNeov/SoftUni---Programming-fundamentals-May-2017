/// <summary>
/// Write a program, which can receive any type of input, but upon receiving anything 
/// other than an integer – stops the execution of the program and prints how many numbers were read.
/// </summary>
using System;
public class CountTheIntegers
{
    public static void Main()
    {
        int counter = 0;
        while (true)
        {
            try
            {
                int.Parse(Console.ReadLine());
                counter++;
            }
            catch
            {
                Console.WriteLine(counter);
                break;
            }
        }
    }
}