public class WritingAssingment : Assingment
{
    private string _title;

    public WritingAssingment(string studentName, string topic, string title) : base(studentName, topic)
    {
        /*
        las variables _studentName y _topic
        son heredades de la clase padre 'Assingment'
        por lo cuál, es redundante volver a asignarlas
        */
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
        return $"{_title} by {GetStudentName()}";
    }
}