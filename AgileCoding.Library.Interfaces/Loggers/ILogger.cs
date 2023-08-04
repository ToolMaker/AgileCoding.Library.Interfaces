namespace AgileCoding.Library.Interfaces.Logging
{
    using System;
    using System.Collections.Generic;
    using AgileCoding.Library.Enums.Logging;

    public interface ILogger : IDisposable
    {
        bool WriteCore(LogTypeEnum eventType, int eventId, object? state, Exception? exception, Func<object, Exception, string>? formatter = null);

        /// <summary>
        /// Write core operation. Please use AgileCoding.Extentions.Loggers to have more spesfic Methods for easy error, informaitonal etc logging
        /// </summary>
        /// <param name="eventType">Type of event</param>
        /// <param name="eventId">Event Id</param>
        /// <param name="state"></param>
        /// <param name="exception">Exception</param>
        /// <param name="parameters">Filtering or selection parameters</param>
        /// <param name="formatter">message formater</param>
        /// <returns></returns>
        bool WriteCore(LogTypeEnum eventType, int eventId, object? state, Exception? exception, Dictionary<string, string>? parameters, Func<object, Exception, string>? formatter = null);
    }
}
