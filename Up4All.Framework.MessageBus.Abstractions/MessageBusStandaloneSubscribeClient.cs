using System;
using System.Threading.Tasks;

using Up4All.Framework.MessageBus.Abstractions.Enums;
using Up4All.Framework.MessageBus.Abstractions.Interfaces;
using Up4All.Framework.MessageBus.Abstractions.Messages;

namespace Up4All.Framework.MessageBus.Abstractions
{
    public abstract class MessageBusStandaloneSubscribeClient : MessageBusStandaloneClientBase, IMessageBusStandaloneConsumer
    {
        protected string ConnectionString { get; private set; }
        protected string TopicName { get; private set; }
        protected string SubscriptionName { get; private set; }

        public MessageBusStandaloneSubscribeClient(string connectionString, string topicName, string subscriptionName)
        {
            ConnectionString = connectionString;
            TopicName = topicName;
            SubscriptionName = subscriptionName;
        }

        public abstract Task RegisterHandlerAsync(Func<ReceivedMessage, Task<MessageReceivedStatusEnum>> handler, Func<Exception, Task> errorHandler, Func<Task> onIdle = null, bool autoComplete = false);

        public abstract void RegisterHandler(Func<ReceivedMessage, MessageReceivedStatusEnum> handler, Action<Exception> errorHandler, Action onIdle = null, bool autoComplete = false);

        public abstract Task Close();
        
    }
}
