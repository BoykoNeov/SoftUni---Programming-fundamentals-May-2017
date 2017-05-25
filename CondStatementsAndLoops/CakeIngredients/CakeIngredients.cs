/// <summary>
/// Write a baking program, which takes as an input ingredients and writes a message when the ingredient is in the system. For every given ingredient, you should write: “Adding ingredient {name of the ingredient}.”. When you receive the command “Bake!” from the console you should stop the program and write “Preparing cake with {number of given ingredients} ingredients.”. 
/// Input
/// You will receive ingredients until the command “Bake!” is given.
/// Output
/// For every given ingredient write on a new line the message: “Adding ingredient { name of the ingredient }.”. At the end print the message: “Preparing cake with {number of given ingredients} ingredients.”.
/// Constraints
/// You will receive maximum 20 ingredients.
/// Every ingredient will be between 1 and 50 characters
/// </summary>
using System;
public class CakeIngredients
{
    public static void Main()
    {
        string input = string.Empty;
        int ingredientsCounter = 0;

        while ((input = Console.ReadLine()) != "Bake!")
        {
            Console.WriteLine($"Adding ingredient {input}.");
            ingredientsCounter++;
        }

        Console.WriteLine($"Preparing cake with {ingredientsCounter} ingredients.");
    }
}