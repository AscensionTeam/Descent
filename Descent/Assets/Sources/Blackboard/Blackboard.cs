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
        /// Blackboard Shared Instance.
        /// </summary>
        public static Blackboard Shared = new Blackboard();
        
        /// <summary>
        /// Blackboard Value(s).
        /// </summary>
        private Dictionary<String, Object> Values;

        /// <summary>
        /// Get Object Method.
        /// </summary>
        /// <param name="Key">Key.</param>
        /// <returns>Object.</returns>
        public object GetObject(string Key)
        {
            return Values[Key];
        }

        /// <summary>
        /// Set Object Method.
        /// </summary>
        /// <param name="Key">Key.</param>
        /// <param name="Value">Value.</param>
        public void SetObject(string Key, object Value)
        {
           Values[Key] = Value;
        }

        /// <summary>
        /// Get Value Method.
        /// </summary>
        /// <typeparam name="T">Value Type.</typeparam>
        /// <param name="Key">Key.</param>
        /// <returns>Value.</returns>
        public T GetValue<T>(string Key)
        {
            return (T)Values[Key];
        }

        /// <summary>
        /// Set Value Method.
        /// </summary>
        /// <typeparam name="T">Value Type.</typeparam>
        /// <param name="Key">Key.</param>
        /// <param name="Value">Value.</param>
        public void SetValue<T>(string Key, T Value)
        {
            Values[Key] = Value;
        }
    }
}