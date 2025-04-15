public abstract class Activity
{
    private DateTime _date;
    private int _lengthInMinutes;

    public Activity(DateTime date, int lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }

    public int GetLength() => _lengthInMinutes;
    public DateTime GetDate() => _date;

    public abstract double GetDistance(); // en kilómetros
    public abstract double GetSpeed();    // km/h
    public abstract double GetPace();     // min/km

    public virtual string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} {this.GetType().Name} ({_lengthInMinutes} min): " +
               $"Distance {GetDistance():0.0} km, Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.00} min per km";
    }
}
