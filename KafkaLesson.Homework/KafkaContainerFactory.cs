using Testcontainers.Kafka;

namespace KafkaLesson.Homework;

public static class KafkaContainerFactory
{
    public static async Task<KafkaContainer> CreateAndStart()
    {
        var kafkaContainer = new KafkaBuilder()
            .WithImage("confluentinc/cp-kafka:7.2.0")
            .Build();
        await kafkaContainer.StartAsync();
        return kafkaContainer;
    }
    
    public static string GetConnectionString(this KafkaContainer kafkaContainer)
    {
        var kafkaBootstrapServers = kafkaContainer.GetBootstrapAddress();
        return $"BootstrapServers={kafkaBootstrapServers}";
    }
}