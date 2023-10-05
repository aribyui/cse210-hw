public class WritingAssingment : Assingment
{
    private string _title;

    public WritingAssingment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _studentName = studentName;
        _topic = topic;
        _title = title;
    }

    public string GetTitle()
    {
        return _title;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetWritingInfo()
    {
        return $"{_title} by {_studentName}";
    }
}