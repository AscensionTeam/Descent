using Entitas;

/// <summary>
/// Action Cleanup System.
/// </summary>
public class ActionCleanupSystem : ISetPools, IExecuteSystem
{
    Pool _action;

    public void SetPools(Pools pools)
    {
        _action = pools.action;
    }

    public void Execute()
    {
        foreach (var e in _action.GetEntities())
        {
            _action.DestroyEntity(e);
        }
    }
}
