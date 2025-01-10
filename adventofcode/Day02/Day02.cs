using System;
using System.Collections.Generic;
using System.IO;

namespace adventofcode.Day02
{
    internal class Day02
    {
        public static void Run(string[] args)
        {
            var filePath = "../../../../adventofcode/adventofcode/Day02/input.txt";

            // Initialize lists
            List<List<int>> reports = new List<List<int>>();

            // Read and process the input file
            foreach (string line in File.ReadLines(filePath))
            {
                // Initialize the levels list
                var levels = new List<int>();
                foreach (var number in line.Split(' ', (char)StringSplitOptions.RemoveEmptyEntries))
                {
                    // Add the levels to the list
                    levels.Add(int.Parse(number));
                }

                // Add the levels to the reports
                reports.Add(levels);
            }

            // Initialize count
            int safeReportsCount = 0;

            foreach (var report in reports)
            {
                if (IsSafeReportWithRemoval(report))
                {
                    safeReportsCount++;
                }
            }

            // Print the result
            Console.WriteLine($"Number of safe reports: {safeReportsCount}");
        }

        // Part 1
        private static bool IsSafeReport(List<int> levels)
        {
            bool isIncreasing = true;
            bool isDecreasing = true;

            for (int i = 1; i < levels.Count; i++)
            {
                int diff = levels[i] - levels[i - 1];

                if (Math.Abs(diff) < 1 || Math.Abs(diff) > 3)
                {
                    return false;
                }

                if (diff > 0) isDecreasing = false;

                if (diff < 0) isIncreasing = false;
            }

            return isIncreasing || isDecreasing;
        }

        // Part 2
        private static bool IsSafeReportWithRemoval(List<int> levels)
        {
            // Check if the report is safe
            if (IsSafeReport(levels))
            {
                return true;
            }

            // Try to remove one level at a time
            for (int i = 0; i < levels.Count; i++)
            {
                // Create a new list without the level at index i
                List<int> modifiedLevels = new List<int>(levels);
                modifiedLevels.RemoveAt(i);

                // Check if the modified report is safe
                if (IsSafeReport(modifiedLevels))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
