class Lecture : Event {
    private string _speaker;
    private int _capacity;
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private string _address;

    public Lecture(string title, string description, DateTime date, string time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address) {
        this._speaker = speaker;
        this._capacity = capacity;

    }

    public override string GetFullDetails() {
        return $"{base.GetFullDetails()}\nType: Lecture\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
}