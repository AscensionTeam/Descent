using System;

namespace Descent.Helper
{
    /// <summary>
    /// ILogger Interface.
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Log Message Method.
        /// </summary>
        /// <param name="Message">Message.</param>
        void Log(object Message);

        /// <summary>
        /// Log Warning Message Method.
        /// </summary>
        /// <param name="Message">Message.</param>
        void LogWarning(object Message);

        /// <summary>
        /// Log Error Message Method.
        /// </summary>
        /// <param name="Message">Message.</param>
        void LogError(object Message);

        /// <summary>
        /// Log System Method.
        /// </summary>
        /// <param name="Sender">Sender.</param>
        /// <param name="Message">Message.</param>
        void LogSystem(object Sender, object Message);
    }
}