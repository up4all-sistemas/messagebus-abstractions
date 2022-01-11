using Microsoft.Extensions.DependencyInjection;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Up4All.Framework.MessageBus.Abstractions.Interfaces;

namespace Up4All.Framework.MessageBus.Abstractions.Factories
{
    public class MessageBusFactory
    {
        private readonly IServiceProvider _provider;

        public MessageBusFactory(IServiceProvider provider)
        {
            _provider = provider;
        }

        public IMessageBusStandaloneQueueClient GetQueueClient(string key)
        {
            var namedInstances = _provider.GetServices<NamedInstanceClient<IMessageBusStandaloneQueueClient>>();
            return namedInstances.FirstOrDefault(x => x.Key == key)?.Instance.Invoke(_provider);

        }

        public IMessageBusStandalonePublisher GetTopicClient(string key)
        {
            var namedInstances = _provider.GetServices<NamedInstanceClient<IMessageBusStandalonePublisher>>();
            return namedInstances.FirstOrDefault(x => x.Key == key)?.Instance.Invoke(_provider);

        }

        public IMessageBusStandaloneConsumer GetSubscriptionClient(string key)
        {
            var namedInstances = _provider.GetServices<NamedInstanceClient<IMessageBusStandaloneConsumer>>();
            return namedInstances.FirstOrDefault(x => x.Key == key)?.Instance.Invoke(_provider);

        }
    }
}
