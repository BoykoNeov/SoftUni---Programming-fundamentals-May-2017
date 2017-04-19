// Class for holding student information

using System.Linq;

namespace AverageGrades
{
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
