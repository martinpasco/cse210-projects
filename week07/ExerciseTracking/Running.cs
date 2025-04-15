public class Running : Activity
{
    private double _distance; // en kilómetros

    public Running(DateTime date, int minutes, double distance)
        : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance() => _distance;

    public override double GetSpeed() => (_distance / GetLength()) * 60;

    public override double GetPace() => GetLength() / _distance;
}
