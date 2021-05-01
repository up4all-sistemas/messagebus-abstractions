using System;
using System.Collections.Generic;
using System.Text;

namespace Up4All.Framework.MessageBus.Abstractions.Options
{
    public class MessageBusOptions
    {
        public string ConnectionString { get; set; }

        public string QueueName { get; set; }

        public string TopicName { get; set; }

        public string SubscriptionName { get; set; }

        
    }
}
