using System;
using System.Collections.Generic;
using System.Text;

namespace Up4All.Framework.MessageBus.Abstractions.Enums
{
    public enum MessageReceivedStatusEnum
    {
        Completed,
        Abandoned,
        Deadletter
    }
}
