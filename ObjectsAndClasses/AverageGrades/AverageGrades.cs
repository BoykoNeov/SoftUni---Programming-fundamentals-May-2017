// Task "Average Grades", for details check ../07. Programming-Fundamentals-Objects-and-Classes-Exercises.docx

using System;
using System.Linq;

namespace AverageGrades
{
    public class AverageGrades
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Students[] studentsList = new Students[n];
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                studentsList[i] = new Students()
                {
                    Name = input[0],
                    Grades = input.Skip(1).Select(double.Parse).ToArray()
                };
            }

            foreach (Students student in studentsList.Where(x => x.Average >= 5).OrderBy(x => x.Name).ThenByDescending(x => x.Average))
            {
                Console.WriteLine($"{student.Name} -> {student.Average:f2}");
            }
        }
    }
}
