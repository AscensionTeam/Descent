using System;
using UnityEngine;

namespace Descent.Helper
{
    public enum LogLevel {None, Info, Warning, Error, Fatal};

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
        /// Log Level Property.
        /// </summary>
        public LogLevel LogLevel
        {
            get
            {
                /* Return Log Level. */
                return _LogLevel;
            }
            set
            {
                /* Set Log Level. */
                _LogLevel = value;
            }
        }

        /// <summary>
        /// Logger Constructor.
        /// </summary>
        public Logger()
        {
            /* Initialize Log Level. */
            _LogLevel = LogLevel.Fatal;
        }

        /// <summary>
        /// Log Method.
        /// </summary>
        /// <param name="Message">Message.</param>
        public void LogInfo(object Message)
        {
            if (_LogLevel > LogLevel.None)
            {
                /* Write To Console. */
                Debug.Log(Message);
            }
        }

        /// <summary>
        /// Log Warning Method.
        /// </summary>
        /// <param name="Message">Message.</param>
        public void LogWarning(object Message)
        {
            if (_LogLevel > LogLevel.Info)
            {
                /* Write To Console. */
                Debug.LogWarning(Message);
            }
        }

        /// <summary>
        /// Log Error Method.
        /// </summary>
        /// <param name="Message">Message.</param>
        public void LogError(object Message)
        {
            if (_LogLevel > LogLevel.Warning)
            {
                /* Write To Console. */
                Debug.LogError(Message);
            }
        }

        /// <summary>
        /// Log System Info Method.
        /// </summary>
        /// <param name="Sender">Sender.</param>
        /// <param name="Message">Message.</param>
        public void LogSystemInfo(object Sender, object Message)
        {
            if (_LogLevel > LogLevel.None)
            {
                /* Write To Console. */
                Debug.Log("[SYSTEM (INFO)][" + DateTime.Now + "] " + Sender.ToString() + ": " + Message);
            }
        }
    }
}
