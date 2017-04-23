namespace StudentGroups
{
    using System.Collections.Generic;
    using System.Linq;

    public class Group
    {
        public Town GroupTown { get; set; }

        public List<Student> GroupStudents { get; set; }

        public static List<Group> DistributeStudentsIntoGroups(List<Town> inputTownList)
        {
            List<Group> tempGroupsList = new List<Group>();

            foreach (Town City in inputTownList.OrderBy(x => x.TownName))
            {
                Group tempGroup = new Group()
                {
                    GroupTown = City,
                    GroupStudents = new List<Student>()
                };

                int currentStudentNumber = 0;

                foreach (Student registrant in City.TownStudents.OrderBy(x => x.RegistrationDate).ThenBy(x => x.StudentName).ThenBy(x => x.Email))
                {
                    currentStudentNumber++;
                    tempGroup.GroupStudents.Add(registrant);

                    if (currentStudentNumber % City.SeatsCount == 0)
                    {
                        tempGroupsList.Add(tempGroup);
                        tempGroup = new Group()
                        {
                            GroupTown = City,
                            GroupStudents = new List<Student>()
                        };
                    }
                }

                if (currentStudentNumber % City.SeatsCount != 0)
                {
                    tempGroupsList.Add(tempGroup);
                }
            }

            return tempGroupsList;
        }
    }
}