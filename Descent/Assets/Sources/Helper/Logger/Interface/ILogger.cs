using System;

namespace Descent.Helper
{
    /// <summary>
    /// ILogger Interface.
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Log Info Method.
        /// </summary>
        /// <param name="Message">Message.</param>
        void LogInfo(object Message);

        /// <summary>
        /// Log Warning Method.
        /// </summary>
        /// <param name="Message">Message.</param>
        void LogWarning(object Message);

        /// <summary>
        /// Log Error Method.
        /// </summary>
        /// <param name="Message">Message.</param>
        void LogError(object Message);

        /// <summary>
        /// Log System Info Method.
        /// </summary>
        /// <param name="Sender">Sender.</param>
        /// <param name="Message">Message.</param>
        void LogSystemInfo(object Sender, object Message);

        /// <summary>
        /// Log System Warning Method.
        /// </summary>
        /// <param name="Sender">Sender.</param>
        /// <param name="Message">Message.</param>
        void LogSystemWarning(object Sender, object Message);
    }
}