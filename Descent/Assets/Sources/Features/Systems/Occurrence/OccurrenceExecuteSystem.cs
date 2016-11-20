using System;
using Entitas;

/// <summary>
/// Occurrence Execute System.
/// </summary>
public class OccurrenceExecuteSystem : ISetPool, IExecuteSystem
{
    /// <summary>
    /// OnOccurrence Event.
    /// </summary>
    public static event Action<OccurrenceComponent> OnOccurrence;

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
                /* If OnCurrence Event(s). */
                if (OnOccurrence != null) {
                    OnOccurrence.Invoke(e.occurrence);
                }
            }
        }
    }
}
