// Class for holding student information

namespace AverageGrades
{
    using System.Linq;

    public class Students
    {
        public string Name { get; set; }

        public double[] Grades { get; set; }

        public double Average
        {
            get
            {
                return Grades.Average();
            }
        }
    }
}
