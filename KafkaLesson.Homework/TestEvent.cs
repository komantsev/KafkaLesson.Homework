namespace KafkaLesson.Homework;

public record TestEvent(
    Guid Id,
    int Version);