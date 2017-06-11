using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// You manage your own pizza restaurant and you are in charge of the orders. Your pizza is made only from ingredients, which have a specific length.
/// On the first line, you will receive an array of strings with the possible ingredients.On the next line, you will receive an integer, which represents the maximum length of the strings, which we will used in the recipe. 
/// Your recipe should not use more than 9 ingredients.If you collect 9 ingredients stop the program and print the result.
/// Input
/// On the first line, you will receive the ingredients
/// On the second line, you will receive the searched length.
/// Output
/// Every time you find a matching ingredient print:
/// Adding { name of the ingredient}.
/// Print the answer in the following format: 
/// Made pizza with total of {count of the ingredients} ingredients.
/// The ingredients are: {1st ingredient}, {2nd ingredient}, … {nth ingredient}.
/// Constraints
/// Only a single whitespace will be used for the separator.
/// The array will be with at most 100 elements long.
/// Each ingredient will be at most 50 characters long.
/// The maximum length will be in the interval [1…50]
/// You will receive at least one valid ingredient
/// </summary>
public class PizzaIngredients
{
    public static void Main()
    {
        string[] ingredients = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.None).ToArray();

        int searchLength = int.Parse(Console.ReadLine());
        int ingredientsCount = 0;

        List<string> totalIngredients = new List<string>();

        for (int i = 0; i < ingredients.Length; i++)
        {
            int currentIngredientLenght = ingredients[i].Length;

            if (currentIngredientLenght == searchLength)
            {
                Console.WriteLine($"Adding {ingredients[i]}.");
                totalIngredients.Add(ingredients[i]);
                ingredientsCount++;

                if (totalIngredients.Count == 10)
                {
                    break;
                }
            }
        }

        Console.WriteLine($"Made pizza with total of {ingredientsCount} ingredients.");
        Console.WriteLine($"The ingredients are: {string.Join(", ", totalIngredients)}.");
    }
}