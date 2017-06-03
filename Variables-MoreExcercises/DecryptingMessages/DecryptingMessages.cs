/// <summary>
/// Problem 13.	Decrypting Messages
/// You will receive a key(integer) and n characters afterward.Add the key to each of the characters and append them to message. At the end print the message, which you decrypted.
/// Input
/// On the first line, you will receive the key
/// On the second line, you will receive n – the number of lines, which will follow
/// On the next n lines – you will receive lower and uppercase characters from the Latin alphabet
/// Output
/// Print the decrypted message.
/// </summary>
using System;
using System.Text;

public class DecryptingMessages
{
    public static void Main()
    {
        int key = int.Parse(Console.ReadLine());
        byte n = byte.Parse(Console.ReadLine());

        StringBuilder result = new StringBuilder();

        for (int i = 0; i < n; i++)
        {
            char currentChar = char.Parse(Console.ReadLine());
            result.Append((char)((currentChar) + key));
        }

        Console.WriteLine(result.ToString());
    }
}