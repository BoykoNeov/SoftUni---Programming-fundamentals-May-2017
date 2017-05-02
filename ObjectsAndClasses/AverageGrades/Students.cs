namespace AverageGrades
{
    using System.Linq;

    /// <summary>
    /// Class for holding student information
    /// </summary>
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
