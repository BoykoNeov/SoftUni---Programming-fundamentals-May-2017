using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class Regexmon
{
    public static void Main()
    {
        string BojomonPattern = @"([A-Za-z]+-[A-Za-z]+)(.*)";
        string DidimonPattern = @"([^A-Za-z\-]+)(.*)";

        string input = Console.ReadLine();

        Regex BojoRegex = new Regex(BojomonPattern);
        Regex DidiRegex = new Regex(DidimonPattern);

        while (true)
        {
            Match didiMatch = DidiRegex.Match(input);
            
            if (didiMatch.Groups[1].Length == 0)
            {
                break;
            }

            Console.WriteLine(didiMatch.Groups[1].ToString());

            Match bojoMatch = BojoRegex.Match(didiMatch.Groups[2].ToString());

            if (bojoMatch.Groups[1].Length == 0)
            {
                break;
            }

            Console.WriteLine(bojoMatch.Groups[1].ToString());

            input = bojoMatch.Groups[2].ToString();
        }
    }
}