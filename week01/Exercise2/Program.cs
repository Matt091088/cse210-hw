using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
    }
}
        // Pedir la nota al usuario
        Console.Write("Enter your grade percentage: ");
        int grade = int.Parse(Console.ReadLine());

        // Determinar la letra
        string letter;
        if (grade >= 90) letter = "A";
        else if (grade >= 80) letter = "B";
        else if (grade >= 70) letter = "C";
        else if (grade >= 60) letter = "D";
        else letter = "F";

        // Determinar el signo (+/-) si aplica
        string sign = "";
        if (letter != "A" && letter != "F") // B, C, D pueden tener +/-
        {
            int lastDigit = grade % 10;
            if (lastDigit >= 7) sign = "+";
            else if (lastDigit < 3) sign = "-";
        }
        else if (letter == "A" && grade < 100) // Solo A- es posible, no A+
        {
            int lastDigit = grade % 10;
            if (lastDigit < 3) sign = "-";
        }

        // Mostrar la nota final con letra y signo
        Console.WriteLine($"Your grade is: {letter}{sign}");

        // Mensaje de aprobación
        if (grade >= 70)
            Console.WriteLine("Congratulations! You passed the course.");
        else
            Console.WriteLine("Don't give up! You can do better next time.");
}
