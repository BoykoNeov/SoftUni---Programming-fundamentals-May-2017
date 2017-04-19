using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
//To model a book library, define classes to hold a book and a library.The library must have a name and a list of books.The books must contain the title, author, publisher, release date, ISBN-number and price.
//Read a list of books, add them to the library and print the total sum of prices by author, ordered descending by price and then by author’s name lexicographically.
//Books in the input will be in format {title} {author} {publisher} {release date} {ISBN} {price}.
