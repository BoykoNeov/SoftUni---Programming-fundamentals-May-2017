// You are given a list of words in one line. Randomize their order and print each word at a separate line.

using System;
using System.Linq;

public class RandomizeWords
{
    public static void Main()
    {
        Random rand = new Random();
        string[] inputs = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        int inputsLength = inputs.Length;

        for (int i = 0; i < inputsLength; i++)
        {
            string temp = inputs[i];
            int randomIndex = rand.Next(0, inputsLength);
            inputs[i] = inputs[randomIndex];
            inputs[randomIndex] = temp;
        }

        foreach (string word in inputs)
        {
            Console.WriteLine(word);
        }
    }
}