using System;
using System.Linq;

public class HornetAssault
{
    public static void Main()
    {
        long[] bees = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
        long[] hornets = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();

        bool beesAlive = false;
        long hornetsTotalPower = hornets.Sum();

        int currentHornetAlive = 0;

        for (int i = 0; i < bees.Length; i++)
        {
            // hornets kill the hive with no losses
            if (hornetsTotalPower > bees[i])
            {
                bees[i] = 0;
                continue;
            }
            // equal power, hive dies, one hornet dies also
            else if (hornetsTotalPower == bees[i])
            {
                bees[i] = 0;
                hornetsTotalPower -= hornets[currentHornetAlive];
                hornets[currentHornetAlive] = 0;

                // no more alive hornets
                if (currentHornetAlive + 1 == hornets.Length)
                {
                    break;
                }

                currentHornetAlive++;
            }
            else
            {
                beesAlive = true;
                bees[i] -= hornetsTotalPower;
                hornetsTotalPower -= hornets[currentHornetAlive];
                hornets[currentHornetAlive] = 0;

                // no more alive hornets
                if (currentHornetAlive + 1 == hornets.Length)
                {
                    break;
                }

                currentHornetAlive++;
            }
        }

        if (beesAlive)
        {
            // print bees
            Console.WriteLine(string.Join(" ", bees.Where(x => x > 0)));
        }
        else
        {
            // print hornets
            Console.WriteLine(string.Join(" ", hornets.Where(x => x > 0)));
        }
    }
}