using Microsoft.Extensions.Options;

using System.Collections.Generic;
using System.Threading.Tasks;

using Up4All.Framework.MessageBus.Abstractions.Interfaces;
using Up4All.Framework.MessageBus.Abstractions.Messages;
using Up4All.Framework.MessageBus.Abstractions.Options;

namespace Up4All.Framework.MessageBus.Abstractions
{
    public abstract class MessageBusTopicClient : MessageBusClientBase, IMessageBusPublisher
    {
        public MessageBusTopicClient(IOptions<MessageBusOptions> messageOptions) : base(messageOptions)
        {
        }

        public abstract Task Send(MessageBusMessage message);

        public abstract Task Send(IEnumerable<MessageBusMessage> messages);
    }
}
