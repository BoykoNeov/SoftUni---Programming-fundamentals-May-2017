using System;
using System.Collections.Generic;
public class PracticeCharsAndStrings
{
    public static void Main()
    {
        List<string> output = new List<string>
        {
            "Software University", "B", "y", "e", "I love programming"
        };
            foreach (string outputLine in output)
        {
            Console.WriteLine(outputLine);
        }
    }
}