using System;
using System.Collections.Generic;
using System.Linq;

class Day01
{
    static void Main(string[] args)
    {
        var filePath = "../../../../adventofcode/Day01/Day01.txt";
        
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
