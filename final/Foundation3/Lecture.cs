class Lecture : Event {
    private string speaker;
    private int capacity;
    private string title;
    private string description;
    private string date;
    private string time;
    private string address;

    public Lecture(string title, string description, DateTime date, string time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address) {
        this.speaker = speaker;
        this.capacity = capacity;

    }

    public override string GetFullDetails() {
        return $"{base.GetFullDetails()}\nType: Lecture\nSpeaker: {speaker}\nCapacity: {capacity}";
    }
}