using System;
using System.Text.RegularExpressions;

namespace LAB2.PartTwo
{
    public class Solution
    {
        public static string FindTeamWithSmallestGoalDifference(string filePath)
        {
            string[] lines = System.IO.File.ReadAllLines(filePath);
            string nameTeam=null;
            int minimumDif=Int32.MaxValue;
            
            for (int i=1; i < lines.Length; i++)
            {
                string[] array = lines[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (array.Length > 2)
                {
                    int difValue = Math.Abs(Int32.Parse(array[6]) - Int32.Parse(array[8]));
                    if (difValue < minimumDif)
                    {
                        minimumDif = difValue;
                        nameTeam = array[1];
                    }
                }
            }
            return nameTeam;
        }
    }
}