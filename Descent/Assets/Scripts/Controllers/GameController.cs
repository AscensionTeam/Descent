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

        /* Initialize Pool(s). */
        var pools = Pools.sharedInstance;
        pools.SetAllPools();

        /* Configure Log Level. */
        Descent.Helper.DescentLogger.Shared.LogLevel = LogLevel.None;

        /* Initialize System(s). */
        _Systems = CreateSystems(pools);
        _Systems.Initialize();

        //TestGame();
    }

    void TestGame()
    {
        Occurrence.Level.LoadLevel("FirstBlood");

        Occurrence.Level.AddCharacter("Mick", 0);
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
            .Add(pools.gameboard.CreateSystem(new GameboardAddCharacterSystem()))

            /* Render */
            .Add(pools.gameboard.CreateSystem(new GameboardRemoveViewSystem()))
            .Add(pools.gameboard.CreateSystem(new GameboardAddViewSystem()))
            .Add(pools.gameboard.CreateSystem(new GameboardUpdateViewPositionSystem()));
    }
}
