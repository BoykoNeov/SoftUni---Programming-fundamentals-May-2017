/// <summary>
/// Write a program that reads two dates in format dd-MM-yyyy and 
/// prints the number of working days between these two dates inclusive.
/// </summary>
namespace CountWorkingDays
{
    using System;
    using System.Globalization;

    public class CountWorkingDays
    {
        public static void Main()
        {
            DateTime[] holidays = new DateTime[11];
            string dateTimeFormat = "d-M-yyyy";
            holidays[0] = DateTime.ParseExact("1-1-2017", dateTimeFormat, CultureInfo.InvariantCulture);
            holidays[1] = DateTime.ParseExact("1-5-2017", dateTimeFormat, CultureInfo.InvariantCulture);
            holidays[2] = DateTime.ParseExact("6-5-2017", dateTimeFormat, CultureInfo.InvariantCulture);
            holidays[3] = DateTime.ParseExact("24-5-2017", dateTimeFormat, CultureInfo.InvariantCulture);
            holidays[4] = DateTime.ParseExact("6-9-2017", dateTimeFormat, CultureInfo.InvariantCulture);
            holidays[5] = DateTime.ParseExact("22-9-2017", dateTimeFormat, CultureInfo.InvariantCulture);
            holidays[6] = DateTime.ParseExact("01-11-2017", dateTimeFormat, CultureInfo.InvariantCulture);
            holidays[7] = DateTime.ParseExact("3-3-2017", dateTimeFormat, CultureInfo.InvariantCulture);
            holidays[8] = DateTime.ParseExact("24-12-2017", dateTimeFormat, CultureInfo.InvariantCulture);
            holidays[9] = DateTime.ParseExact("25-12-2017", dateTimeFormat, CultureInfo.InvariantCulture);
            holidays[10] = DateTime.ParseExact("26-12-2017", dateTimeFormat, CultureInfo.InvariantCulture);

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
                for (int i = 0; i < holidays.Length; i++)
                {
                    if (firstDate.Day == holidays[i].Day && firstDate.Month == holidays[i].Month)
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