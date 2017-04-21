// Class for holding student info

namespace MentorGroup
{
    using System;
    using System.Collections.Generic;

    public class Student
    {
        public string Name { get; set; }

        public List<string> Comments { get; set; }

        public List<DateTime> AttendingDates { get; set; }
    }
}