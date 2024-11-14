namespace KafkaLesson.Homework;

public static class Asserts
{
    public static void AssertProcessedEvents()
    {
        var processedEvents = EventStorage.Instance.GetProcessedEvent();

        var processedEventsWithId1 = processedEvents.Where(e => e.Id == InitialData.EventId1).ToList();
        var processedEventsWithId2 = processedEvents.Where(e => e.Id == InitialData.EventId2).ToList();
        var processedEventsWithId3 = processedEvents.Where(e => e.Id == InitialData.EventId3).ToList();
        
        Assert.That(processedEventsWithId1.Count, Is.EqualTo(6));
        Assert.That(processedEventsWithId2.Count, Is.EqualTo(6));
        Assert.That(processedEventsWithId3.Count, Is.EqualTo(1));
        
        Assert.That(processedEventsWithId1[0].Version, Is.EqualTo(1));
        Assert.That(processedEventsWithId1[1].Version, Is.EqualTo(2));
        Assert.That(processedEventsWithId1[2].Version, Is.EqualTo(3));
        Assert.That(processedEventsWithId1[3].Version, Is.EqualTo(4));
        Assert.That(processedEventsWithId1[4].Version, Is.EqualTo(5));
        Assert.That(processedEventsWithId1[5].Version, Is.EqualTo(6));
        
        Assert.That(processedEventsWithId2[0].Version, Is.EqualTo(1));
        Assert.That(processedEventsWithId2[1].Version, Is.EqualTo(2));
        Assert.That(processedEventsWithId2[2].Version, Is.EqualTo(4));
        Assert.That(processedEventsWithId2[3].Version, Is.EqualTo(5));
        Assert.That(processedEventsWithId2[4].Version, Is.EqualTo(7));
        Assert.That(processedEventsWithId2[5].Version, Is.EqualTo(9));
        
        Assert.That(processedEventsWithId3[0].Version, Is.EqualTo(10));
    }
}