using System;
using System.Collections.Generic;
using System.IO; // Para guardar y leer archivos

public class Journal
{
    // --- Lista para guardar todas las entradas ---
    private List<Entry> entries = new List<Entry>();

    // --- Agregar una nueva entrada ---
    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    // --- Mostrar todas las entradas ---
    public void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("The journal is empty.");
        }
        else
        {
            foreach (Entry entry in entries)
            {
                entry.Display(); // Usa el método Display de Entry
            }
        }
    }

    // --- Guardar el diario en un archivo ---
    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                // Guardamos en formato: date|prompt|response
                outputFile.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
        Console.WriteLine($"Journal saved to {filename}");
    }

    // --- Cargar el diario desde un archivo ---
    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            entries.Clear(); // Borramos lo que había antes

            foreach (string line in lines)
            {
                string[] parts = line.Split("|");
                if (parts.Length == 3)
                {
                    Entry entry = new Entry(parts[0], parts[1], parts[2]);
                    entries.Add(entry);
                }
            }
            Console.WriteLine($"Journal loaded from {filename}");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
