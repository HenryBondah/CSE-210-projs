class StationaryBicycle : Activity
{
    public double Speed { get; set; }

    public StationaryBicycle(string type, DateTime date, int length, double speed)
        : base(type, date, length)
    {
        Speed = speed;
    }

    public override double GetSpeed()
    {
        return Speed;
    }

    public override double GetDistance()
    {
        return Speed * Length / 60;
    }

    public override double GetPace()
    {
        return 60 / Speed;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {GetDistance()} miles, Speed: {Speed} mph, Pace: {GetPace()} min per mile";
    }
}
