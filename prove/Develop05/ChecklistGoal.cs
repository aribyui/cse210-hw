public class ChecklistGoal : Goals
{   
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    // constructor
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    // methods
    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            _points = GetPoints();

            // Si el objetivo se ha completado según el objetivo, otorgar puntos de bonificación
            if (_amountCompleted == _target)
            {
                _points += _bonus;
            }
        }        
    }
    public override bool isComplete()
    {
        return _amountCompleted == _target;
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_name},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }
    public override string GetDetailString()
    {
        return $"[ ] {_name} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }
}