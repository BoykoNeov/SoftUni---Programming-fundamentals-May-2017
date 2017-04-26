using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace RecursiveDirectoryListing
{
    public class RecursiveDirectoryListing
    {
        public static void Main(string args)
        {
            DirectoryInfo currentDirectory = new DirectoryInfo(Directory.GetCurrentDirectory());
            
            if (args != null)
            {
                currentDirectory = new  DirectoryInfo(args);
            }



            var subdirecories = Directory.GetDirectories(currentDirectory.FullName).ToList();


        }

        public static List<string> RecurseList(List<string> inputDir)
        {
            return inputDir;
        }
    }
}
