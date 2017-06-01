using System;
public class BoolVariable
{
    public static void Main()
    {
        bool booleanInput = Convert.ToBoolean(Console.ReadLine());

        if (booleanInput)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}