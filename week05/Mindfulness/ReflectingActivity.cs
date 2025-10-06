using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience.";
        _duration = 30;

        _prompts = new List<string> {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string> {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        // Stub: shows prompt and questions
        Console.WriteLine(GetRandomPrompt());
        DisplayQuestions();

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        return _prompts[rnd.Next(_prompts.Count)];
    }

    public string GetRandomQuestion()
    {
        Random rnd = new Random();
        return _questions[rnd.Next(_questions.Count)];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }

    public void DisplayQuestions()
    {
        foreach (string question in _questions)
        {
            Console.WriteLine(question);
            ShowSpinner(3);
        }
    }
}
