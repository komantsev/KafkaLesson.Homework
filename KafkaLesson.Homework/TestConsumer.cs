using Dodo.Kafka.Consumer;

namespace KafkaLesson.Homework;

public class TestConsumer : IConsumer<TestEvent>
{
    public async Task Consume(TestEvent ev, CancellationToken ct)
    {
        await Task.CompletedTask;
        
        // TODO Add logic to ignore late and duplicate events.
        
        EventStorage.Instance.AddProcessedEvent(ev);
    }
}