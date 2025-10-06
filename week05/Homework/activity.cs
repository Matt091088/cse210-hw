using System;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
        _name = "Activity";
        _description = "Base activity description.";
        _duration = 0;
    }

    public void DisplayStartingMessage()
    {
        // To Do: Show a message when the activity starts
    }

    public void DisplayEndingMessage()
    {
        // To Do: Show a message when the activity ends
    }

    public void ShowSpinner(int seconds)
    {
        // To Do: Pause for a few seconds and show a spinner
    }

    public void ShowCountDown(int seconds)
    {
        // To Do: Show a countdown for a few seconds
    }
}
