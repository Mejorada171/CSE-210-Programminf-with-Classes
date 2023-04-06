class Outdoor : Event {
    private string weather;

    public Outdoor(string title, string description, DateTime date, string time, Address address, string weather)
        : base(title, description, date, time, address) {
        this.weather = weather;
    }

    public override string GetFullDetails() {
        return $"{base.GetFullDetails()}\nType: Outdoor Gathering\nWeather: {weather}";
    }
}