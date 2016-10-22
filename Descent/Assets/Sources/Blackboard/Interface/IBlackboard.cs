using System;

namespace Descent.Data.Interface
{
    /// <summary>
    /// IBlackboard Interface.
    /// </summary>
    public interface IBlackboard : IGetObject, IGetValue, 
                                   ISetObject, ISetValue { }
}
