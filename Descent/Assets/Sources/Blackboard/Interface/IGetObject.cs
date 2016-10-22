using System;

namespace Descent.Data.Interface
{
    // Created: 22/10/2016 ~ Alexander Hunt.

    /// <summary>
    /// IGetObject Interface.
    /// </summary>
    public interface IGetObject
    {
        /// <summary>
        /// Get Object Method.
        /// </summary>
        /// <param name="Key">Key.</param>
        /// <returns>Object.</returns>
        Object GetObject(String Key);
    }
}