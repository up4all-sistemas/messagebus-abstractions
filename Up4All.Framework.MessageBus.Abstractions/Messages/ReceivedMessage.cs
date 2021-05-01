using Up4All.Framework.MessageBus.Abstractions.Interfaces;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Text;

namespace Up4All.Framework.MessageBus.Abstractions.Messages
{
    public class ReceivedMessage : MessageBusMessage
    {
        public string GetBody()
        {
            return Encoding.UTF8.GetString(Body);
        }

        public T GetBody<T>(JsonSerializerSettings opts = null) where T : class
        {
            return JsonConvert.DeserializeObject<T>(GetBody(), opts);
        }
    }
}
