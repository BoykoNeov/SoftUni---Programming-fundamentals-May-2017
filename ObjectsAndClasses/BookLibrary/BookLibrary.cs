// Task "Book library", for details check ../07. Programming-Fundamentals-Objects-and-Classes-Exercises.docx

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