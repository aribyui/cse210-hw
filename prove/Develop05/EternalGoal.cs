public class EternalGoal : Goals
{
    // constructor
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        
    }

    // methods
    public override void RecordEvent()
    {
        // da puntos cuando se logra el objetivo, 
        _points = GetPoints();
    }

    public override bool isComplete()
    {
        // pero nunca lo marque como completado.
        return false; // devuelve falso porque nunca se completa
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_name},{_description},{_points}";
    }
}