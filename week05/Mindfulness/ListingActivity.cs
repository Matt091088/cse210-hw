using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    private int _count;

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _duration = 30;

        _prompts = new List<string> {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        _count = 0;
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine(GetRandomPrompt());
        _count = GetListFromUser().Count;
        Console.WriteLine($"You listed {_count} items.");
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        return _prompts[rnd.Next(_prompts.Count)];
    }

    public List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        Console.WriteLine("Enter items (press Enter to finish):");
        string input;
        while (!string.IsNullOrEmpty(input = Console.ReadLine()))
        {
            items.Add(input);
        }
        return items;
    }
}
