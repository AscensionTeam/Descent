using System;

namespace Descent.Data.Interface
{
    // Created: 22/10/2016 ~ Alexander Hunt.

    /// <summary>
    /// ISetObject Interface.
    /// </summary>
    public interface ISetObject
    {
        /// <summary>
        /// Set Object Method.
        /// </summary>
        /// <param name="Key">Key.</param>
        /// <param name="Value">Value.</param>
        void SetObject(String Key, Object Value);
    }
}