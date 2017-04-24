// Write a program that reads a text file and writes its every odd line in another file. Line numbers starts from 0. 

using System;
using System.IO;
using System.Text;

public class OddLines
{
    public static void Main()
    {
        string[] input = File.ReadAllText("input.txt").Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
        StringBuilder output = new StringBuilder();

        for (int i = 1; i < input.Length; i += 2)
        {
            output.AppendLine(input[i]);
        }

        File.WriteAllText("output.txt", output.ToString());
    }
}