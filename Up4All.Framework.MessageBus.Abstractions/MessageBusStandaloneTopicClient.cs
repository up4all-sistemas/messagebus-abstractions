
using System.Collections.Generic;
using System.Threading.Tasks;

using Up4All.Framework.MessageBus.Abstractions.Interfaces;
using Up4All.Framework.MessageBus.Abstractions.Messages;

namespace Up4All.Framework.MessageBus.Abstractions
{
    public abstract class MessageBusStandaloneTopicClient : MessageBusStandaloneClientBase, IMessageBusStandalonePublisher
    {
        protected string ConnectionString { get; private set; }
        protected string TopicName { get; private set; }

        public MessageBusStandaloneTopicClient(string connectionString, string topicName)
        {
            ConnectionString = connectionString;
            TopicName = topicName;
        }

        public abstract Task Send(MessageBusMessage message);

        public abstract Task Send(IEnumerable<MessageBusMessage> messages);
    }
}
