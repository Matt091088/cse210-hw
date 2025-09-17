// Extra features added:
// 1. Extended the prompt list from 5 to 10 questions.
// 2. Each entry now saves both the date and the time.



using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();

        // --- Lista de prompts (preguntas) ---
        List<string> prompts = new List<string>
        {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What made me smile today?",
        "What challenge did I overcome today?",
        "What is one thing I learned today?",
        "What goal do I want to achieve tomorrow?",
        "What am I most grateful for today?"
};

        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                // Elegir un prompt aleatorio
                Random rand = new Random();
                string prompt = prompts[rand.Next(prompts.Count)];

                Console.WriteLine($"\nPrompt: {prompt}");
                Console.Write("Your response: ");
                string response = Console.ReadLine();

                string date = DateTime.Now.ToString("g"); // incluye fecha + hora corta
;

                // Crear nueva entrada y agregarla al diario
                Entry newEntry = new Entry(date, prompt, response);
                myJournal.AddEntry(newEntry);

                Console.WriteLine("Entry added!");
            }
            else if (choice == "2")
            {
                Console.WriteLine("\n--- Journal Entries ---");
                myJournal.DisplayEntries();
            }
            else if (choice == "3")
            {
                Console.Write("Enter filename to save (e.g., journal.txt): ");
                string filename = Console.ReadLine();
                myJournal.SaveToFile(filename);
            }
            else if (choice == "4")
            {
                Console.Write("Enter filename to load (e.g., journal.txt): ");
                string filename = Console.ReadLine();
                myJournal.LoadFromFile(filename);
            }
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid option, try again.");
            }
        }
    }
}
