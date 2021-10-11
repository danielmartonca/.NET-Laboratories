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
                string temp1 = lines[i].Split(" ", StringSplitOptions.RemoveEmptyEntries)[2];
                string temp2 = lines[i].Split(" ",StringSplitOptions.RemoveEmptyEntries)[3];

                if (temp1[temp1.Length - 1].Equals('*'))
                {
                    temp1 = temp1.Remove(temp1.Length - 1);
                }
                if (temp2[temp2.Length - 1].Equals('*'))
                {
                    temp2 = temp2.Remove(temp2.Length - 1);
                }

                int tempVal = Int32.Parse(temp1)-Int32.Parse(temp2);

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
