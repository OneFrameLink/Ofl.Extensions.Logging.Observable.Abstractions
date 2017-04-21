using System;

namespace Ofl.Extensions.Logging.Observable
{
    public interface ILogObservableFactory
    {
        IObservable<LogEntry> Create();
    }
}
