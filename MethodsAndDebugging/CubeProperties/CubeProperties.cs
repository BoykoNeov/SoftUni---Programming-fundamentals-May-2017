using System;
/// <summary>
/// Write a program that can calculate the length of the face diagonals, space diagonals, volume and surface area
/// of a cube (http://www.mathopenref.com/cube.html) by a given side.
/// On the first line you will get the side of the cube.
/// On the second line is given the parameter (face, space, volume or area).
/// Output should be rounded to the second digit after the decimal point
/// </summary>
public class CubeProperties
{
    public static void Main()
    {
        double cubeSide = double.Parse(Console.ReadLine());
        string cubeParameter = Console.ReadLine();

        switch (cubeParameter)
        {
            case "face":
                double faceDiagonal = Math.Sqrt(2 * (cubeSide * cubeSide));
                Print(faceDiagonal);
                break;

            case "space":
                double spaceDiagonal = Math.Sqrt(3 * (cubeSide * cubeSide));
                Print(spaceDiagonal);
                break;

            case "volume":
                double volume = cubeSide * cubeSide * cubeSide;
                Print(volume);
                break;

            case "area":
                double area = 6 * (cubeSide * cubeSide);
                Print(area);
                break;
        }
    }

    internal static void Print(double result)
    {
        Console.WriteLine($"{result:f2}");
    }
}