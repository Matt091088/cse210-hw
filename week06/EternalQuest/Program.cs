using System;

class Program
{
    static void Main()
    {
        GoalManager manager = new GoalManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n--- Eternal Quest ---");
            Console.WriteLine("1. Create goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Record event");
            Console.WriteLine("4. Show score");
            Console.WriteLine("5. Save goals");
            Console.WriteLine("6. Load goals");
            Console.WriteLine("7. Exit");
            Console.Write("Option: ");
            string choice = Console.ReadLine();

            switch(choice)
            {
                case "1":
                    Console.WriteLine("Select type: 1) Simple 2) Eternal 3) Checklist");
                    string type = Console.ReadLine();
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Description: ");
                    string desc = Console.ReadLine();
                    Console.Write("Points: ");
                    int points = int.Parse(Console.ReadLine());

                    if (type == "1") manager.AddGoal(new SimpleGoal(name, desc, points));
                    else if (type == "2") manager.AddGoal(new EternalGoal(name, desc, points));
                    else if (type == "3")
                    {
                        Console.Write("Target count: ");
                        int target = int.Parse(Console.ReadLine());
                        Console.Write("Bonus points: ");
                        int bonus = int.Parse(Console.ReadLine());
                        manager.AddGoal(new ChecklistGoal(name, desc, points, target, bonus));
                    }
                    break;

                case "2":
                    manager.DisplayGoals();
                    break;

                case "3":
                    Console.Write("Enter goal number: ");
                    int index = int.Parse(Console.ReadLine()) - 1;
                    manager.RecordGoalEvent(index);
                    break;

                case "4":
                    manager.ShowScore();
                    break;

                case "5":
                    manager.SaveGoals("goals.txt");
                    Console.WriteLine("Goals saved!");
                    break;

                case "6":
                    manager.LoadGoals("goals.txt");
                    Console.WriteLine("Goals loaded!");
                    break;

                case "7":
                    running = false;
                    Console.WriteLine("Exiting program...");
                    break;
            }
        }
    }
}
