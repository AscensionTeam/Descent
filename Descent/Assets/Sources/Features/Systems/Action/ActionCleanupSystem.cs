using Entitas;

/// <summary>
/// Action Cleanup System.
/// </summary>
public class ActionCleanupSystem : ISetPool, IExecuteSystem
{
    /// <summary>
    /// Action Pool.
    /// </summary>
    Pool _pool;

    /// <summary>
    /// Set Pool Method.
    /// </summary>
    /// <param name="pool">Pool.</param>
    public void SetPool(Pool pool)
    {
        /* Cache Pool. */
        _pool = pool;
    }

    /// <summary>
    /// Execute System Method.
    /// </summary>
    public void Execute()
    {
        /* Loop Action Entity(s). */
        foreach (var e in _pool.GetEntities())
        {
            /* Destory Event Entity. */
            _pool.DestroyEntity(e);
        }
    }
}
