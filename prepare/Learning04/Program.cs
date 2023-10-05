using System;

class Program
{
    static void Main(string[] args)
    {
        Assingment assingment = new Assingment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assingment.GetSummary());

        MathAssingment mathAssingment1 = new MathAssingment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssingment1.GetSummary());
        Console.WriteLine(mathAssingment1.GetHomeWorkdList());

        WritingAssingment writingAssingment = new WritingAssingment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssingment.GetSummary());
        Console.WriteLine(writingAssingment.GetWritingInfo());
    }
}