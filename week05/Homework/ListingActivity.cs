using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity helps you list positive things in your life.";
        _duration = 40;
        _count = 0;
        _prompts = new List<string>();
    }

    public string GetRandomPrompt()
    {
        // To Do: Return a random prompt
        return "";
    }

    public List<string> GetListFromUser()
    {
        // To Do: Get list of responses from user
        return new List<string>();
    }

    public void Run()
    {
        // To Do: Add listing logic later
    }
}