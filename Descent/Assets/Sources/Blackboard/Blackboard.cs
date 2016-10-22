using Descent.Data.Interface;

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
        /// Get Object Method.
        /// </summary>
        /// <param name="Key">Key.</param>
        /// <returns>Object.</returns>
        public object GetObject(string Key)
        {
            /* TODO: Code. */
            throw new NotImplementedException();
        }

        /// <summary>
        /// Set Object Method.
        /// </summary>
        /// <param name="Key">Key.</param>
        /// <param name="Value">Value.</param>
        public void SetObject(string Key, object Value)
        {
            /* TODO: Code. */
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get Value Method.
        /// </summary>
        /// <typeparam name="T">Value Type.</typeparam>
        /// <param name="Key">Key.</param>
        /// <returns>Value.</returns>
        public T GetValue<T>(string Key)
        {
            /* TODO: Code. */
            throw new NotImplementedException();
        }

        /// <summary>
        /// Set Value Method.
        /// </summary>
        /// <typeparam name="T">Value Type.</typeparam>
        /// <param name="Key">Key.</param>
        /// <param name="Value">Value.</param>
        public void SetValue<T>(string Key, T Value)
        {
            /* TODO: Code. */
            throw new NotImplementedException();
        }
    }
}