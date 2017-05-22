/// <summary>
/// You are given number of files with their full file paths and file sizes.
/// You need to print all file names with a given extension that are present in a given root directory sorted by their file size in descending order.
/// If two files have same size, order them by alphabetical order. 
/// If a file name(file name + extension) appears more than once in a given root, save only its latest value.
/// If a file name appears in more than one root, they are treated as different files.
/// If there aren't any files that correspond to the query, print "No".
/// Input / Constrains:
/// On the first line of input you will get N the number of files to be read from the console
/// On the next N lines, you receive the actual files in the format "root\folder\filename.extension;filesize"
/// There may be more than one folder e.g.files can be deeply nested
/// On the last line you receive a query string in format "{extension} in {root}".
/// You need to print all files with the given extension that are in present in the given root
/// Output:
/// You need to print all files sorted by their size in descending order. 
/// If two files have the same size, order them by alphabetical order.
/// Files should be printed in the given format "filename.extension - filesize KB" 
/// If there aren't any movies that correspond to the query, print "No".
/// </summary>
namespace Files
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Files
    {
        public static void Main()
        {
            int inputsCount = int.Parse(Console.ReadLine());
            List<string[]> inputLines = new List<string[]>();

            for (int i = 0; i < inputsCount; i++)
            {
                string[] filesInput = Console.ReadLine().Split(new char[] { '\\', ';' }, StringSplitOptions.RemoveEmptyEntries);
                inputLines.Add(filesInput);
            }

            string[] searchInput = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string searchRoot = searchInput[2];
            string searchExtension = searchInput[0];

            Dictionary<string, long> files = new Dictionary<string, long>();

            foreach (string[] inputLine in inputLines)
            {
                string currentRoot = inputLine[0];
                if (currentRoot != searchRoot)
                {
                    continue;
                }

                string[] getExtension = inputLine[inputLine.Length - 2].Split(new char[] { '.' });

                string fileExtention = getExtension[getExtension.Length-1];
                if (fileExtention != searchExtension)
                {
                    continue;
                }

                long fileSize = long.Parse(inputLine[inputLine.Length - 1]);
                string fileName = inputLine[inputLine.Length - 2];

                files[fileName] = fileSize;
            }

            if (files.Count == 0)
            {
                Console.WriteLine("No");
                return;
            }

            foreach (var kvp in files.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value} KB");
            }
        }
    }
}