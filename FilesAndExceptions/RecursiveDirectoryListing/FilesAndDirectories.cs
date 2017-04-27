// Class for holding results of the recursive function

namespace RecursiveDirectoryListing
{
    using System.Collections.Generic;

    public class FilesAndDirectories
    {
        public List<string> DirectoriesList { get; set; }
        public List<string> FilesAndDirectoriesList { get; set; }
    }
}