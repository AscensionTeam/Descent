using System;
using UnityEngine;

namespace Descent.Helper
{
    public enum LogLevel {None, Info };

    /// <summary>
    /// Logger Class.
    /// </summary>
    public class Logger : ILogger
    {
        /// <summary>
        /// Shared Logger Instance.
        /// </summary>
        private static Logger _Shared;

        /// <summary>
        /// Log Level.
        /// </summary>
        private LogLevel _LogLevel;

        /// <summary>
        /// Shared Logger Property.
        /// </summary>
        public static Logger Shared
        {
            get
            {
                /* Initialize Logger. */
                if (_Shared == null) {
                    _Shared = new Logger();
                }

                /* Return Logger. */
                return _Shared;
            }
        }

        /// <summary>
        /// Log Method.
        /// </summary>
        /// <param name="Message">Message.</param>
        public void Log(object Message)
        {
            Debug.Log(Message);
        }

        /// <summary>
        /// Log Warning Method.
        /// </summary>
        /// <param name="Message">Message.</param>
        public void LogWarning(object Message)
        {
            Debug.LogWarning(Message);
        }

        /// <summary>
        /// Log Error Method.
        /// </summary>
        /// <param name="Message">Message.</param>
        public void LogError(object Message)
        {
            Debug.LogError(Message);
        }

        /// <summary>
        /// Log System Method.
        /// </summary>
        /// <param name="Sender">Sender.</param>
        /// <param name="Message">Message.</param>
        public void LogSystem(object Sender, object Message)
        {
            Debug.Log("[System][" + DateTime.Now + "] " + Sender.ToString() + ": " + Message);
        }
    }
}
