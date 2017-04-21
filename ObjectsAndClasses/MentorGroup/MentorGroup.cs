// Task "Mentor Group", for details check ../07. Programming-Fundamentals-Objects-and-Classes-Exercises.docx

namespace MentorGroup
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;

    public class MentorGroup
    {
        public static void Main()
        {
            string userInput = string.Empty;
            var users = new Dictionary<string, Student>();
            string dateTimeSeparator = "dd/MM/yyyy";

            while ((userInput = Console.ReadLine()) != "end of dates")
            {
                string[] inputs = userInput.Split(new char[] { ' ', ',' }, StringSplitOptions
                                                 .RemoveEmptyEntries)
                                                 .ToArray();

                if (!users.ContainsKey(inputs[0]))
                {
                    users[inputs[0]] = new Student()
                    {
                        AttendingDates = new List<DateTime>(),
                        Comments = new List<string>(),
                        Name = inputs[0]
                    };
                }

                for (int i = 1; i < inputs.Length; i++)
                {
                    users[inputs[0]].AttendingDates.Add(DateTime
                                            .ParseExact(inputs[i], dateTimeSeparator, CultureInfo
                                            .InvariantCulture));
                }
            }

            while ((userInput = Console.ReadLine()) != "end of comments")
            {
                string[] inputs = userInput.Split(new char[] { '-' }).ToArray();
                if (users.ContainsKey(inputs[0]))
                {
                    users[inputs[0]].Comments.Add(inputs[1]);
                }
            }

            foreach (KeyValuePair<string,Student> student in users.OrderBy(x => x.Key))
            {
                student.Value.AttendingDates.Sort();

                StringBuilder studentOutput = new StringBuilder();
                studentOutput.AppendFormat($"{student.Key}{Environment.NewLine}");
                studentOutput.AppendFormat($"Comments:{Environment.NewLine}");
                
                foreach (string comment in student.Value.Comments)
                {
                    studentOutput.AppendFormat($"- {comment}{Environment.NewLine}");
                }

                studentOutput.AppendFormat($"Dates attended:{Environment.NewLine}");

                foreach (DateTime data in student.Value.AttendingDates)
                {
                    studentOutput.AppendFormat($"-- {data.ToString(dateTimeSeparator)}{Environment.NewLine}");
                }
                Console.Write(studentOutput.ToString());
            }
        }
    }
}