public class Swimming : Activity
{
    public override double ComputeDistance()
    {
        return -1;
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
        return $"{_date} Swimming ({MinutesToSeconds()} min): Distance {_distance} km, Speed: {ComputeSpeed()} kph, Pace: {ComputePace()} min per km";
    }
}