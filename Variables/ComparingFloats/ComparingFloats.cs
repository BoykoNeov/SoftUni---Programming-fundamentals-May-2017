using System;

public class ComparingFloats
{
    public static void Main()
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double eps = 0.000001;
        double difference = Math.Abs(firstNumber - secondNumber);

            Console.WriteLine(difference <= eps);
    }
}