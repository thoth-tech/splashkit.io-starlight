using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the value: ");
        string input = Console.ReadLine();

        if (IsNumber(input))
            Console.WriteLine($"{input} is a number.");
        else
            Console.WriteLine($"{input} is not a number.");
    }

    static bool IsNumber(string input)
    {
        return double.TryParse(input, out _);
    }
}
