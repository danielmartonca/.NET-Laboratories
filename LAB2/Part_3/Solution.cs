using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LAB2.PartThree
{
    public class Solution
    {
        private static string GetValuesColumn(string line, int number)
        {
            var temp=line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            if (number-1 >= 0 && number-1 < temp.Length)
            {
                return temp[number-1];
            }
            return null;
        }

        private static int ParseTemperatureString(string str)
        {
            if (str == null) return Int32.MaxValue;

            if (str.EndsWith('*'))
            {
                str = str.Remove(str.Length - 1);
            }

            foreach (var ch in str)
            {
                if (ch=='.' || !Char.IsDigit(ch))
                    return Int32.MaxValue;
            }

            return Int32.Parse(str);
        }

        private static int GetMinimumValue(string a, string b)
        {
            int x = Int32.Parse(a);
            int y = Int32.Parse(b);
            return (x<y) ? x : y;
        }

        private static int GetDifference(string a, string b)
        {
            if(a==null||b==null)
                return Int32.MaxValue;

            int x = Int32.Parse(a);
            int y = Int32.Parse(b);
            return Math.Abs(x-y);
        }

        public static string GetMinimumTemperature(string filePath)
        {
            var lines = System.IO.File.ReadAllLines(filePath);

            int minValue=Int32.MaxValue;
            string minDay=" ";
            foreach (var line in lines)
            {
                var temperature = ParseTemperatureString(GetValuesColumn(line, 3));
                if(temperature<minValue)
                {
                    minValue = temperature;
                    minDay = GetValuesColumn(line, 1);
                }
            }
            return minDay;
        }

        public static string GetMinimumGoalDifference(string filePath)
        {
            var lines = System.IO.File.ReadAllLines(filePath);

            int minValue=Int32.MaxValue;
            string minTeamName="";
            foreach (var line in lines)
            {
                var goalsFor = GetValuesColumn(line, 7);
                var goalsAgainst = GetValuesColumn(line, 9);
                var goalDifference = GetDifference(goalsFor, goalsAgainst);
                if(goalDifference<minValue)
                {
                    minValue = goalDifference;
                    minTeamName = GetValuesColumn(line, 2);
                }
            }
            return minTeamName;
        }
    }
}
