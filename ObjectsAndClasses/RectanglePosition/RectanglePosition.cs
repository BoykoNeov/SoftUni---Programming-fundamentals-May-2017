/// <summary>
/// Write a program to read two rectangles {left, top, width, height} and print whether the first is inside the second.
/// </summary>
namespace RectanglePosition
{
    using System;

    public class RectanglePosition
    {
        public static void Main()
        {
            Rectangle a = Rectangle.ReadRectangle(Console.ReadLine());
            Rectangle b = Rectangle.ReadRectangle(Console.ReadLine());

            if (Rectangle.IsInside(a , b))
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
        }
    }
}
