﻿using System;
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
                bees[i] = long.MinValue;
                continue;
            }
            // equal power, hive dies, one hornet dies also
            else if (hornetsTotalPower == bees[i])
            {
                bees[i] = long.MinValue;
                hornetsTotalPower -= hornets[currentHornetAlive];
                hornets[currentHornetAlive] = long.MinValue;

                // no more alive hornets
                if (currentHornetAlive + 1 == hornets.Length)
                {
                    // with no more hornets alive, bees win, because as per task definition, there can't be any stalemates
                    beesAlive = true;
                    break;
                }

                currentHornetAlive++;
            }
            else
            {
                beesAlive = true;
                bees[i] -= hornetsTotalPower;
                hornetsTotalPower -= hornets[currentHornetAlive];
                hornets[currentHornetAlive] = long.MinValue;

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
            Console.WriteLine(string.Join(" ", bees.Where(x => x != long.MinValue)));
        }
        else
        {
            // print hornets
            Console.WriteLine(string.Join(" ", hornets.Where(x => x != long.MinValue)));
        }
    }
}