using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Text;

namespace Up4All.Framework.MessageBus.Abstractions.Interfaces
{
    public interface IMessage
    {
        byte[] Body { get; }

        IDictionary<string, object> UserProperties { get; }

        void AddBody(byte[] body);

        void AddBody(string body);

        void AddBody<T>(T obj, JsonSerializerSettings opts = null) where T: class;

        void AddUserProperty(KeyValuePair<string, object> prop);

        void AddUserProperties(IDictionary<string, object> props);
    }
}
