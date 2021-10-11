using System;
using LAB2.PartThree;

namespace LAB2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution.GetColumnFieldBasedOnMinimumDifference(@"C:\Users\Administrator\Documents\Rider\LAB2\LAB2\LAB2\weather.dat",1,2,3));
            Console.WriteLine(Solution.GetColumnFieldBasedOnMinimumDifference(@"C:\Users\Administrator\Documents\Rider\LAB2\LAB2\LAB2\football.dat",2,7,9));
        }
    }
}
