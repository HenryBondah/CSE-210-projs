class Reception : Event
{
    public string RSVP { get; set; }

    public Reception(string title, string description, string date, string time, string address, string rsvp)
        : base(title, description, date, time, address)
    {
        RSVP = rsvp;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Reception\nRSVP: {RSVP}";
    }
}
