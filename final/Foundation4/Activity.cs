
class Activity
{
    public string Type { get; set; }
    public DateTime Date { get; set; }
    public int Length { get; set; }

    public Activity(string type, DateTime date, int length)
    {
        Type = type;
        Date = date;
        Length = length;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return $"{Date:d MMM yyyy} {Type} ({Length} min)";
    }
}
