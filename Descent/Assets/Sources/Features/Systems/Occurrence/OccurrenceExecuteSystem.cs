using System;
using Entitas;
using Descent.Helper;

/// <summary>
/// Occurrence Execute System.
/// </summary>
public class OccurrenceExecuteSystem : ISetPool, IExecuteSystem
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
        /* Log. */
        DescentLogger.Shared.LogSystemInfo(this, "Running System.");

        /* Loop Occurrence Entity(s). */
        foreach (var e in _pool.GetEntities())
        {
            /* Log. */
            DescentLogger.Shared.LogSystemInfo(this, "Checking Entity " + e.creationIndex);

            /* Has Occurrence Component. */
            if (e.hasOccurrence)
            {
                /* Log. */
                DescentLogger.Shared.LogSystemInfo(this, "Occurrence Found, Calling Signal.");

                /* Create Occurrence Signal. */
                Occurrence.Signal.CreateOccurrenceSignal(e.occurrence);
            }
        }
    }
}
