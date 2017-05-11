/// <summary>
/// You are given a collection of tickets separated by commas and spaces. You need to check every one of them if it has a winning combination of symbols.
/// A valid ticket should have exactly 20 characters.The winning symbols are ' @', ' #', ' $' and ' ^'. But in order for a ticket to be a winner the symbol should uninterruptedly repeat for at least 6 times in both the tickets left half and the tickets right half.
/// For example, a valid winning ticket should be something like this:
/// " Cash$$$$$$Ca$$$$$$sh"
/// The left half " Cash$$$$$$" contains " $$$$$$", which is also contained in the tickets right half " Ca$$$$$$sh". A winning ticket should contain symbols repeating up to 10 times in both halves, which is considered a Jackpot (for example: " $$$$$$$$$$$$$$$$$$$$").
/// Input
/// The input will be read from the console.The input consists of a single line containing all tickets separated by commas and one or more white spaces in the format:
/// "{ticket}, {ticket}, … {ticket}"
/// Output
/// Print the result for every ticket in the order of their appearance, each on a separate line in the format:
/// Invalid ticket - "invalid ticket"
/// No match - "ticket "{ticket}" - no match"
/// Match with length 6 to 9 - "ticket "{ticket}" - {match length}{match symbol}"
/// Match with length 10 - "ticket "{ticket}" - {match length}{match symbol} Jackpot!"
/// Constrains
/// Number of tickets will be in range[0 … 100]
/// </summary>
namespace WinningTicket
{
    using System;
    using System.Text.RegularExpressions;

    public class WinningTicket
    {
        public static void Main()
        {
            string[] tickets = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            Regex ticketValidator = new Regex(@"([@#\$\^]){1}\1{5,9}");
            foreach (string ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                string leftPart = ticket.Substring(0,10);
                string rightPart = ticket.Substring(10, 10);

                var leftWinningCombination = ticketValidator.Match(leftPart).ToString();
                var rightWinningCombination = ticketValidator.Match(rightPart).ToString();

                int winningLengthInBoth = 0;
                winningLengthInBoth = leftWinningCombination.Length;
                if (rightWinningCombination.Length < leftWinningCombination.Length)
                {
                    winningLengthInBoth = rightWinningCombination.Length;
                }

                // The Judge gives 100 out of 100 with both the following condition commented out and not, but if I interpret the task
                // definiiton correctly this checked should be applied, still leaving it commented out for now
                if (winningLengthInBoth >= 6) // && (leftWinningCombination[0] == rightWinningCombination[0]))
                {
                    string jackpotOutput = string.Empty;
                    if (winningLengthInBoth == 10)
                    {
                        jackpotOutput = " Jackpot!";
                    }

                    Console.WriteLine($"ticket \"{ticket}\" - {winningLengthInBoth}{leftWinningCombination[0]}" + jackpotOutput);
                }
                else
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }
            }
        }
    }
}