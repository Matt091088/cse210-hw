// Meta que se completa solo una vez
class SimpleGoal : Goal
{
    private bool _isComplete; // Si ya se completó

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false; // Al crear la meta, no está completada
    }

    // Registrar evento: si no está completa, suma puntos
    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return GetPoints();
        }
        return 0;
    }

    // Muestra el estado de la meta [ ] o [X]
    public override string GetDetailsString()
    {
        string status = _isComplete ? "[X]" : "[ ]";
        return $"{status} {base.GetDetailsString()}";
    }

    // Guardar meta en archivo
    public override string GetStringRepresentation()
    {
        return $"{base.GetStringRepresentation()},{_isComplete}";
    }

    // Crear meta desde un string cargado del archivo
    public static SimpleGoal CreateFromString(string data)
    {
        string[] parts = data.Split(',');
        SimpleGoal goal = new SimpleGoal(parts[0], parts[1], int.Parse(parts[2]));
        goal._isComplete = bool.Parse(parts[3]);
        return goal;
    }
}
