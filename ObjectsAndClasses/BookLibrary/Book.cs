using System;
using System.Collections.Generic;
// Class containing individual book properties

namespace BookLibrary
{
    class Book
    {
        internal string Title { get; set; }
        internal string Author { get; set; }
        internal string Publisher { get; set; }
        internal decimal Price { get; set; }
        internal DateTime ReleaseDate { get; set; }
        internal string ISBNnumber { get; set; }
    }
}