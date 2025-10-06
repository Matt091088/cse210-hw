using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly.";
        _duration = 30;
    }

    public void Run()
    {
        DisplayStartingMessage();

        // Stub: alternar mensajes de respiración
        Console.WriteLine("Breathe in...");
        ShowCountdown(3);
        Console.WriteLine("Breathe out...");
        ShowCountdown(3);

        DisplayEndingMessage();
    }
}
