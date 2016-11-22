using Descent.Data.Interface;
using System.Collections.Generic;
using System;

namespace Descent.Data
{
    // Created: 22/10/2016 ~ Alexander Hunt.

    /// <summary>
    /// Blackboard Class.
    /// </summary>
    public class Blackboard : IBlackboard
    {
        /// <summary>
        /// Shared Blackboard Instance.
        /// </summary>
        private static Blackboard _Shared = new Blackboard();

        /// <summary>
        /// Shared Blackboard Property.
        /// </summary>
        public static Blackboard Shared
        {
            get
            {
                /* Initialize Blackboard. */
                if (_Shared == null) {
                    _Shared = new Blackboard();
                }

                /* Return Blackboard. */
                return _Shared;
            }
        }

        /// <summary>
        /// Blackboard Value(s).
        /// </summary>
        private Dictionary<String, Object> _Blackboard;

        /// <summary>
        /// Blackboard Constructor.
        /// </summary>
        public Blackboard()
        {
            /* Create Dictionary */
            _Blackboard = new Dictionary<String, Object>();
        }

        /// <summary>
        /// Get Object Method.
        /// </summary>
        /// <param name="Key">Key.</param>
        /// <returns>Object.</returns>
        public object GetObject(string Key)
        {
            return (_Blackboard.ContainsKey(Key)) ? _Blackboard[Key] : null;
        }

        /// <summary>
        /// Set Object Method.
        /// </summary>
        /// <param name="Key">Key.</param>
        /// <param name="Value">Value.</param>
        public void SetObject(string Key, object Value)
        {
            _Blackboard[Key] = Value;
        }

        /// <summary>
        /// Get Value Method.
        /// </summary>
        /// <typeparam name="T">Value Type.</typeparam>
        /// <param name="Key">Key.</param>
        /// <returns>Value.</returns>
        public T GetValue<T>(string Key)
        {
            return (_Blackboard.ContainsKey(Key)) ? (T)_Blackboard[Key] : default(T);
        }

        /// <summary>
        /// Set Value Method.
        /// </summary>
        /// <typeparam name="T">Value Type.</typeparam>
        /// <param name="Key">Key.</param>
        /// <param name="Value">Value.</param>
        public void SetValue<T>(string Key, T Value)
        {
            _Blackboard[Key] = Value;
        }
    }
}