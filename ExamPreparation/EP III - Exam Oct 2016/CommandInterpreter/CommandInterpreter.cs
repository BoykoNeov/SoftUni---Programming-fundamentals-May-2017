/// <summary>
/// You will be given a series of strings on a single line, separated by one or more whitespaces. These represent the collection you’ll be working with.
/// On the next input lines, until you receive the command "end", you’ll receive a series of commands in one of the following formats:
/// "reverse from [start] count [count]" – this instructs you to reverse a portion of the array – just[count] elements starting at index[start];
/// "sort from [start] count [count]" – this instructs you to sort a portion of the array - [count] elements starting at index [start];
/// "rollLeft [count] times" – this instructs you to move all elements in the array to the left[count] times. On each roll, the first element is placed at the end of the array;
/// "rollRight [count] times" – this instructs you to move all elements in the array to the right[count] times. On each roll, the last element is placed at the beginning of the array;
/// If any of the provided indices or counts is invalid (non-existent or negative), you should print a message on the console – "Invalid input parameters." and keep the collection unchanged.
/// After you’re done, print the resulting array in the following format: "[arr0, arr1 … arrN]". The examples should help you understand the task better.
/// Input
/// The input data should be read from the console.
/// The first input line will hold a series of strings, separated by one or more whitespaces.
/// The next lines will hold commands in the described formats (exactly).
/// The input ends with the keyword "end".
/// The input data will always be valid and in the format described. There is no need to check it explicitly.
/// Output
/// The output should be printed on the console. 
/// Each time an invalid command is received (containing an invalid index or count parameter), print the following line: "Invalid input parameters."
/// After receiving the "end" command, print the resulting array on the console in the format specified above.
/// Constraints
/// The count of strings in the collection will be in the range [1 … 50].
/// The number of commands will be in the range [1 … 20].
/// All commands will be in the described format; an invalid command is a command containing invalid [start]
/// or [count], there won’t be any missing or misspelled words.
/// [start]
/// and[count]
/// will be integers in the range [-231 … 231 - 1].
/// Allowed working time for your program: 0.1 seconds. Allowed memory: 16 MB.
/// </summary>
namespace CommandInterpreter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CommandInterpreter
    {
        public static void Main()
        {
            string[] inputs = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string commandLine = string.Empty;

            while ((commandLine = Console.ReadLine()) != "end")
            {
                string[] commandParameters = commandLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                try
                {
                    string mainCommand = commandParameters[0];

                    switch (mainCommand)
                    {
                        case "reverse":
                            int startReverse = int.Parse(commandParameters[2]);
                            int countReverse = int.Parse(commandParameters[4]);

                            if (startReverse < 0 ||
                                startReverse > inputs.Length - 1 ||
                                countReverse < 0 ||
                                countReverse + startReverse > inputs.Length)
                            {
                                throw new Exception();
                            }

                            string[] arrayBeginning = inputs.Take(startReverse)
                                                        .ToArray();

                            string[] reversedPart = inputs.Skip(startReverse)
                                                        .Take(countReverse)
                                                        .Reverse()
                                                        .ToArray();

                            string[] arrayEnd = inputs.Skip(countReverse + startReverse)
                                                        .ToArray();

                            List<string> tempList = new List<string>();
                            tempList.AddRange(arrayBeginning);
                            tempList.AddRange(reversedPart);
                            tempList.AddRange(arrayEnd);
                            inputs = tempList.ToArray();
                            break;

                        case "sort":
                            int startSort = int.Parse(commandParameters[2]);
                            int countSort = int.Parse(commandParameters[4]);

                            if (startSort < 0 ||
                                startSort > inputs.Length - 1 ||
                                countSort < 0 ||
                                countSort + startSort > inputs.Length)
                            {
                                throw new Exception();
                            }

                            string[] arrayBeginning2 = inputs.Take(startSort)
                                                                .ToArray();

                            string[] sortedPart = inputs.Skip(startSort)
                                                        .Take(countSort)
                                                        .OrderBy(x => x)
                                                        .ToArray();

                            string[] arrayEnd2 = inputs.Skip(countSort + startSort)
                                                        .ToArray();

                            List<string> tempList2 = new List<string>();
                            tempList2.AddRange(arrayBeginning2);
                            tempList2.AddRange(sortedPart);
                            tempList2.AddRange(arrayEnd2);
                            inputs = tempList2.ToArray();
                            break;

                        case "rollLeft":
                            int countRollLeft = int.Parse(commandParameters[1]);

                            if (countRollLeft < 0)
                            {
                                throw new Exception();
                            }

                            countRollLeft = countRollLeft % inputs.Length;
                            string[] tempArray = new string[inputs.Length];
                            for (int i = 0; i < inputs.Length; i++)
                            {
                                tempArray[i] = inputs[(i + countRollLeft) % inputs.Length];
                            }

                            inputs = tempArray;
                            break;

                        case "rollRight":
                            int countRollRight = int.Parse(commandParameters[1]);

                            if (countRollRight < 0)
                            {
                                throw new Exception();
                            }

                            countRollRight = countRollRight % inputs.Length;
                            countRollRight = inputs.Length - countRollRight;
                            string[] tempArray2 = new string[inputs.Length];
                            for (int i = 0; i < inputs.Length; i++)
                            {
                                tempArray2[i] = inputs[(i + countRollRight) % inputs.Length];
                            }

                            inputs = tempArray2;
                            break;

                        default:
                            throw new Exception();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input parameters.");
                }
            }

            Console.WriteLine("[" + string.Join(", ", inputs) + "]");
        }
    }
}