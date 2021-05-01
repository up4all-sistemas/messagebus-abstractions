using Up4All.Framework.MessageBus.Abstractions.Options;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace Up4All.Framework.MessageBus.Abstractions
{
    public abstract class MessageBusClientBase
    {
        protected readonly MessageBusOptions MessageBusOptions;

        public MessageBusClientBase(IOptions<MessageBusOptions> messageBusOptions)
        {
            MessageBusOptions = messageBusOptions.Value;
        }
    }
}
