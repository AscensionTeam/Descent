using Entitas;
using UnityEngine;
using Descent.Helper;

// Created: 22/10/2016 ~ Alexander Hunt.

/// <summary>
/// Game Controller Class.
/// </summary>
public class GameController : MonoBehaviour {

    /// <summary>
    /// Systems.
    /// </summary>
    Systems _Systems;

    /// <summary>
    /// Start Method.
    /// </summary>
    void Start() {

        var pools = Pools.sharedInstance;
        pools.SetAllPools();

        _Systems = CreateSystems(pools);
        _Systems.Initialize();
    }

    /// <summary>
    /// Update Method.
    /// </summary>
    void Update() {
        
        /* Execute System(s) */
        _Systems.Execute();

        /* Cleanup System(s) */
        _Systems.Cleanup();
    }

    /// <summary>
    /// On Controller Destoryed.
    /// </summary>
    void OnDestroy() {

        if (_Systems != null)
        {
            /* Shutdown Entitas. */
            _Systems.TearDown();
        }
    }

    /// <summary>
    /// Create System(s) Method.
    /// </summary>
    /// <param name="pools">Pools Instance.</param>
    /// <returns>Systems.</returns>
    Systems CreateSystems(Pools pools) {
        /* Create System(s) */
        return new Feature("Systems")

            /* Occurrence */
            .Add(pools.occurrence.CreateSystem(new OccurrenceExecuteSystem()))
            .Add(pools.occurrence.CreateSystem(new OccurrenceCleanupSystem()))

            /* Level */
            .Add(pools.gameboard.CreateSystem(new GameboardUnloadLevelSystem()))
            .Add(pools.gameboard.CreateSystem(new GameboardLoadLevelSystem()))
            .Add(pools.gameboard.CreateSystem(new GameboardCenterMapPositionSystem()))

            /* Render */
            .Add(pools.gameboard.CreateSystem(new GameboardRemoveViewSystem()))
            .Add(pools.gameboard.CreateSystem(new GameboardAddViewSystem()))
            .Add(pools.gameboard.CreateSystem(new GameboardUpdateViewPositionSystem()));
    }
}
