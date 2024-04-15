using Confluent.Kafka;

namespace lab_1.Services;

public class CommentsProducer:IDisposable
{
    private IProducer<Null,string> _producer;
    
    public CommentsProducer()
    {
        var producerconfig = new ProducerConfig
        {
            BootstrapServers = "localhost:9092"
        };
        _producer = new ProducerBuilder<Null, string>(producerconfig).Build();
    }
    
    public void Produce(string topic, string message)
    {
        var kafkamessage = new Message<Null, string> { Value = message, };

        _producer.Produce(topic, kafkamessage);
    }

    public void Dispose()
    {
        _producer.Dispose();
    }
}