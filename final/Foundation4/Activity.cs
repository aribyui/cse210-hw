public abstract class Activity
{   
    protected string _date = "";
    protected int _length = 0;
    protected double _distance = 0;
    protected double _speed = 0;
    protected int _laps = 0;
    protected double _pace = 0;

    public Activity()
    {

    }

    public string GetDate()
    {
        return _date;
    }

    public void SetDate(string date)
    {
        _date = date;
    }

    public int GetLength()
    {
        return _length;
    }

    public void SetLength(int length)
    {
        _length = length;
    }

    public double GetDistance()
    {
        return _distance;
    }

    public void SetDistance(double distance)
    {
        _distance = distance;
    }

    public double GetSpeed()
    {
        return _speed;
    }

    public void SetSpeed(double speed)
    {
        _speed = speed;
    }

    public int GetLaps()
    {
        return _laps;
    }

    public void SetLaps(int laps)
    {
        _laps = laps;
    }

    public double SetPace()
    {
        return _pace;
    }

    public void SetPace(double pace)
    {
        _pace = pace;
    }

    public int MinutesToSeconds()
    {
        return _length / 60;
    }
    public abstract double ComputeDistance();
    public abstract double ComputeSpeed();
    public abstract double ComputePace();
    public abstract string GetSummary();
}