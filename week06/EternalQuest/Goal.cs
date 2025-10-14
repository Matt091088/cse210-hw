// Clase base para todos los tipos de metas
abstract class Goal
{
    private string _name;        // Nombre de la meta
    private string _description; // Descripción de la meta
    private int _points;         // Puntos que da al completarla

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    // Método que cada clase define para registrar un evento
    public abstract int RecordEvent();

    // Devuelve detalles de la meta como string
    public virtual string GetDetailsString()
    {
        return $"{_name} - {_description} ({_points} points)";
    }

    // Devuelve una versión de la meta para guardar en archivo
    public virtual string GetStringRepresentation()
    {
        return $"{GetType().Name}:{_name},{_description},{_points}";
    }

    // Métodos para obtener información de la meta
    public string GetName() => _name;
    public int GetPoints() => _points;
}
