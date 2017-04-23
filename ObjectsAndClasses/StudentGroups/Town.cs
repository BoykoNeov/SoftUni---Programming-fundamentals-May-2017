namespace StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;

   public class Town
    {
        public string TownName { get; set; }

        public int SeatsCount { get; set; }

        public List<Student> TownStudents { get; set; }

        public static List<Town> ReadTownsAndStudents()
        {
            string consoleInput = string.Empty;
            List<Town> tempTownsAndStudentsList = new List<Town>();
            Town currentTown = null;

            while ((consoleInput = Console.ReadLine()) != "End")
            {
                if (consoleInput.Contains("=>"))
                {
                    if (currentTown != null)
                    {
                        tempTownsAndStudentsList.Add(currentTown);
                        currentTown = new Town()
                        {
                            TownStudents = new List<Student>()
                        };
                    }
                    else
                    {
                        currentTown = new Town()
                        {
                            TownStudents = new List<Student>()
                        };
                    }

                    string[] townConsoleInput = consoleInput.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < townConsoleInput.Length; i++)
                    {
                        if (townConsoleInput[i] == "=>")
                        {
                            currentTown.SeatsCount = int.Parse(townConsoleInput[i + 1]);
                            break;
                        }
                        currentTown.TownName += townConsoleInput[i] + " ";

                    }

                    currentTown.TownName = currentTown.TownName.TrimEnd(' ');
                }
                else
                {
                    string[] studentConsoleInput = consoleInput.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                    Student tempStudent = new Student()
                    {
                        StudentName = studentConsoleInput[0].Trim(' '),
                        Email = studentConsoleInput[1].Trim(' '),
                        RegistrationDate = DateTime.ParseExact(studentConsoleInput[2].Trim(' '), "d-MMM-yyyy", CultureInfo.InvariantCulture)
                    };

                    currentTown.TownStudents.Add(tempStudent);
                }
            }

            tempTownsAndStudentsList.Add(currentTown);
            return tempTownsAndStudentsList;
        }
    }
}