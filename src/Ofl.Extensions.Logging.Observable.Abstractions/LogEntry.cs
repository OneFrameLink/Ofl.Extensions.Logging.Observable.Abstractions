using System;
using Microsoft.Extensions.Logging;

namespace Ofl.Extensions.Logging.Observable
{
    public class LogEntry
    {
        #region Constructor

        public LogEntry(LogLevel logLevel, EventId eventId, string category, object state, 
            Exception exception, string formattedMessage)
        {
            // No validation needed, not sure what is passed, so make no assumptions, for now.

            // Set values.
            LogLevel = logLevel;
            Category = category;
            EventId = eventId;
            State = state;
            Exception = exception;
            FormattedMessage = formattedMessage;
        }

        #endregion

        #region Instance, read-only state.

        public LogLevel LogLevel { get; }

        public EventId EventId { get; }

        public string Category { get; }

        public object State { get; }

        public Exception Exception { get; }

        public string FormattedMessage { get; }

        #endregion
    }
}
