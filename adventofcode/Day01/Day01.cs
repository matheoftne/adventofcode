using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace adventofcode.Day01
{
    internal class Day01
    {
        public static void Run(string[] args)
        {
            var filePath = "../../../../adventofcode/adventofcode/Day01/input.txt";

            // Initialize lists
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();

            // Read and process the input file
            foreach (var line in File.ReadLines(filePath))
            {
                var parts = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length == 2)
                {
                    list1.Add(int.Parse(parts[0]));
                    list2.Add(int.Parse(parts[1]));
                }
            }

            // Sort both lists
            list1.Sort();
            list2.Sort();

            // Calculate total distance
            int totalDistance = list1.Zip(list2, (a, b) => Math.Abs(a - b)).Sum();
            Console.WriteLine($"Total Distance: {totalDistance}");
        }
    }
}
