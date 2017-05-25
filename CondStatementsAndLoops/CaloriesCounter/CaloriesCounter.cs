/// <summary>
/// You have to write a program, which counts the calories, which can be found in your pizza recipe. In your recipe, there are only four ingredients – cheese, tomato sauce, salami and pepper. Each ingredient contains a fixed amount of calories: 
/// Cheese – 500 calories
/// Tomato sauce – 150 calories
/// Salami – 600 calories
/// Pepper – 50 calories
/// If you receive one of these ingredients more than once, you should add the calories to the total amount again.You should not process any other ingredients. Ingredients are case-insensitive.
/// Input
/// On the next n lines, you will receive different ingredients.Add the calories only from the ones, which are in your recipe. 
/// Output
/// Print the answer in the following format:
/// Total calories: { totalCaloriesAmount}
/// Constraints
/// You will receive maximum 20 ingredients.
/// Every ingredient will be between 1 and 50 characters.
/// </summary>
using System;
public class CaloriesCounter
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int totalCalories = 0;

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine().ToLower();
            switch (input)
            {
                case "cheese":
                    {
                        totalCalories += 500;
                        break;
                    }

                case "tomato sauce":
                    {
                        totalCalories += 150;
                        break;
                    }

                case "salami":
                    {
                        totalCalories += 600;
                        break;
                    }

                case "pepper":
                    {
                        totalCalories += 50;
                        break;
                    }
            }
        }

        Console.WriteLine($"Total calories: {totalCalories}");
    }
}