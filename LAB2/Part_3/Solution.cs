using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LAB2.PartThree
{
    public class Solution
    {
        private static string GetStringFromLineField(string line, int number)
        {
            var temp=line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            if (number-1 >= 0 && number-1 < temp.Length)
            {
                return temp[number-1];
            }
            return null;
        }

        private static int ParseStringToInteger(string str)
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

        private static int GetDifference(int a, int b)
        {
            if(a==Int32.MaxValue||b==Int32.MaxValue)
                return Int32.MaxValue;

            return Math.Abs(a-b);
        }

        public static string GetColumnFieldBasedOnMinimumDifference(string filePath,int returnedColumnNumber,int firstColumnNumber, int secondColumnNumber)
        {
            var lines = System.IO.File.ReadAllLines(filePath);

            int minValue=Int32.MaxValue;
            string minColumnField="";
            foreach (var line in lines)
            {
                var val1 = ParseStringToInteger(GetStringFromLineField(line, firstColumnNumber));
                var val2 = ParseStringToInteger(GetStringFromLineField(line, secondColumnNumber));
                var difference = GetDifference(val1, val2);
                if(difference<minValue)
                {
                    minValue = difference;
                    minColumnField = GetStringFromLineField(line, returnedColumnNumber);
                }
            }
            return minColumnField;
        }
    }
}
