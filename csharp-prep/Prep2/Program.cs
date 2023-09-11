using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string stringPercentage = Console.ReadLine();
        int gradePercentage = int.Parse(stringPercentage);
        string letter;

        if (gradePercentage >= 90) 
        {
           letter = "A";
        }
        else if (gradePercentage >=80)
        {
            letter = "B";
        }
        else if (gradePercentage >=70)
        {
            letter = "C";
        }
        else if (gradePercentage >=60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        Console.WriteLine($"Letter grade: {letter}");

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations, you have passed the course!");
        }
        else 
        {
            Console.WriteLine("We sorry, you did not pass the course.");
        }
    }
}