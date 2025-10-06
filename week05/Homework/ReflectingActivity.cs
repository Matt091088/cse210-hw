using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity helps you reflect on times when you showed strength and resilience.";
        _duration = 50;
        _prompts = new List<string>();
        _questions = new List<string>();
    }

    public string GetRandomPrompt()
    {
        // To Do: Return a random prompt from the list
        return "";
    }

    public string GetRandomQuestion()
    {
        // To Do: Return a random question from the list
        return "";
    }

    public void DisplayPrompt()
    {
        // To Do: Display the selected prompt
    }

    public void DisplayQuestions()
    {
        // To Do: Display questions related to the prompt
    }

    public void Run()
    {
        // To Do: Add reflection logic later
    }
}
