using System;
using System.IO;
using System.Text.RegularExpressions;

namespace adventofcode.Day03
{
    internal class Day03
    {
        public static void Run(string[] args)
        {
            var filePath = "../../../../adventofcode/adventofcode/Day03/input.txt";

            // Initialize pattern and regex
            string pattern = @"mul\((\d+),(\d+)\)";

            Regex regex = new Regex(pattern);

            int result = 0;

            // Read and process the input file
            foreach (var line in File.ReadLines(filePath))
            {
                MatchCollection matches = regex.Matches(line);

                foreach (Match match in matches)
                {
                    // Action when the pattern match the input.txt
                    if (match.Success)
                    {
                        // Convert and calculate two numbers from each mul
                        int val1 = int.Parse(match.Groups[1].Value);
                        int val2 = int.Parse(match.Groups[2].Value);
                        int sum = val1 * val2;
                        result += sum;
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
