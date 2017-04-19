// Class containing individual book properties

namespace BookLibraryModification
{
    using System;

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