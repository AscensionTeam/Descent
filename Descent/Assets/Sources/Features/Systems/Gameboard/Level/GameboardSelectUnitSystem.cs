using Descent.Helper;
using Entitas;
using UnityEngine;

/// <summary>
/// Select Unit System.
/// </summary>
public class GameboardSelectUnitSystem : ISetPool, IExecuteSystem
{
    /// <summary>
    /// Occurrence Pool.
    /// </summary>
    Pool _pool;

    /// <summary>
    /// Occurrence Component.
    /// </summary>
    OccurrenceComponent _Component = null;

    /// <summary>
    /// Constructor.
    /// </summary>
    public GameboardSelectUnitSystem()
    {
        /* Register OnOccurrence Callback. */
        Occurrence.OnOccurrence += OnOccurrence;
    }

    /// <summary>
    /// Deconstructor.
    /// </summary>
    ~GameboardSelectUnitSystem()
    {
        /* Remove OnOccurrence Callback. */
        Occurrence.OnOccurrence -= OnOccurrence;
    }

    /// <summary>
    /// OnOccurrence Callback Method.
    /// </summary>
    /// <param name="Component">Component.</param>
    private void OnOccurrence(OccurrenceComponent Component)
    {
        /* Occurrence Type Validation. */
        if (Component.Type == "System.Input.MouseMove")
        {
            /* Cache Occurrence Component. */
            _Component = Component;
        }
    }

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
        if (_Component != null)
        {
            Vector3 mousePosition = (Vector3)_Component.Args[0];
            Vector3 pos = Camera.main.ScreenToWorldPoint(mousePosition);

            int X = (int)pos.x;
            int Y = (int)pos.y;


            foreach (var e in _pool.GetEntities())
            {
                if (e.hasPosition)
                {
                    if (e.position.X == X &&
                        e.position.Y == Y &&
                        e.isSelectable)
                    {
                        _pool.ReplaceGameboard(e);
                    }
                }
            }

            _Component = null;
        }
    }
}
