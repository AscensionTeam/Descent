using Entitas;

/// <summary>
/// Action Cleanup System.
/// </summary>
public class ActionCleanupSystem : ISetPools, IExecuteSystem
{
    /// <summary>
    /// Action Pool.
    /// </summary>
    Pool _action;

    /// <summary>
    /// Set Pools Method.
    /// </summary>
    /// <param name="pools">Pools.</param>
    public void SetPools(Pools pools)
    {
        /* Cache Pool. */
        _action = pools.action;
    }

    /// <summary>
    /// Execute System Method.
    /// </summary>
    public void Execute()
    {
        /* Loop Action Entity(s). */
        foreach (var e in _action.GetEntities())
        {
            /* Destory Event Entity. */
            _action.DestroyEntity(e);
        }
    }
}
