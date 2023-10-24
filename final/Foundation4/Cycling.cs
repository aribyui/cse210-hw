public class Cycling : Activity
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
        return (_distance / _length) * 60;
    }

    public override string GetSummary()
    {
        return $"{_date} Cycling ({MinutesToSeconds()} min): Distance {_distance} km, Speed: {ComputeSpeed()} kph, Pace: {ComputePace()} min per km";
    }
}