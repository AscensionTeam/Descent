using System;

namespace Descent.Data.Interface
{
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