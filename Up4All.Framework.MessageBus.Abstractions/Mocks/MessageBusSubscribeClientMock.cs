using System;
using System.Threading.Tasks;

using Up4All.Framework.MessageBus.Abstractions.Enums;
using Up4All.Framework.MessageBus.Abstractions.Interfaces;
using Up4All.Framework.MessageBus.Abstractions.Messages;

namespace Up4All.Framework.MessageBus.Abstractions.Mocks
{
    public abstract class MessageBusSubscribeClientMock : MessageBusClientBaseMock, IMessageBusConsumer
    {
        public MessageBusSubscribeClientMock() : base()
        {
        }

        public abstract Task RegisterHandlerAsync(Func<ReceivedMessage, Task<MessageReceivedStatusEnum>> handler, Func<Exception, Task> errorHandler, Func<Task> onIdle = null, bool autoComplete = false);

        public abstract void RegisterHandler(Func<ReceivedMessage, MessageReceivedStatusEnum> handler, Action<Exception> errorHandler, Action onIdle = null, bool autoComplete = false);

        public abstract Task Close();
        
    }
}
