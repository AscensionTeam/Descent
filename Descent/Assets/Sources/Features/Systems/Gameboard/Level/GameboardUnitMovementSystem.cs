using Descent.Helper;
using Entitas;
using UnityEngine;

/// <summary>
/// Gameboard Unit Movement System
/// </summary>
public class GameboardUnitMovementSystem : ISetPool, IExecuteSystem
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
    public GameboardUnitMovementSystem()
    {
        /* Register OnOccurrence Callback. */
        Occurrence.OnOccurrence += OnOccurrence;
    }

    /// <summary>
    /// Deconstructor.
    /// </summary>
    ~GameboardUnitMovementSystem()
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
        if (Component.Type == "System.Input.Key")
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
            string Key = (string)_Component.Args[0];

            if (_pool.hasGameboard && _pool.gameboard.SelectedUnit != null)
            {
                Entity e = _pool.gameboard.SelectedUnit;

                int[] MoveTo = GetXYFromKey(Key, e.position.X, e.position.Y);

                if (e.movementCost.Cost > 0)
                {
                    foreach (var tile in _pool.GetEntities())
                    {
                        if (tile.hasPosition &&
                            tile.position.X == MoveTo[0] &&
                            tile.position.Y == MoveTo[1])
                        {
                            e.ReplacePosition(tile.position.X, tile.position.Y, -1);
                        }
                    }
                    e.movementCost.Cost--;
                }
            }

            _Component = null;
        }
    }

    int[] GetXYFromKey(string key, int x, int y)
    {
        int[] val = { 0, 0 };

        switch (key)
        {
            case "w":
            case "W": return new int[] { x, y + 1 };
            case "a":
            case "A": return new int[] { x - 1, y };
            case "s":
            case "S": return new int[] { x, y - 1 };
            case "d":
            case "D": return new int[] { x + 1, y };
        }

        return val;
    }
}
