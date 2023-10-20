public abstract class Goals
{
    protected string _name = "";
    protected string _description = "";
    protected int _points = 0;

    // constructor
    public Goals()
    {

    }
    
    public Goals(string name, string description, int points)
    {   
        _name = name;
        _description = description;
        _points = points;
    }

    // getters-setters
    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public int GetPoints()
    {
        return _points;
    }
    public void SetPoints(int points)
    {
        _points = points;
    }

    // methods
    public abstract void RecordEvent();

    public abstract bool isComplete();

    public abstract string GetStringRepresentation();

    public virtual string GetDetailString()
    {
        string completionStatus; // adds 'X' if target is complete, blank if not
        
        if (isComplete())
        {
            completionStatus = "X";
        }
        else
        {
            completionStatus = " ";
        }

        return $"[{completionStatus}] {_name} ({_description})";
    }    
}