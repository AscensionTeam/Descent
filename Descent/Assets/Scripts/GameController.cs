using Entitas;
using UnityEngine;

// Created: 22/10/2016 ~ Alexander Hunt.

/// <summary>
/// Game Controller Class.
/// </summary>
public class GameController : MonoBehaviour {

    Systems _Systems;

    void Start() {

        var pools = Pools.sharedInstance;
        pools.SetAllPools();

        _Systems = CreateSystems(pools);
        _Systems.Initialize();
    }

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
        /* Shutdown Entitas. */
        _Systems.TearDown();
    }

    /// <summary>
    /// Create System(s) Method.
    /// </summary>
    /// <param name="pools">Pools Instance.</param>
    /// <returns>Systems.</returns>
    Systems CreateSystems(Pools pools) {
        /* Create System(s) */
        return new Feature("Systems")

            /* Render */
            .Add(pools.gameboard.CreateSystem(new GameboardRemoveViewSystem()))
            .Add(pools.gameboard.CreateSystem(new GameboardAddViewSystem()))
            .Add(pools.gameboard.CreateSystem(new GameboardUpdateViewPositionSystem()))

            /* Cleanup */
            .Add(pools.action.CreateSystem(new ActionCleanupSystem()));
    }
}
