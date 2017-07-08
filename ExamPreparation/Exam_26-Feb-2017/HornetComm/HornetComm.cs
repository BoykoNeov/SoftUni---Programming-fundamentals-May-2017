using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class HornetComm
{
    public static void Main()
    {
        string input = string.Empty;
        List<string> messages = new List<string>();
        List<string> broadcasts = new List<string>();

        while ((input = Console.ReadLine()) != "Hornet is Green")
        {
            string[] inputParams = input.Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries);

            if (inputParams.Length != 2)
            {
                continue;
            }

            bool isMessage = true;
            bool isBroadcast = true;

            foreach (char character in inputParams[0])
            {
                if (!char.IsDigit(character))
                {
                    isMessage = false;
                    break;
                }
            }

            foreach (char character in inputParams[1])
            {
                if (!char.IsLetterOrDigit(character))
                {
                    isMessage = false;
                    isBroadcast = false;
                    break;
                }
            }

            foreach (char character in inputParams[0])
            {
                if (char.IsDigit(character))
                {
                    isBroadcast = false;
                    break;
                }
            }

            if (isMessage)
            {
                string recipientCode = ReverseString(inputParams[0]);
                messages.Add(recipientCode + " -> " + inputParams[1]);
                continue;
            }

            if (isBroadcast)
            {
                char[] frequency = new char[inputParams[1].Length];

                for (int i = 0; i < frequency.Length; i++)
                {
                    char current = inputParams[1][i];

                    if (char.IsLetter(current))
                    {
                        if (char.IsUpper(current))
                        {
                            current += (char)32;
                        }
                        else
                        {
                            current -= (char)32;
                        }
                    }

                    frequency[i] = current;
                }

                broadcasts.Add((string.Join("", frequency)) + " -> " + inputParams[0]);
            }
        }

            Console.WriteLine("Broadcasts:");

            if (broadcasts.Count > 0)
            {
                foreach (string broadcast in broadcasts)
                {
                    Console.WriteLine(broadcast);
                }
            }
            else
            {
                Console.WriteLine("None");
            }

            Console.WriteLine("Messages:");

            if (messages.Count > 0)
            {
                foreach (string message in messages)
                {
                    Console.WriteLine(message);
                }
            }
            else
            {
                Console.WriteLine("None");
            }
    }

    public static string ReverseString(string s)
    {
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
}