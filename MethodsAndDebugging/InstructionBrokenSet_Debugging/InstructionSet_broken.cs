//Soft uni debugging excercise from Programing Fundamentals - Methods and debugging

using System;

public class InstructionSet_broken
{
    public static void Main()
    {
        string opCode = string.Empty;
        long result = 0;

        while (opCode != "END")
        {
            opCode = Console.ReadLine();
            string[] codeArgs = opCode.Split(' ');

            switch (codeArgs[0])
            {
                case "INC":
                    {
                        long operandOne = int.Parse(codeArgs[1]);
                        result = ++operandOne;
                        break;
                    }
                case "DEC":
                    {
                        long operandOne = int.Parse(codeArgs[1]);
                        result = --operandOne;
                        break;
                    }
                case "ADD":
                    {
                        long operandOne = int.Parse(codeArgs[1]);
                        long operandTwo = int.Parse(codeArgs[2]);
                        result = operandOne + operandTwo;
                        break;
                    }
                case "MLA":
                    {
                        long operandOne = int.Parse(codeArgs[1]);
                        long operandTwo = int.Parse(codeArgs[2]);
                        result = (operandOne * operandTwo);
                        break;
                    }
                case "END":
                    break;
            }
            if (codeArgs[0] != "END")
            {
                Console.WriteLine(result);
            }

        }
    }
}