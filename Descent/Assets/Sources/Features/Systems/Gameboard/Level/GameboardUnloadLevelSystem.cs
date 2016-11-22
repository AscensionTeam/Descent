using Entitas;
using Descent.Data;
using Descent.Helper;

// Created: 20/11/2016 ~ Alexander Hunt.

/// <summary>
/// Gameboard Unload Level System.
/// </summary>
public class GameboardUnloadLevelSystem : IInitializeSystem, IExecuteSystem
{
    /* Occurrence Component. */
    OccurrenceComponent _Component = null;

    /// <summary>
    /// Initialize Method.
    /// </summary>
    public void Initialize()
    {
        /* Register OnOccurrence Callback. */
        Occurrence.OnOccurrence += OnOccurrence;
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
        foreach (var e in Pools.sharedInstance.gameboard.GetEntities())
        {
            /* Destory Entity. */
            Pools.sharedInstance.gameboard.DestroyEntity(e);
        }

        /* Remove Cached Map. */
        Blackboard.Shared.SetObject("TileMap", null);
    }
}
