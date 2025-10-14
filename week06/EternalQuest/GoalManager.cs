using System;
using System.Collections.Generic;
using System.IO;

// Clase que maneja todas las metas y el puntaje
class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int totalScore = 0;

    // Agrega una nueva meta
    public void AddGoal(Goal goal) => goals.Add(goal);

    // Muestra todas las metas
    public void DisplayGoals()
    {
        for (int i = 0; i < goals.Count; i++)
            Console.WriteLine($"{i+1}. {goals[i].GetDetailsString()}");
    }

    // Registrar un evento en la meta indicada
    public void RecordGoalEvent(int index)
    {
        if (index >= 0 && index < goals.Count)
            totalScore += goals[index].RecordEvent();
    }

    // Mostrar puntaje total
    public void ShowScore() => Console.WriteLine($"Total Score: {totalScore}");

    // Guardar metas a archivo
    public void SaveGoals(string filename)
    {
        using StreamWriter writer = new StreamWriter(filename);
        foreach (Goal g in goals)
            writer.WriteLine(g.GetStringRepresentation());
    }

    // Cargar metas desde archivo
    public void LoadGoals(string filename)
    {
        if (!File.Exists(filename)) return;
        goals.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split(':');
            string type = parts[0];
            string data = parts[1];

            if (type == "SimpleGoal") goals.Add(SimpleGoal.CreateFromString(data));
            else if (type == "EternalGoal") goals.Add(EternalGoal.CreateFromString(data));
            else if (type == "ChecklistGoal") goals.Add(ChecklistGoal.CreateFromString(data));
        }
    }
}
