using System;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration; // en segundos

    public Activity()
    {
        _name = "Generic Activity";
        _description = "This is a general activity description.";
        _duration = 0;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_name}");
        Console.WriteLine(_description);
        Console.WriteLine($"Duration: {_duration} seconds");
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        ShowSpinner(2);
        Console.WriteLine($"{_name} completed for {_duration} seconds.");
    }

    public void ShowSpinner(int seconds)
    {
        // Stub: simple animation
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine(i);
            System.Threading.Thread.Sleep(1000);
        }
    }
}
