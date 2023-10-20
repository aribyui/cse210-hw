public class SimpleGoal : Goals
{
    private bool _isComplete;
    
    // constructor
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;   
    }

    // methods
    public override void RecordEvent()
    {
        if (!_isComplete) // Verifica que el objetivo aún no esté completado
        {
            // Otorga los puntos al completar el objetivo
            _points = GetPoints();
            
            // Marca el objetivo como completado
            _isComplete = true;
        }
    }
    public override bool isComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_name},{_description},{_points},{_isComplete}";  
    }   
}