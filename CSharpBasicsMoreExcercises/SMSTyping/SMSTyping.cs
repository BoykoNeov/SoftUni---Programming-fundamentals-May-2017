/// <summary>
/// Write a program, which emulates typing an SMS
/// Input
///	On the first line, you will receive n - the number of characters – integer in the range[1…30]
///	On the next n lines, you will receive integers, representing the text message characters.
/// Output
/// Print all the characters together, forming a text message string.
/// </summary>
using System;
using System.Collections.Generic;
using System.Text;

public class SMSTyping
{
    public static void Main()
    {
        Dictionary<string, string> keyPresses = new Dictionary<string, string>()
        {
            {"2" , "a" },
            {"22", "b" },
            {"222", "c"},
            {"3", "d" },
            {"33", "e" },
            {"333", "f" },
            {"4", "g" },
            {"44", "h" },
            {"444", "i" },
            {"5", "j" },
            {"55", "k" },
            {"555", "l" },
            {"6", "m" },
            {"66", "n" },
            {"666", "o" },
            {"7", "p" },
            {"77", "q" },
            {"777", "r" },
            {"7777", "s" },
            {"8", "t" },
            {"88", "u" },
            {"888", "v" },
            {"9", "w" },
            {"99", "x" },
            {"999", "y" },
            {"9999", "z" },
            {"0", " " }
        };

        int n = int.Parse(Console.ReadLine());

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < n; i++)
        {
            sb.Append(keyPresses[Console.ReadLine()]);
        }

        Console.WriteLine(sb.ToString());
    }
}