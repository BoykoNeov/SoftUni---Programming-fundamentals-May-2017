//Soft uni debugging excercise from Programing Fundamentals - Methods and debugging

using System;

/// <summary>
/// Debugging Exercise: Instruction Set
/// Write an ** instruction interpreter** that executes an arbitrary number of** instructions.** The program should** parse the
///  instructions, execute** them and** print the result.** The following instruction set should be supported:
/// - **INC &lt; operand1&gt;** – increments the operand by 1
/// - ** DEC &lt;operand1&gt;** – decrements the operand by 1
/// + ** ADD &lt;operand1&gt; &lt;operand2&gt;** – performs addition on the two operands
/// - ** MLA &lt;operand1&gt; &lt;operand2&gt;**– performs multiplication on the two operands
/// - ** END** – end of input
/// The result of each instruction should be printed on a separate line on the console.
/// - The operands will be valid integers in the range [−2 147 483 648 … 2 147 483 647].
/// </summary>
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