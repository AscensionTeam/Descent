using Entitas;
using UnityEngine;

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
        return new Feature("Systems");

            // Example.
            //.Add(pools.<pool>.CreateSystem(new <System>()));
    }
}
