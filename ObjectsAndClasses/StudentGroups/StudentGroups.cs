/// <summary>
/// At the Software University we often organize programming courses for beginners in different towns.
/// We usually run a registration form and after the registration finishes, we distribute the students
/// into study groups. Groups have different sizes in each town.
/// You are given a report holding the registrations for each town and the lab capacity (seats count)
/// for each town.It comes in the following format:
///- Town name => X seats (where X is the capacity of the training lab in this town).
/// Student name | student email | registration date (in format day-month-year). The month name is given as 3 letters in English, e.g. “May”, “Aug” or “Nov”.
///- The next student come after the first, etc.
///- Then the next town and its students come, etc.
///- The input ends by a line holding“End”.
/// Your task is to create and  print the study groups for each town as follows:
///- For each town create and print one or several study groups (depends of the number or registered students and the capacity of the lab in this town).
///- For each town order the students by registration date (ascending), then by name (ascending) then by email (ascending), then fill them into groups. If the students are less or equal to the lab capacity, create only one group. When the students are more than the lab capacity, distribute them in multiple groups.
///- Print all groups ordered by town (ascending) in the following format:
///- Created G groups and T towns:
///- Town1 => email1, email2, …
///- Town1 => email1, email2, …
///- …
///- Town2 => email1, email2, …
///- …
/// </summary>
namespace StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentGroups
    {
        public static void Main()
        {
            List<Town> townsAndStudentsList = new List<Town>();
            townsAndStudentsList = Town.ReadTownsAndStudents();

            List<Group> groupsList = new List<Group>();
            groupsList = Group.DistributeStudentsIntoGroups(townsAndStudentsList);

            int numberOfGroups = groupsList.Count;
            int numberOfDistinctTowns = groupsList.GroupBy(x => x.GroupTown).Count();
            Console.WriteLine($"Created {numberOfGroups} groups in {numberOfDistinctTowns} towns:");

            foreach (Group association in groupsList.OrderBy(x => x.GroupTown.TownName))
            {
                var studentsEmailsOutput = string.Join(", ", association.GroupStudents.Select(x => x.Email));
                Console.WriteLine($"{association.GroupTown.TownName} => {studentsEmailsOutput}");
            }
        }
    }
}