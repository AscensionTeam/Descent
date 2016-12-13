using System.Collections.Generic;
using UnityEngine;
using Entitas;
using Descent.Helper;

/// <summary>
/// Gameboard Remove View System.
/// </summary>
public sealed class GameboardRemoveViewSystem : ISetPool, IReactiveSystem, IEnsureComponents
{
    /// <summary>
    /// Trigger On Event Property.
    /// </summary>
    public TriggerOnEvent trigger { get { return GameboardMatcher.Asset.OnEntityRemoved(); } }

    public IMatcher ensureComponents { get { return GameboardMatcher.View; } }

    /// <summary>
    /// Set Pool Method.
    /// </summary>
    /// <param name="pool">Pool.</param>
    public void SetPool(Pool pool)
    {
        /* Log. */
        DescentLogger.Shared.LogSystemInfo(this, "Set Pool. ");

        /* Create View Component Group & OnEntityRemoved Callback. */
        pool.GetGroup(GameboardMatcher.View).OnEntityRemoved += onEntityRemoved;

        /* Log. */
        DescentLogger.Shared.LogSystemInfo(this, "Added Group(AllOf(View)).");
    }

    /// <summary>
    /// System Execute Method.
    /// </summary>
    /// <param name="entities">Entities.</param>
    public void Execute(List<Entity> entities)
    {
        /* Log. */
        DescentLogger.Shared.LogSystemInfo(this, "Running System.");

        /* Loop Gameboard Entity(s). */
        foreach (var e in entities)
        {
            /* Log. */
            DescentLogger.Shared.LogSystemInfo(this, "Reming View On Entity " + e.creationIndex);

            /* Remove View Component */
            e.RemoveView();

            /* Log. */
            DescentLogger.Shared.LogSystemInfo(this, "View Removed.");
        }
    }

    /// <summary>
    /// OnEntityRemoved Callback.
    /// </summary>
    /// <param name="group">Group.</param>
    /// <param name="entity">Entity.</param>
    /// <param name="index">Index.</param>
    /// <param name="component">Component.</param>
    void onEntityRemoved(Group group, Entity entity, int index, IComponent component)
    {
        /* Cache View Component. */
        var ViewComponent = (ViewComponent)component;
        /* Cache Unity View Object. */
        var ViewObject = ViewComponent.ViewObject;
        /* Unlink Debugger. */
        ViewObject.Unlink();
        /* Destroy Unity GameObject. */
        Object.Destroy(ViewObject);
    }
}