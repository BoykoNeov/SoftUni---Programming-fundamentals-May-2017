/// <summary>
/// Write a program, which prints all the possible nucleic acid sequences (A, C, G and T), in the range [AAA…TTT]. Each nucleic acid sequence is exactly 3 nucleotides (letters) long. Print a new line every 4 sequences.
/// Each nucleotide has a corresponding numeric value – A  1, C  2, G  3, T  4.
/// For every sequence, take the sum of its elements(e.g.ACAC  1 + 2 + 1 + 2 = 6) and if it’s equal to or larger than the match sum, print the sequence with an “O” before and after it, otherwise print “X” before and after it.
/// </summary>
using System;
using System.Collections.Generic;

public class DNASequences
{
    public static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        Dictionary<int, string> code = new Dictionary<int, string>()
        {
            {1, "A" },
            {2, "C" },
            {3, "G" },
            {4, "T" }
        };

        for (int firstLetter = 1; firstLetter <= 4; firstLetter++)
        {
            for (int secondLetter = 1; secondLetter <= 4; secondLetter++)
            {
                for (int thirdLetter = 1; thirdLetter <= 4; thirdLetter++)
                {
                    if (firstLetter + secondLetter + thirdLetter >= sum)
                    {
                        Console.Write(string.Concat("O", code[firstLetter], code[secondLetter], code[thirdLetter], "O "));
                    }
                    else
                    {
                        Console.Write(string.Concat("X", code[firstLetter], code[secondLetter], code[thirdLetter], "X "));
                    }
                }

                Console.WriteLine();
            }
        }
    }
}