using System;

    public class MainProgram
    {
        public static void Main()
        {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(number, 16).ToUpper());
        Console.WriteLine(Convert.ToString(number, 2));
        }
    }