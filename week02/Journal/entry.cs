using System;

public class Entry
{
    // --- Atributos (qué guarda esta clase) ---
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }

    // --- Constructor (se usa al crear una nueva entrada) ---
    public Entry(string date, string prompt, string response)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
    }

    // --- Método para mostrar una entrada ---
    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
        Console.WriteLine("-------------------------------");
    }
}
