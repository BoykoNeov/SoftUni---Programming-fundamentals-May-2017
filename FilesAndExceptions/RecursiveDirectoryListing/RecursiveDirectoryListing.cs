// Program to recursively list all directories and files in a given path

namespace RecursiveDirectoryListing
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class RecursiveDirectoryListing
    {
        public static void Main(string[] args)
        {
            DirectoryInfo currentDirectory = new DirectoryInfo(Directory.GetCurrentDirectory());

            if (args != null)
            {
                //   currentDirectory = new  DirectoryInfo(args[0]);
            }



            //var subdirecories = Directory.GetDirectories(@"c:\", "*", SearchOption.TopDirectoryOnly).ToList();
            //Console.WriteLine(string.Join(Environment.NewLine, subdirecories));
            //subdirecories = Directory.GetFiles(@"c:\").ToList();
            //for (int i = 0; i < subdirecories.Count; i++)
            //{
            //    subdirecories[i] = Path.GetFileName(subdirecories[i]);
            //}

            //Console.WriteLine(string.Join(Environment.NewLine, subdirecories));

            var list2 = RecurseList(currentDirectory.Parent.Parent.FullName);
            Console.WriteLine(string.Join(Environment.NewLine, list2.FilesAndDirectoriesList));
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine(string.Join(Environment.NewLine, list2.DirectoriesList));

        }

        public static FilesAndDirectories RecurseList(string inputDir)
        {
            FilesAndDirectories currentObject = new FilesAndDirectories()
            {
                DirectoriesList = new List<string>(),
                FilesAndDirectoriesList = new List<string>()
            };

            var subDirectories = Directory.GetDirectories(inputDir).ToList();

            foreach (string folder in subDirectories)
            {
                currentObject.DirectoriesList.Add(folder);
                currentObject.FilesAndDirectoriesList.Add(folder);
                currentObject.FilesAndDirectoriesList.AddRange(Directory.GetFiles(folder)
                    .Select(Path.GetFileName)
                    .Select(x => "  **  " + x)
                    .ToList());

                FilesAndDirectories tempObject = new FilesAndDirectories();
                tempObject = RecurseList(folder);
                currentObject.DirectoriesList.AddRange(tempObject.DirectoriesList);
                currentObject.FilesAndDirectoriesList.AddRange(tempObject.FilesAndDirectoriesList);
            }


            return currentObject;

            //try
            //{
            //    currentObject.DirectoriesList = Directory.GetDirectories(inputDir).ToList();

            //    for (int i = 0; i < currentObject.DirectoriesList.Count; i++)
            //    {
            //        var directory = currentObject.DirectoriesList[i];
            //        currentObject.DirectoriesList.AddRange(RecurseList(directory).DirectoriesList);
            //        currentObject.FilesAndDirectoriesList = new List<string>(currentObject.DirectoriesList);
            //        List<string> a = Directory.GetFiles(inputDir).Select(Path.GetFileName).ToList();
            //        currentObject.FilesAndDirectoriesList.AddRange(a);

            //    }
            //}
            //catch
            //{
            //    return currentObject;
            //}

//            currentObject.FilesAndDirectoriesList = new List<string>(currentObject.DirectoriesList);

            //List<string> a = Directory.GetFiles(inputDir).Select(Path.GetFileName).ToList();

            //currentObject.FilesAndDirectoriesList.AddRange(a);

            return currentObject;
        }
    }
}
