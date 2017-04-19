// Task "Book library Modification", for details
// check ../07. Programming-Fundamentals-Objects-and-Classes-Exercises.docx

namespace BookLibraryModification
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class BookLibraryModification
    {
        public static void Main()
        {
            // Read the number of book inputs from the console & initialize a new "library" with a Book list in it
            int n = int.Parse(Console.ReadLine());
            Library library = new Library()
            {
                Books = new List<Book>()
            };

            // Read individual book information
            string dateSeparator = "d.M.yyyy";
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
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

            DateTime afterDate = DateTime.ParseExact(Console.ReadLine(), dateSeparator, CultureInfo.InvariantCulture);

            foreach (var kniga in library.Books.Where(x => x.ReleaseDate > afterDate)
                .OrderBy(x => x.ReleaseDate)
                .ThenBy(x => x.Title))
            {
                Console.WriteLine($"{kniga.Title} -> {kniga.ReleaseDate.ToString("dd.MM.yyyy")}");
            }
        }
    }
}