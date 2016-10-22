using System;

namespace Descent.Data.Interface
{
    // Created: 22/10/2016 ~ Alexander Hunt.

    /// <summary>
    /// IBlackboard Interface.
    /// </summary>
    public interface IBlackboard : IGetObject, IGetValue,
                                   ISetObject, ISetValue { }
}
