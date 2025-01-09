namespace adventofcode.Day03;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Day03
{
    public static void Run(string[] args)
    {
        var filePath = "../../../../adventofcode/Day03/input.txt";

        // Initialize list
        List<int> list1 = new List<int>();

        // Initialize pattern and regex
        string pattern = "mul\\(\\d+,\\d+\\)";

        Regex regex = new Regex(pattern);

        Match match = regex.Match(filePath);

        // Read and process the input file
        foreach (var line in File.ReadLines(filePath))
        {
            // Action when the pattern match the input.txt
            if (match.Success)
            {
                Console.WriteLine(match.Captures[0].Value);
            }
        }
    }
}
