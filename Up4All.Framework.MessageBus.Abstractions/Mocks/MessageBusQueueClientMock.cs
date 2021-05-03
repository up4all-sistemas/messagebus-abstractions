using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Up4All.Framework.MessageBus.Abstractions.Enums;
using Up4All.Framework.MessageBus.Abstractions.Interfaces;
using Up4All.Framework.MessageBus.Abstractions.Messages;

namespace Up4All.Framework.MessageBus.Abstractions.Mocks
{
    public abstract class MessageBusQueueClientMock : MessageBusClientBaseMock, IMessageBusQueueClient
    {
        public MessageBusQueueClientMock() : base()
        {
        }

        public abstract void RegisterHandler(Func<ReceivedMessage, MessageReceivedStatusEnum> handler, Action<Exception> errorHandler, Action onIdle = null, bool autoComplete = false);

        public abstract Task Send(MessageBusMessage message);

        public abstract Task Send(IEnumerable<MessageBusMessage> messages);

        public abstract Task Close();
    }
}
