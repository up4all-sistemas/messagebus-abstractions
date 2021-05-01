using Up4All.Framework.MessageBus.Abstractions.Messages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Up4All.Framework.MessageBus.Abstractions.Interfaces
{
    public interface IMessageBusPublisher
    {
        Task Send(MessageBusMessage message);

        Task Send(IEnumerable<MessageBusMessage> messages);
    }
}
