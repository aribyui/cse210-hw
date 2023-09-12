using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (number != 0)
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        /*
        1. Compute the sum, or total, of the numbers in the list.
        2. Compute the average of the numbers in the list.
        3. Find the maximum, or largest, number in the list.
        */
        int sum = numbers.Sum();
        double average = numbers.Average();
        int max = numbers.Max();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number: {max}");

        /*
        Stretch Challenge
        1. Have the user enter both positive and negative numbers, then find the smallest positive number (the
        positive number that is closest to zero).
        2. Sort the numbers in the list and display the new, sorted list. Hint: There are C# libraries that can help you
        here, try searching the internet for them.
        */
        List<int> positiveNumbers = new List<int>();

        foreach (int n in numbers)
        {
            if (n > 0)
            {
                positiveNumbers.Add(n);
            }
        }

        if (positiveNumbers.Count > 0)
        {
            Console.WriteLine($"The smallest positive number is: {positiveNumbers.Min()}");
        }
        else
        {
            Console.WriteLine("There is no smallest positive number.");
        }

        numbers.Sort();

        Console.WriteLine("The sorted list is:");

        foreach (int n in numbers)
        {
            Console.WriteLine(n);
        }
    }
}