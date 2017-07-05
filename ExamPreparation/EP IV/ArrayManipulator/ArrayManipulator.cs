using System;
using System.Linq;
using System.Collections.Generic;

public class ArrayManipulator
{
    public static void Main()
    {
        int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
        string command = string.Empty;

        while ((command = Console.ReadLine()) != "end")
        {
            string[] parameters = command.Split();

            switch (parameters[0])
            {
                case "exchange":
                    int inputParam = int.Parse(parameters[1]);

                    if (inputParam > inputArray.Length - 1 || inputParam < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        List<int> newList = new List<int>(inputArray.Length);
                        newList.AddRange(inputArray.Skip(inputParam + 1));
                        newList.AddRange(inputArray.Take(inputParam + 1));
                        inputArray = newList.ToArray();
                    }

                    break;

                case "max":
                    if (parameters[1] == "even")
                    {
                        bool EvenNumberFound = false;
                        int currentMaxElement = int.MinValue;
                        int indexOfMaxElement = 0;

                        for (int i = 0; i < inputArray.Length; i++)
                        {
                            if (inputArray[i] % 2 == 0)
                            {
                                EvenNumberFound = true;

                                if (inputArray[i] >= currentMaxElement)
                                {
                                    indexOfMaxElement = i;
                                    currentMaxElement = inputArray[i];
                                }
                            }
                        }

                        if (EvenNumberFound)
                        {
                            Console.WriteLine(indexOfMaxElement);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                    }
                    else if (parameters[1] == "odd")
                    {
                        bool oddNumberFound = false;
                        int currentMaxElement = int.MinValue;
                        int indexOfMaxElement = 0;

                        for (int i = 0; i < inputArray.Length; i++)
                        {
                            if (inputArray[i] % 2 != 0)
                            {
                                oddNumberFound = true;

                                if (inputArray[i] >= currentMaxElement)
                                {
                                    indexOfMaxElement = i;
                                    currentMaxElement = inputArray[i];
                                }
                            }
                        }

                        if (oddNumberFound)
                        {
                            Console.WriteLine(indexOfMaxElement);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                    }

                    break;

                case "min":
                    if (parameters[1] == "even")
                    {
                        bool EvenNumberFound = false;
                        int currentMinElement = int.MaxValue;
                        int indexOfMinElement = 0;

                        for (int i = 0; i < inputArray.Length; i++)
                        {
                            if (inputArray[i] % 2 == 0)
                            {
                                EvenNumberFound = true;

                                if (inputArray[i] <= currentMinElement)
                                {
                                    indexOfMinElement = i;
                                    currentMinElement = inputArray[i];
                                }
                            }
                        }

                        if (EvenNumberFound)
                        {
                            Console.WriteLine(indexOfMinElement);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                    }
                    else if (parameters[1] == "odd")
                    {
                        bool oddNumberFound = false;
                        int currentMinElement = int.MaxValue;
                        int indexOfMinElement = 0;

                        for (int i = 0; i < inputArray.Length; i++)
                        {
                            if (inputArray[i] % 2 != 0)
                            {
                                oddNumberFound = true;

                                if (inputArray[i] <= currentMinElement)
                                {
                                    indexOfMinElement = i;
                                    currentMinElement = inputArray[i];
                                }
                            }
                        }

                        if (oddNumberFound)
                        {
                            Console.WriteLine(indexOfMinElement);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                    }

                    break;

                case "first":
                    int returnCount = int.Parse(parameters[1]);

                    if (returnCount > inputArray.Length || returnCount < 0)
                    {
                        Console.WriteLine("Invalid count");
                        break;
                    }

                    if (parameters[2] == "even")
                    {
                        List<int> firstEven = new List<int>();
                        int count = 0;

                        for (int i = 0; i < inputArray.Length; i++)
                        {
                            if (count >= returnCount)
                            {
                                break;
                            }

                            if (inputArray[i] % 2 == 0)
                            {
                                firstEven.Add(inputArray[i]);
                                count++;
                            }
                        }

                        Console.WriteLine($"[{string.Join(", ", firstEven)}]");
                    }
                    else if (parameters[2] == "odd")
                    {
                        List<int> firstOdd = new List<int>();
                        int count = 0;

                        for (int i = 0; i < inputArray.Length; i++)
                        {
                            if (count >= returnCount)
                            {
                                break;
                            }

                            if (inputArray[i] % 2 != 0)
                            {
                                firstOdd.Add(inputArray[i]);
                                count++;
                            }
                        }

                        Console.WriteLine($"[{string.Join(", ", firstOdd)}]");
                    }

                    break;

                case "last":
                    returnCount = int.Parse(parameters[1]);

                    if (returnCount > inputArray.Length || returnCount < 0)
                    {
                        Console.WriteLine("Invalid count");
                        break;
                    }

                    if (parameters[2] == "even")
                    {
                        List<int> lastEven = new List<int>();
                        int count = 0;

                        for (int i = inputArray.Length - 1; i >= 0; i--)
                        {
                            if (count >= returnCount)
                            {
                                break;
                            }

                            if (inputArray[i] % 2 == 0)
                            {
                                lastEven.Add(inputArray[i]);
                                count++;
                            }
                        }

                        lastEven.Reverse();
                        Console.WriteLine($"[{string.Join(", ", lastEven)}]");
                    }
                    else if (parameters[2] == "odd")
                    {
                        List<int> lastOdd = new List<int>();
                        int count = 0;

                        for (int i = inputArray.Length - 1; i >= 0; i--)
                        {
                            if (count >= returnCount)
                            {
                                break;
                            }

                            if (inputArray[i] % 2 != 0)
                            {
                                lastOdd.Add(inputArray[i]);
                                count++;
                            }
                        }

                        lastOdd.Reverse();
                        Console.WriteLine($"[{string.Join(", ", lastOdd)}]");
                    }

                    break;
            }
        }

        Console.WriteLine($"[{string.Join(", ", inputArray)}]");
    }
}