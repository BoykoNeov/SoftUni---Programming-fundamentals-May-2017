// Playing around with "+" , Concat and StringBuilder
using System;
using System.Diagnostics;
using System.Text;

public class JunkTests
{
    public static void Main()
    {
        Stopwatch timer = new Stopwatch();
        var a1 = new string[4000];
        var a2 = new string[a1.Length];
        for (int i = 0; i < a1.Length; i++)
        {
            a1[i] = Convert.ToString(i * 2);
            a2[i] = a1[i] + "ee";
        }

        Console.WriteLine(a1[a1.Length - 1]);
        var usingPlus = new string[a1.Length];
        var usingConcat = new string[a1.Length];
        var usingStringBuilder = new string[a1.Length];

        timer.Start();
        for (int i = 0; i < a1.Length; i++)
        {
            usingPlus[i] = a1[i] + a2[i];
        }

        timer.Stop();
        Console.WriteLine($"check result {usingPlus[usingPlus.Length - 1]}, time elapsed {timer.Elapsed}");

        timer.Restart();
        for (int i = 0; i < a1.Length; i++)
        {
            usingConcat[i] = string.Concat(a1[i], a2[i]);
        }

        timer.Stop();
        Console.WriteLine($"check result {usingConcat[usingConcat.Length - 1]}, time elapsed {timer.Elapsed}");

        timer.Restart();
        for (int i = 0; i < a1.Length; i++)
        {
            StringBuilder builder2 = new StringBuilder();
            usingStringBuilder[i] = Convert.ToString(builder2.Append(a1[i]).Append(a2[i]));
        }

        timer.Stop();
        Console.WriteLine($"check result {usingStringBuilder[usingStringBuilder.Length - 1]}, time elapsed {timer.Elapsed}");

        string usingPlusLong = string.Empty;
        string usingConcatLong = string.Empty;
        string usingStringBuilderLong = string.Empty;

        timer.Restart();
        for (int i = 0; i < a1.Length; i++)
        {
            usingPlusLong = usingPlusLong + usingPlus[i];
        }

        timer.Stop();
        Console.WriteLine($"long string, using \"+\", time elapsed {timer.Elapsed}");

        timer.Restart();
        for (int i = 0; i < a1.Length; i++)
        {
            usingConcatLong = string.Concat(usingConcatLong, usingConcat[i]);
        }

        timer.Stop();
        Console.WriteLine($"long string using concat , time elapsed {timer.Elapsed}");

        timer.Restart();
        StringBuilder builder = new StringBuilder();
        for (int i = 0; i < a1.Length; i++)
        {
            builder.Append(usingStringBuilder[i]);
        }

        usingStringBuilderLong = Convert.ToString(builder);
        timer.Stop();
        Console.WriteLine($"using StringBuilder Long time elapsed {timer.Elapsed}");

        Console.WriteLine(usingPlusLong.Length);
        Console.WriteLine(usingConcatLong.Length);
        Console.WriteLine(usingStringBuilderLong.Length);
    }
}