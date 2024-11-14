using Confluent.Kafka;
using Dodo.Kafka.Consumer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace KafkaLesson.Homework;

public class ConsumerHost : IDisposable
{
    private readonly IHost _host;

    public ConsumerHost(string topicName, string kafkaConnectionString)
    {
        _host = new HostBuilder()
            .ConfigureWebHost(webBuilder =>
            {
                webBuilder
                    .UseTestServer()
                    .ConfigureServices((_, services) =>
                    {
                        services
                            .AddScoped<TestConsumer>()
                            .AddTopicSubscription(
                                topic: topicName,
                                baseConfig: new Dodo.Kafka.Consumer.ConsumerConfig
                                {
                                    ConnectionString = kafkaConnectionString
                                },
                                configure: configurator =>
                                {
                                    configurator.GroupId = "Group-1";
                                    configurator.AddConsumer<TestEvent, TestConsumer>();
                                    configurator.AutoOffsetReset = AutoOffsetReset.Earliest;
                                });

                        services.AddRouting();
                    }).Configure(app =>
                    {
                        app.UseRouting();
                    });;
            })
            .Build();
    }

    public Task StartAsync()
    {
        return _host.StartAsync();
    }

    public void Dispose()
    {
        _host.StopAsync();
        _host.Dispose();
    }
}