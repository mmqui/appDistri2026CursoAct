namespace app.clientesChGio.services.EventMQ
{
    public interface IRabbitMQService
    {
        Task PublishMessage<T>(T message, string queueName);
    }
}
