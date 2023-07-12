class OutdoorGathering : Event
{
    public string Weather { get; set; }

    public OutdoorGathering(string title, string description, string date, string time, string address, string weather)
        : base(title, description, date, time, address)
    {
        Weather = weather;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Outdoor Gathering\nWeather: {Weather}";
    }
}
