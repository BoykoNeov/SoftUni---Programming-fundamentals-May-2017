/// <summary>
/// This is almost the same task as from programming basics exam on 18 Dec 2016
/// </summary>
using System;
public class MagicLetter
{
    public static void Main(string[] args)
    {
        int firstLetter = char.Parse(Console.ReadLine());
        int secondLetter = char.Parse(Console.ReadLine());
        int thirsLetter = char.Parse(Console.ReadLine());

        int broiOtpechataniKombinacii = 0;

        for (int firstSymbolNumber = firstLetter; firstSymbolNumber <= secondLetter; firstSymbolNumber++)
        {
            if (firstSymbolNumber == thirsLetter)
            {
                continue;
            }

            for (int secondSymbolNumber = firstLetter; secondSymbolNumber <= secondLetter; secondSymbolNumber++)
            {
                if (secondSymbolNumber == thirsLetter)
                {
                    continue;
                }

                for (int thirdSymbolNumber = firstLetter; thirdSymbolNumber <= secondLetter; thirdSymbolNumber++)
                {
                    if (thirdSymbolNumber == thirsLetter)
                    {
                        continue;
                    }

                    Console.Write($"{Convert.ToChar(firstSymbolNumber)}{Convert.ToChar(secondSymbolNumber)}{(Convert.ToChar(thirdSymbolNumber))} ");
                    broiOtpechataniKombinacii++;
                }
            }
        }
    }
}