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
        /* Log. */
        DescentLogger.Shared.LogSystemInfo(this, "Set Pool. ");

        /* Cache Pool. */
        _pool = pool;
    }

    /// <summary>
    /// Execute System Method.
    /// </summary>
    public void Execute()
    {
        /* Log. */
        DescentLogger.Shared.LogSystemInfo(this, "Running Cleanup. ");

        /* Loop Action Entity(s). */
        foreach (var e in _pool.GetEntities())
        {
            /* Log. */
            DescentLogger.Shared.LogSystemInfo(this, "Deleteing Entity " + e.creationIndex);

            /* Destory Event Entity. */
            _pool.DestroyEntity(e);
        }
        /* Log. */
        DescentLogger.Shared.LogSystemInfo(this, "Cleanup Complete. ");
    }
}
