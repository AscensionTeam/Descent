using Descent.Helper;
using Entitas;

/// <summary>
/// Occurrence Cleanup System.
/// </summary>
public class OccurrenceCleanupSystem : ISetPool, IExecuteSystem
{
    /// <summary>
    /// Occurrence Pool.
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
        Logger.Shared.LogSystemInfo(this, "Running Cleanup. ");

        /* Loop Action Entity(s). */
        foreach (var e in _pool.GetEntities())
        {
            /* Destory Event Entity. */
            _pool.DestroyEntity(e);
        }
    }
}
