using System;
using System.Collections.Generic;

namespace Ofl.Extensions.Logging.Observable
{
    public interface ILogObserverStore : IEnumerable<IObserver<LogEntry>>
    {
        IDisposable Add(IObserver<LogEntry> observer);
    }
}
