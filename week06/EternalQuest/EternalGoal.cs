// Meta que nunca termina, siempre da puntos
class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }

    // Cada vez que se registra evento, da puntos
    public override int RecordEvent()
    {
        return GetPoints();
    }

    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()} (Eternal)";
    }

    public override string GetStringRepresentation()
    {
        return base.GetStringRepresentation();
    }

    public static EternalGoal CreateFromString(string data)
    {
        string[] parts = data.Split(',');
        return new EternalGoal(parts[0], parts[1], int.Parse(parts[2]));
    }
}
