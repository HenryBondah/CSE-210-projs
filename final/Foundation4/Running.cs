class Running : Activity
{
    public double Distance { get; set; }

    public Running(string type, DateTime date, int length, double distance)
        : base(type, date, length)
    {
        Distance = distance;
    }

    public override double GetDistance()
    {
        return Distance;
    }

    public override double GetSpeed()
    {
        return Distance / Length * 60;
    }

    public override double GetPace()
    {
        return Length / Distance;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {Distance} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}