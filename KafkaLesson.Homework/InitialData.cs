namespace KafkaLesson.Homework;

public static class InitialData
{
    public static readonly Guid EventId1 = Guid.NewGuid();
    public static readonly Guid EventId2 = Guid.NewGuid();
    public static readonly Guid EventId3 = Guid.NewGuid();
    
    public static List<TestEvent> GetEvents()
    {
        return new List<TestEvent>()
        {
            new TestEvent(EventId1, 1),
            new TestEvent(EventId2, 1),
            new TestEvent(EventId3, 10),
            new TestEvent(EventId1, 1),
            new TestEvent(EventId2, 2),
            new TestEvent(EventId3, 9),
            new TestEvent(EventId1, 2),
            new TestEvent(EventId2, 2),
            new TestEvent(EventId3, 8),
            new TestEvent(EventId1, 2),
            new TestEvent(EventId2, 4),
            new TestEvent(EventId3, 1),
            new TestEvent(EventId1, 3),
            new TestEvent(EventId2, 5),
            new TestEvent(EventId3, 2),
            new TestEvent(EventId1, 3),
            new TestEvent(EventId2, 3),
            new TestEvent(EventId3, 3),
            new TestEvent(EventId1, 4),
            new TestEvent(EventId2, 4),
            new TestEvent(EventId3, 4),
            new TestEvent(EventId1, 4),
            new TestEvent(EventId2, 7),
            new TestEvent(EventId3, 5),
            new TestEvent(EventId1, 5),
            new TestEvent(EventId2, 6),
            new TestEvent(EventId3, 6),
            new TestEvent(EventId1, 5),
            new TestEvent(EventId2, 7),
            new TestEvent(EventId3, 7),
            new TestEvent(EventId1, 6),
            new TestEvent(EventId2, 9),
            new TestEvent(EventId3, 3),
            new TestEvent(EventId1, 6),
            new TestEvent(EventId2, 8),
            new TestEvent(EventId3, 6),
        };
    }
}