using Up4All.Framework.MessageBus.Abstractions.Enums;
using Up4All.Framework.MessageBus.Abstractions.Messages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Up4All.Framework.MessageBus.Abstractions.Interfaces
{
    public interface IMessageBusConsumer
    {

        Task RegisterHandlerAsync(Func<ReceivedMessage, Task<MessageReceivedStatusEnum>> handler, Func<Exception,Task> errorHandler, Func<Task> onIdle = null, bool autoComplete = false);

        void RegisterHandler(Func<ReceivedMessage, MessageReceivedStatusEnum> handler, Action<Exception> errorHandler, Action onIdle = null, bool autoComplete = false);

        Task Close();
    }
}
