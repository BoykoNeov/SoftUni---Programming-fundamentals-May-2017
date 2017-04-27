/// <summary>
/// // Program to recursively list all directories and files in a given path
/// </summary>
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

            try
            {
                currentDirectory = new DirectoryInfo(args[0]);
            }
            catch
            {
            }

            string prefix = " ";
            var list2 = RecurseList(currentDirectory.Parent.Parent.FullName, prefix);
            Console.WriteLine(string.Join(Environment.NewLine, list2.FilesAndDirectoriesList));
        }

        public static FilesAndDirectories RecurseList(string inputDir, string prefix)
        {
            FilesAndDirectories currentObject = new FilesAndDirectories()
            {
                DirectoriesList = new List<string>(),
                FilesAndDirectoriesList = new List<string>()
            };

            try
            {
                var subDirectories = Directory.GetDirectories(inputDir).ToList();

                foreach (string folder in subDirectories)
                {
                    currentObject.DirectoriesList.Add(folder);
                    currentObject.FilesAndDirectoriesList.Add($"{prefix}{prefix.Length} {folder}");

                    currentObject.FilesAndDirectoriesList.AddRange(Directory.GetFiles(folder)
                        .Select(x =>
                        {
                            string tempName = Path.GetFileName(x);
                            var tempSize = new FileInfo(x).Length;
                            return $"{prefix + "   =="} {tempName}  {tempSize / 1000000d:f2}MB";
                        })
                        .ToList());

                    FilesAndDirectories tempObject = new FilesAndDirectories();
                    tempObject = RecurseList(folder, prefix + " ");
                    currentObject.DirectoriesList.AddRange(tempObject.DirectoriesList);
                    currentObject.FilesAndDirectoriesList.AddRange(tempObject.FilesAndDirectoriesList);
                }
            }
            catch
            {
            }

            return currentObject;
        }
    }
}