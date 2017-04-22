namespace StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StudentGroups
    {
        public static void Main()
        {
            List<Town> townsAndStudentsList = new List<Town>();
            townsAndStudentsList = Town.ReadTownsAndStudents();

            List<Group> groupsList = new List<Group>();
            groupsList = Group.DistributeStudentsIntoGroups(townsAndStudentsList);
        }



    }
}
