using System;
using System.Collections.Generic;

// Clase base
abstract class Activity
{
    private DateTime _date;
    private int _length; // minutos

    public Activity(DateTime date, int length)
    {
        _date = date;
        _length = length;
    }

    public DateTime Date { get { return _date; } }
    public int Length { get { return _length; } }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {this.GetType().Name} ({_length} min) - Distance {GetDistance():0.0} km, Speed {GetSpeed():0.0} km/h, Pace {GetPace():0.00} min/km";
    }
}

// Running
class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int length, double distance)
        : base(date, length)
    {
        _distance = distance;
    }

    public override double GetDistance() { return _distance; }
    public override double GetSpeed() { return (_distance / Length) * 60; }
    public override double GetPace() { return Length / _distance; }
}

// Cycling
class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int length, double speed)
        : base(date, length)
    {
        _speed = speed;
    }

    public override double GetDistance() { return (_speed * Length) / 60.0; }
    public override double GetSpeed() { return _speed; }
    public override double GetPace() { return 60 / _speed; }
}

// Swimming
class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int length, int laps)
        : base(date, length)
    {
        _laps = laps;
    }

    public override double GetDistance() { return (_laps * 50) / 1000.0; }
    public override double GetSpeed() { return (GetDistance() / Length) * 60; }
    public override double GetPace() { return Length / GetDistance(); }
}

// Programa principal
class Program
{
    static void Main(string[] args)
    {
        var run = new Running(new DateTime(2022, 11, 3), 30, 5.0);
        var cycle = new Cycling(new DateTime(2022, 11, 3), 45, 20.0);
        var swim = new Swimming(new DateTime(2022, 11, 3), 60, 40);

        List<Activity> activities = new List<Activity> { run, cycle, swim };

        foreach (var a in activities)
        {
            Console.WriteLine(a.GetSummary());
        }
    }
}
