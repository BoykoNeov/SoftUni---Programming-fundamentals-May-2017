/// <summary>
/// Task "Average Grades"
/// Define a class Student, which holds the following information about students:
/// name, list of grades 
/// and average grade (calculated property, read-only). A single grade will be 
/// in range [2…6], e.g. 3.25 or 5.50.
/// Read a  list of students and print the students that have 
/// average grade ≥ 5.00 ordered  by
/// name (ascending), then by  average grade (descending).
/// Print the student name and the calculated average grade.
/// </summary>
namespace AverageGrades
{
    using System;
    using System.Linq;

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
