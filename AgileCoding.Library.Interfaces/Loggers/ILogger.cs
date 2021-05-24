namespace AgileCoding.Library.Interfaces.Logging
{
    using System;
    using AgileCoding.Library.Enums.Logging;

    public interface ILogger : IDisposable
    {
        bool WriteCore(LogTypeEnum eventType, int eventId, object state, Exception exception, Func<object, Exception, string> formatter = null);
    }
}
