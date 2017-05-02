namespace BookLibrary
{
    using System.Collections.Generic;
    /// <summary>
    /// Class containing library properties and information
    /// </summary>
    public class Library
    {
        public string Name { get; set; }

        public List<Book> Books { get; set; }
    }
}
