using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
    }
}
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        int input;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Pedir números hasta que el usuario ingrese 0
        do
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());

            if (input != 0)
            {
                numbers.Add(input);
            }

        } while (input != 0);

        // Core Requirements
        int sum = 0;
        int max = numbers[0]; // asumimos que la lista no está vacía
        foreach (int num in numbers)
        {
            sum += num;
            if (num > max)
                max = num;
        }

        double average = (double)sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

        // Stretch Challenge
        // Encontrar el menor número positivo
        int? smallestPositive = null;
        foreach (int num in numbers)
        {
            if (num > 0 && (smallestPositive == null || num < smallestPositive))
            {
                smallestPositive = num;
            }
        }

        if (smallestPositive != null)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }
        else
        {
            Console.WriteLine("No positive numbers were entered.");
        }

        // Ordenar la lista y mostrarla
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}
