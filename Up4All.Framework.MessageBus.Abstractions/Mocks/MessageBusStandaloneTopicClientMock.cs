
using System.Collections.Generic;
using System.Threading.Tasks;

using Up4All.Framework.MessageBus.Abstractions.Interfaces;
using Up4All.Framework.MessageBus.Abstractions.Messages;

namespace Up4All.Framework.MessageBus.Abstractions.Mocks
{
    public abstract class MessageBusStandaloneTopicClientMock : MessageBusClientBaseMock, IMessageBusStandalonePublisher
    {
        public MessageBusStandaloneTopicClientMock() : base()
        {
        }

        public abstract Task Send(MessageBusMessage message);

        public abstract Task Send(IEnumerable<MessageBusMessage> messages);
    }
}
