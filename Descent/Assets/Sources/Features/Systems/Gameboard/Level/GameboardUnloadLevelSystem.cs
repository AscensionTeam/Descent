using Entitas;
using Descent.Data;
using Descent.Helper;

// Created: 20/11/2016 ~ Alexander Hunt.

/// <summary>
/// Gameboard Unload Level System.
/// </summary>
public class GameboardUnloadLevelSystem : IExecuteSystem, ISetPool
{
    /// <summary>
    /// Gameboard Pool.
    /// </summary>
    Pool _pool;

    /* Occurrence Component. */
    OccurrenceComponent _Component = null;

    /// <summary>
    /// Constructor.
    /// </summary>
    public GameboardUnloadLevelSystem()
    {
        /* Register OnOccurrence Callback. */
        Occurrence.OnOccurrence += OnOccurrence;
    }

    /// <summary>
    /// Deconstructor.
    /// </summary>
    ~GameboardUnloadLevelSystem()
    {
        /* Remove OnOccurrence Callback. */
        Occurrence.OnOccurrence -= OnOccurrence;
    }

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
    /// OnOccurrence Callback Method.
    /// </summary>
    /// <param name="Component">Component.</param>
    private void OnOccurrence(OccurrenceComponent Component)
    {
        /* Occurrence Type Validation. */
        if (Component.Type == OccurrenceType.Level.UnloadLevel) {

            /* Cache Occurrence Component. */
            _Component = Component;
        }
    }

    /// <summary>
    /// System Execute Method.
    /// </summary>
    public void Execute()
    {
        if (_Component != null)
        {
            /* Unload Level. */
            UnloadLevel();

            /* Cleanup Component. */
            _Component = null;
        }
    }

    /// <summary>
    /// Unload Level Method.
    /// </summary>
    private void UnloadLevel()
    {
        /* Loop Gameboard Entity(s). */
        foreach (var e in _pool.GetEntities())
        {
            /* Destory Entity. */
            _pool.DestroyEntity(e);
        }

        if (_pool.count == 0)
        {
            /* Invoke Signal. */
            Occurrence.Level.Signal.CreateLevelUnloadedSignal(Blackboard.Shared.GetValue<string>("TileMapTitle"));
        }

        /* Remove Cached Map. */
        Blackboard.Shared.SetObject("TileMap", null);
        Blackboard.Shared.SetObject("TileMapTitle", null);
    }
}
