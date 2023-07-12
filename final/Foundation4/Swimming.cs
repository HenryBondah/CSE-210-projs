class Swimming : Activity
{
    public int Laps { get; set; }

    public Swimming(string type, DateTime date, int length, int laps)
        : base(type, date, length)
    {
        Laps = laps;
    }

    public override double GetDistance()
    {
        return Laps * 50 / 1000; // Convert laps to kilometers
    }

    public override double GetPace()
    {
        return Length / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {GetDistance()} km, Pace: {GetPace()} min per km";
    }
}
