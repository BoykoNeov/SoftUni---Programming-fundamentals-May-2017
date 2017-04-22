namespace StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Group
    {
        public Town GroupTown { get; set; }

        public List<Student> GroupStudents { get; set; }
    }
}
