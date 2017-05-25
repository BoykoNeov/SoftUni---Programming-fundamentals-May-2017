/// <summary>
/// Choose A Drink task
/// Write a program, which receives a profession (as a string) and chooses the perfect drink for the person. The possible combinations are: 
/// “Water” – for “Athlete”
/// “Coffee” – for “Businessman” or “Businesswoman”
/// “Beer” – for “SoftUni Student”
/// “Tea” – for all other professions.
/// </summary>
    using System;
    public class ChoseADrink
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            switch (input)
            {
                case "Athlete":
                    Console.WriteLine("Water");
                    break;

                case "Businessman":
                    Console.WriteLine("Coffee");
                    break;

                case "Businesswoman":
                    Console.WriteLine("Coffee");
                    break;

                case "SoftUni Student":
                    Console.WriteLine("Beer");
                    break;

                default:
                    Console.WriteLine("Tea");
                    break;
            }
        }
    }