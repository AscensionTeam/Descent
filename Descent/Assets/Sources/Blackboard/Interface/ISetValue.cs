using System;

namespace Descent.Data.Interface
{
    /// <summary>
    /// ISetValue Interface.
    /// </summary>
    public interface ISetValue
    {
        /// <summary>
        /// Set Value Method.
        /// </summary>
        /// <typeparam name="T">Value Type.</typeparam>
        /// <param name="Key">Key.</param>
        /// <param name="Value">Value.</param>
        void SetValue<T>(String Key, T Value);
    }
}