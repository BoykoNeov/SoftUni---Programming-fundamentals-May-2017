// Class for holding the properties of a rectangle and associated methods
// for getting rectangle properties from a string and calculating if a rectangle is inside another

using System;
using System.Linq;

namespace RectanglePosition
{
    public class Rectangle
    {
        double Left { get; set; }
        double Top { get; set; }
        double Width { get; set; }
        double Height { get; set; }

        double Right
        {
            get
            {
                return Left + Width;
            }
        }

        double Bottom
        {
            get
            {
                return Top + Height;
            }
        }

        public static Rectangle ReadRectangle(string input)
        {
            Rectangle output = new Rectangle();
            double[] inputParams = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            output.Left = inputParams[0];
            output.Top = inputParams[1];
            output.Width = inputParams[2];
            output.Height = inputParams[3];
            return output;
        }

        public static bool IsInside(Rectangle a, Rectangle b)
        {
            if ( a.Left >= b.Left &&
                 a.Right <= b.Right &&
                 a.Top <= b.Top &&
                 a.Bottom <= b.Bottom)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
