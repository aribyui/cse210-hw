public class MathAssingment : Assingment
{
    private string _section = "";
    private string _problems = "";

    public MathAssingment(string studentName, string topic, string section, string problems) : base(studentName, topic)
    {
        _studentName = studentName;
        _topic = topic;
        _section = section;
        _problems = problems;        
    }

    public string GetSection()
    {
        return _section;
    }

    public void SetSection(string section)
    {
        _section = section;
    }

    public string GetProblems()
    {
        return _problems;
    }

    public void SetProblems(string problems)
    {
        _problems = problems;
    }
    
    public string GetHomeWorkdList()
    {
        return $"Section {_section} Problems {_problems}";
    }
}