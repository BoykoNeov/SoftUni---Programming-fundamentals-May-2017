/// <summary>
/// Write a program, which receives image metadata as input and prints information about the image, such as 
/// its filename, date taken, size, resolution and aspect ratio. Also, calculate the orientation of the image. The 3 orientations are: portrait, landscape and square.
/// Input
/// First line – the photo’s number – an integer in the range[0…9999]
/// Second, third, fourth line – the day, month and year the photo was taken – 
/// integers forming valid dates in the range[01 / 01 / 1990…31 / 12 / 2020]
/// Fifth, sixth line – the hours and minutes the photo was taken – integers in the range[0…23]
/// Seventh line – the photo’s size in bytes – integer in the range[0…999000000]
/// Eighth, ninth line – the photo’s resolution(width and height) in pixels – integers in the range[1…10000]
/// Output
/// The name should be printed in the format “DSC_xxxx.jpg”.
/// The date and time taken should be printed in the format “dd/mm/yyyy hh:mm”.
/// The size should be printed in standard human-readable format(i.e. 950 bytes = 950B, 500000 bytes = 500KB, 1500000 bytes = 1.5MB).
/// The resolution should be printed in the following format: “{width}x{height}”.
/// The orientation can be one of three valid values: portrait, landscape and square
/// </summary>
using System;
public class PhotoGallery
    {
        static void Main()
        {
            int photoNumber = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            double photoSize = long.Parse(Console.ReadLine());
            int photoWidth = int.Parse(Console.ReadLine());
            int photoHeight = int.Parse(Console.ReadLine());

            Console.WriteLine("Name: DSC_{0:d4}.jpg", photoNumber);
            Console.WriteLine("Date Taken: {0:d2}/{1:d2}/{2} {3:d2}:{4:d2}",
                day, month, year, hour, minutes);
            if (photoSize < 1000)
            {
                Console.WriteLine("Size: {0}B", photoSize);
            }
            else if (photoSize < 1000000)
            {
                photoSize /= 1000;
                Console.WriteLine("Size: {0}KB", photoSize);
            }
            else
            {
                photoSize /= 1000000;
                Console.WriteLine("Size: {0}MB", photoSize);
            }

            if (photoWidth > photoHeight)
            {
                Console.WriteLine($"Resolution: {photoWidth}x{photoHeight} (landscape)");
            }
            else if (photoWidth < photoHeight)
            {
                Console.WriteLine($"Resolution: {photoWidth}x{photoHeight} (portrait)");
            }
            else
            {
                Console.WriteLine($"Resolution: {photoWidth}x{photoHeight} (square)");
            }
        }
    }