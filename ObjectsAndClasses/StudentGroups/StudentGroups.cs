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