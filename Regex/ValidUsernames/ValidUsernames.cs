/// <summary>
/// You are part of the back-end development team of the next Facebook. You are given a line of usernames,
/// between one of the following symbols: space, “/”, “\”, “(“, “)”. First you have to export all valid usernames.
/// A valid username starts with a letter and can contain only letters, digits and “_”. It cannot be less than 3 or more 
/// than 25 symbols long. Your task is to sum the length of every 2 consecutive valid usernames and print on the console the 2 valid 
/// usernames with biggest sum of their lengths, each on a separate line. 
/// Input:
/// The input comes from the console.One line will hold all the data.It will hold usernames, divided by the symbols: space, “/”, “\”, “(“, “)”. 
/// The input data will always be valid and in the format described.There is no need to check it explicitly.
/// Output
/// Print at the console the 2 consecutive valid usernames with the biggest sum of their lengths each on a separate line.
/// If there are 2 or more couples of usernames with the same sum of their lengths, print he left most.
/// </summary>
namespace ValidUsernames
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ValidUsernames
    {
        public static void Main()
        {
            string pattern = @"\b[^\(\) ,\\\/\n\r_][^\(\) ,\\\/\n\r]{2,24}\b";
        }
    }
}
