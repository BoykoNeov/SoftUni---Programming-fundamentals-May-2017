using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace BookLibrary
{
    public class BookLibrary
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Library library = new Library()
            {
                Books = new List<Book>()
            };
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                string dateSeparator = "d.M.yyyy";
                library.Books.Add(new Book()
                {
                    Title = input[0],
                    Author = input[1],
                    Publisher = input[2],
                    ReleaseDate = DateTime.ParseExact(input[3], dateSeparator, CultureInfo.InvariantCulture),
                    ISBNnumber = input[4],
                    Price = decimal.Parse(input[5])
                });
            }

            var authorPrice = new Dictionary<string, decimal>();
            foreach (Book currentBook in library.Books)
            {
                if (!authorPrice.ContainsKey(currentBook.Author))
                {
                    authorPrice.Add(currentBook.Author, currentBook.Price);
                }
                else
                {
                    authorPrice[currentBook.Author] += currentBook.Price;
                }
            }

            foreach (KeyValuePair<string, decimal> kvp in authorPrice.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value:f2}");
            }
        }
    }
}
