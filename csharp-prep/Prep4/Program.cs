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

        // se crea la variable 'positiveNumbers' que almacenará la lista
        List<int> positiveNumbers = new List<int>();

        /* 
        se crea un ciclo 'foreach'
        se itera la lista 'numbers' con la variable 'n'
        */
        foreach (int n in numbers)
        {
            // si los elementos de la lista 'numbers' tiene números mayores a '0'
            if (n > 0)
            {
                // se agregará por cada ciclo, cada número mayor a cero (positivo)
                // que esté en la lista 'numbers' y se agregará a la lista 'positiveNumbers'
                positiveNumbers.Add(n);
            }
        }

        /* 
        si a la lista 'positiveNumbers' se le agregaron elementos,
        es decir, se toma la longitud o tamaño de la lista 'positiveNumbers'
        para determinar si tiene elementos en ella usando el método 'Count()'
        si la cantidad de elementos es mayor a '0', entonces la lista no esta vacía
        y tiene elementos en ella
        */
        if (positiveNumbers.Count > 0)
        {
            /* 
            se imprime el número más pequeño de lista 'positiveNumbers',
            se llama a la variable 'positiveNumbers' que almacena la lista,  
            y se usa el método 'Min()' para obtener el elemento más pequeño
            */
            Console.WriteLine($"The smallest positive number is: {positiveNumbers.Min()}");
        }
        else
        {
            /* 
            si la lista 'positiveNumbers' no tiene elementos
            se imprime el siguiente mensaje
            */
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