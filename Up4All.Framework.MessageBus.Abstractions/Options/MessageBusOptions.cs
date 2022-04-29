namespace Up4All.Framework.MessageBus.Abstractions.Options
{
    public class MessageBusOptions
    {
        public string ConnectionString { get; set; }

        public string QueueName { get; set; }

        public string TopicName { get; set; }

        public string SubscriptionName { get; set; }

        public int ConnectionAttempts { get; set; }

        public MessageBusOptions()
        {
            ConnectionAttempts = 1;
        }

    }
}
