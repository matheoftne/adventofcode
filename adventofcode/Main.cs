namespace adventofcode;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose a day to run:");
        var input = Console.ReadLine();

        switch (input)
        {
            case "1":
                adventofcode.Day01.Day01.Run(args);
                break;
            case "2":
                adventofcode.Day02.Day02.Run(args);
                break; 
            default:
                Console.WriteLine("Invalid day");
                break;
        }
    }
}