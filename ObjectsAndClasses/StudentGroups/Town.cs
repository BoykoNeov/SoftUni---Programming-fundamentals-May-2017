namespace StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

   public class Town
    {
        public string TownName { get; set; }

        public int SeatsCount { get; set; }

        public List<Student> TownStudents { get; set; }
    }
}
