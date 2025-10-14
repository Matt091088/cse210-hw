// Meta que se completa varias veces y da bonus al final
class ChecklistGoal : Goal
{
    private int _targetCount;      // Veces que hay que completar
    private int _completedCount;   // Veces que ya completó
    private int _bonusPoints;      // Bonus al completar todo

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _completedCount = 0;
        _bonusPoints = bonusPoints;
    }

    // Registrar evento: suma puntos y bonus si se completa
    public override int RecordEvent()
    {
        if (_completedCount < _targetCount)
        {
            _completedCount++;
            int total = GetPoints();
            if (_completedCount == _targetCount) total += _bonusPoints;
            return total;
        }
        return 0;
    }

    public override string GetDetailsString()
    {
        string status = (_completedCount >= _targetCount) ? "[X]" : "[ ]";
        return $"{status} {base.GetDetailsString()} (Completed {_completedCount}/{_targetCount})";
    }

    public override string GetStringRepresentation()
    {
        return $"{base.GetStringRepresentation()},{_completedCount},{_targetCount},{_bonusPoints}";
    }

    public static ChecklistGoal CreateFromString(string data)
    {
        string[] parts = data.Split(',');
        ChecklistGoal goal = new ChecklistGoal(parts[0], parts[1], int.Parse(parts[2]),
                                               int.Parse(parts[3]), int.Parse(parts[4]));
        goal._completedCount = int.Parse(parts[3]);
        return goal;
    }
}
