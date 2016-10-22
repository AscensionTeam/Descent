using Entitas;

using System.Collections.Generic;

using UnityEngine;

/// <summary>
/// Gameboard Remove View System.
/// </summary>
public sealed class GameboardRemoveViewSystem : ISetPool, IReactiveSystem, IEnsureComponents
{
    public TriggerOnEvent trigger { get { return GameboardMatcher.Asset.OnEntityRemoved(); } }

    public IMatcher ensureComponents { get { return GameboardMatcher.View; } }

    public void SetPool(Pool pool)
    {
        pool.GetGroup(GameboardMatcher.View).OnEntityRemoved += onEntityRemoved;
    }

    public void Execute(List<Entity> entities)
    {
        foreach (var e in entities)
        {
            e.RemoveView();
        }
    }

    void onEntityRemoved(Group group, Entity entity, int index, IComponent component)
    {
        var ViewComponent = (ViewComponent)component;
        var ViewObject = ViewComponent.ViewObject;
        ViewObject.Unlink();
        Object.Destroy(ViewObject);
    }
}