using System;
using System.Collections.Generic;
using System.Text;

namespace Up4All.Framework.MessageBus.Abstractions.Factories
{
    internal class NamedInstanceClient<TClient> where TClient : class
    {
        public string Key { get; set; }

        public Func<IServiceProvider,TClient> Instance { get; set; }
    }
}
