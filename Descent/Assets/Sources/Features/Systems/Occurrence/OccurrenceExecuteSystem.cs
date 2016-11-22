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
        /* Loop Occurrence Entity(s). */
        foreach (var e in _pool.GetEntities())
        {
            /* Has Occurrence Component. */
            if (e.hasOccurrence)
            {
                /* Create Occurrence Signal. */
                Occurrence.CreateOccurrenceSignal(e.occurrence);
            }
        }
    }
}
