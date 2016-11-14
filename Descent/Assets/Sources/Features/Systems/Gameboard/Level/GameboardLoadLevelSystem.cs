using Descent.Helper;
using Entitas;

using System;

// Created: 14/11/2016 ~ Alexander Hunt.

/// <summary>
/// Gameboard Load Level System.
/// </summary>
public class GameboardLoadLevelSystem : IInitializeSystem, IExecuteSystem
{
    /// <summary>
    /// Action Component.
    /// </summary>
    private ActionComponent Action = null;

    /// <summary>
    /// Initialize Method.
    /// </summary>
    public void Initialize()
    {
        /* Create Action Pool OnEntityCreated Callback. */
        Pools.sharedInstance.action.OnEntityCreated += OnActionCreated;
    }

    /// <summary>
    /// On Action Created.
    /// </summary>
    /// <param name="pool">Pool.</param>
    /// <param name="entity">Entity.</param>
    private void OnActionCreated(Pool pool, Entity entity)
    {
        /* Entity Has Action Component? */
        if (entity.hasAction) {
            /* Is Action A LoadLevel Event? */
            if (entity.action.Type == ActionType.LoadLevel) {
                /* Cache Action Component. */
                Action = entity.action;
            }
        }
    }

    /// <summary>
    /// System Execute Method.
    /// </summary>
    public void Execute()
    {
        if (Action != null)
        {
            // TODO: Implement (Load Level & Spawn Level Entity(s))

            Action = null;
        }
    }
}
