using System;
<<<<<<< HEAD

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");
    }
}
=======
using System;

class Program
{
    static void Main()
    {
        
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}
>>>>>>> e697187 (homework week1)
