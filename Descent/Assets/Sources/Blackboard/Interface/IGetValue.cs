using System;

namespace Descent.Data.Interface
{
    // Created: 22/10/2016 ~ Alexander Hunt.

    /// <summary>
    /// IGetValue Interface.
    /// </summary>
    public interface IGetValue
    {
        /// <summary>
        /// Get Value Method.
        /// </summary>
        /// <typeparam name="T">Value Type.</typeparam>
        /// <param name="Key">Key.</param>
        /// <returns>Value.</returns>
        T GetValue<T>(String Key);
    }
}