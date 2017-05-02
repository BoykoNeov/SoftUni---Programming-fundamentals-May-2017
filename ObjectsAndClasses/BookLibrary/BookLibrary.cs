/// <summary>
/// Task "Book library"
/// To model a book library, define classes to hold a book and a library.
/// The library must have a name and a list of books. The books must contain the title, 
/// author, publisher, release date, ISBN-number and price. 
/// Read a  list of books, add them to the library and print the  total sum of prices by
/// author, ordered descending by price and  then by author’s name lexicographically.
/// Books in the input will be in format{title
/// } {author} {publisher} {release date} {ISBN} {price}.
/// </summary>
namespace BookLibrary
{
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

    public class BookLibrary
    {
        public static void Main()
        {
            // Read the number of book inputs from the console & initialize a new "library" with a Book list in it
            int n = int.Parse(Console.ReadLine());
            Library library = new Library()
            {
                Books = new List<Book>()
            };

            // Read individual book information , and also fill newly initialized dictionary with total prices by authors
            var authorPrice = new Dictionary<string, decimal>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                string dateSeparator = "d.M.yyyy";
                Book currentBook = new Book()
                {
                    Title = input[0],
                    Author = input[1],
                    Publisher = input[2],
                    ReleaseDate = DateTime.ParseExact(input[3], dateSeparator, CultureInfo.InvariantCulture),
                    ISBNnumber = input[4],
                    Price = decimal.Parse(input[5])
                };

                library.Books.Add(currentBook);
                if (!authorPrice.ContainsKey(currentBook.Author))
                {
                    authorPrice.Add(currentBook.Author, currentBook.Price);
                }
                else
                {
                    authorPrice[currentBook.Author] += currentBook.Price;
                }
            }

            // Print output as per task definition
            foreach (KeyValuePair<string, decimal> kvp in authorPrice.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value:f2}");
            }
        }
    }
}