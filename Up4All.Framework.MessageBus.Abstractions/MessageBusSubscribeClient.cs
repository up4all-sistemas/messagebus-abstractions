﻿using Up4All.Framework.MessageBus.Abstractions.Enums;
using Up4All.Framework.MessageBus.Abstractions.Interfaces;
using Up4All.Framework.MessageBus.Abstractions.Messages;
using Up4All.Framework.MessageBus.Abstractions.Options;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Up4All.Framework.MessageBus.Abstractions
{
    public abstract class MessageBusSubscribeClient : MessageBusClientBase, IMessageBusConsumer
    {
        public MessageBusSubscribeClient(IOptions<MessageBusOptions> messageBusOptions) : base(messageBusOptions)
        {
        }

        public abstract void RegisterHandler(Func<ReceivedMessage, MessageReceivedStatusEnum> handler, Action<Exception> errorHandler, Action onIdle = null, bool autoComplete = false);

        public abstract Task Close();
        
    }
}
