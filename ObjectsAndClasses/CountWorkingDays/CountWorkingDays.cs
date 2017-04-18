// Write a program that reads two dates in format dd-MM-yyyy and 
// prints the number of working days between these two dates inclusive. 

using System;
using System.Globalization;

namespace CountWorkingDays
{
    public class CountWorkingDays
    {
        public static void Main()
        {
            DateTime[] Holidays = new DateTime[11];
            string dateTimeFormat = "d-M-yyyy";
            Holidays[0] = DateTime.ParseExact("1-1-2017", dateTimeFormat, CultureInfo.InvariantCulture);
            Holidays[1] = DateTime.ParseExact("1-5-2017", dateTimeFormat, CultureInfo.InvariantCulture);
            Holidays[2] = DateTime.ParseExact("6-5-2017", dateTimeFormat, CultureInfo.InvariantCulture);
            Holidays[3] = DateTime.ParseExact("24-5-2017", dateTimeFormat, CultureInfo.InvariantCulture);
            Holidays[4] = DateTime.ParseExact("6-9-2017", dateTimeFormat, CultureInfo.InvariantCulture);
            Holidays[5] = DateTime.ParseExact("22-9-2017", dateTimeFormat, CultureInfo.InvariantCulture);
            Holidays[6] = DateTime.ParseExact("01-11-2017", dateTimeFormat, CultureInfo.InvariantCulture);
            Holidays[7] = DateTime.ParseExact("3-3-2017", dateTimeFormat, CultureInfo.InvariantCulture);
            Holidays[8] = DateTime.ParseExact("24-12-2017", dateTimeFormat, CultureInfo.InvariantCulture);
            Holidays[9] = DateTime.ParseExact("25-12-2017", dateTimeFormat, CultureInfo.InvariantCulture);
            Holidays[10] = DateTime.ParseExact("26-12-2017", dateTimeFormat, CultureInfo.InvariantCulture);

            DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), dateTimeFormat, CultureInfo.InvariantCulture);
            DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), dateTimeFormat, CultureInfo.InvariantCulture);
            int workingDaysCount = 0;

            for (; firstDate <= secondDate; firstDate = firstDate.AddDays(1))
            {
                bool isWorkingDay = true;

                if (firstDate.DayOfWeek == DayOfWeek.Saturday || firstDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    continue;
                }

                // Compare the current date to holiday list
                for (int i = 0; i < Holidays.Length; i++)
                {

                    if (firstDate.Day == Holidays[i].Day && firstDate.Month == Holidays[i].Month)
                    {
                        isWorkingDay = false;
                        break;
                    }
                }

                if (isWorkingDay)
                {
                    workingDaysCount++;
                }
            }

            Console.WriteLine(workingDaysCount);
        }
    }
}