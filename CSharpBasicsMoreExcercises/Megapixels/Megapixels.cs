/// <summary>
/// Write a program, which, given an image resolution (width and height), calculates its megapixels. Megapixels (short for millions of pixels) are calculated by counting all the image pixels, then dividing the result by 1000000. 
/// The megapixels must always be rounded to the first digit after the decimal point(i.e. 0.786 MP  0.8MP).
/// Input
/// First Line – the width of the image – integer in range[1…20000]
/// Second Line – the height of the image – integer in range[1…20000]
/// </summary>
using System;

public class Megapixels
{
    public static void Main()
    {
        double width = int.Parse(Console.ReadLine());
        double height = int.Parse(Console.ReadLine());

        double megapixels = Math.Round((width * height) / 1000000, 1);
        Console.WriteLine($"{width}x{height} => {megapixels}MP");
    }
}