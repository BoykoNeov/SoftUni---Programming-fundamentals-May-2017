namespace RecursiveDirectoryListing
{
    using System.Collections.Generic;
    /// <summary>
    ///  Class for holding results of the recursive function
    /// </summary>
    public class FilesAndDirectories
    {
        public List<string> DirectoriesList { get; set; }
        public List<string> FilesAndDirectoriesList { get; set; }
    }
}