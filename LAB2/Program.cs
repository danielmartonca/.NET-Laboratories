using System;
using LAB2.PartThree;

namespace LAB2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution.GetMinimumTemperature(@"C:\Users\Administrator\Documents\Rider\LAB2\LAB2\LAB2\weather.dat"));
            Console.WriteLine(Solution.GetMinimumGoalDifference(@"C:\Users\Administrator\Documents\Rider\LAB2\LAB2\LAB2\football.dat"));
        }
    }
}
