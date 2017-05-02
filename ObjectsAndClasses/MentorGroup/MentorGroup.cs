/// <summary>
/// Task "Mentor Group"
/// You are mentor of a group. You have done your job well and now you have to generate a report
/// about your group's activity. You will be given usernames and dates **("dd/MM/yyyy")**, dates
/// **(if any)** are separated with comma, until you receive command **"end of dates"**. After
/// that you will receive user and some comment (separated with dash). You can add comment for every 
/// user who is **in** your group (if **not** ignore the line). Adding comment/date to same user more
/// than once should **append** to that user the comment/date. Upon receiving command **"end of comments"** 
/// you should generate report in format:
/// \{user} -
/// Comments:
/// \- \{firstComment} …
/// Dates attended:
/// -- \{firstDate}
/// -- \{secondDate}
/// Users should be printed ordered by name(ascending). For every user dates should be sorted again in ascending order.Input will be valid for in the format described - you should **not check** it explicitly!
/// </summary>
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