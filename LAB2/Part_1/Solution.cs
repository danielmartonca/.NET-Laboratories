using System;
using System.Text.RegularExpressions;

namespace LAB2.PartOne
{
    public class Solution
    {
        public static int GetMinimumTemperatureFromFile(string filePath)
        {
            string[] lines = System.IO.File.ReadAllLines(filePath);
            int dayNumber = 1, minimumTemp = Int32.MaxValue;

            for (int i=2; i < lines.Length - 1; i++)
            {
                string temp = lines[i].Split(" ",StringSplitOptions.RemoveEmptyEntries)[3];

                if (temp[temp.Length - 1].Equals('*'))
                {
                    temp = temp.Remove(temp.Length - 1);
                }
                
                int tempVal = Int32.Parse(temp);
                
                if (tempVal < minimumTemp)
                {
                    minimumTemp = tempVal;
                    dayNumber = i-1;
                }
            }

            return dayNumber;
        }
    }
}