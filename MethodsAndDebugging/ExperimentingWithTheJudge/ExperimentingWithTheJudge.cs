using System;
using System.Threading;

/// <summary>
///  Testing what SoftUni Judge run data (like memory usage and time) correlate with Thread.Sleep and
///  arrays of different sizes
/// </summary>
public class ExperimentingWithJudge
{
    public static void Main()
    {
        //       int memorySize = (int)Math.Pow(10, 8);
              string memoryEater = new string('A', 4800000);
    //    Thread.Sleep(0);
    }
}