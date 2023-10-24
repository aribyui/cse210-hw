public class Running : Activity
{
    public override double ComputeDistance()
    {
        return Math.Round(_speed * _length / 1000, 2);
    }

    public override double ComputePace()
    {
        return Math.Round(60 / _speed, 2);
    }

    public override double ComputeSpeed()
    {
        return -1;
    }

    public override string GetSummary()
    {
        return $"{_date} Running ({MinutesToSeconds()} min): Distance {ComputeDistance()} km, Speed: {_speed} kph, Pace: {ComputePace()} min per km";
    }
}