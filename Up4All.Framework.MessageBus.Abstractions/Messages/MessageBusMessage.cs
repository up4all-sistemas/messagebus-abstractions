using Up4All.Framework.MessageBus.Abstractions.Interfaces;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Up4All.Framework.MessageBus.Abstractions.Messages
{
    public class MessageBusMessage : IMessage
    {
        public byte[] Body { get; private set; }

        public IDictionary<string, object> UserProperties { get; private set; }

        public MessageBusMessage()
        {
            UserProperties = new Dictionary<string, object>();
        }

        public MessageBusMessage(byte[] body) : this()
        {
            Body = body;
        }

        public void AddBody(byte[] data)
        {
            Body = data;
        }

        public void AddBody(string body)
        {
            AddBody(Encoding.UTF8.GetBytes(body));
        }

        public void AddBody<T>(T obj, JsonSerializerSettings opts = null) where T : class
        {
            AddBody(JsonConvert.SerializeObject(obj, opts));
        }

        public void AddUserProperty(KeyValuePair<string, object> prop)
        {
            UserProperties.Add(prop);
        }

        public void AddUserProperties(IDictionary<string, object> props)
        {
            foreach (var prop in props)
                AddUserProperty(prop);
        }
    }
}
