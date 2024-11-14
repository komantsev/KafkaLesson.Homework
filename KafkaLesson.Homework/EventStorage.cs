namespace KafkaLesson.Homework;

public class EventStorage
{
    private static readonly Lazy<EventStorage> Lazy = new(() => new EventStorage());
    public static EventStorage Instance => Lazy.Value;
    private EventStorage() { }
    
    private readonly List<TestEvent> _processedEvents = [];

    public void AddProcessedEvent(TestEvent ev)
    {
        _processedEvents.Add(ev);
    }

    public List<TestEvent> GetProcessedEvent()
    {
        return _processedEvents.ToList();
    }
}