namespace BookLibrary
{
    using System;
    /// <summary>
    /// Class containing individual book properties
    /// </summary>
    public class Book
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public string Publisher { get; set; }

        public decimal Price { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string ISBNnumber { get; set; }
    }
}