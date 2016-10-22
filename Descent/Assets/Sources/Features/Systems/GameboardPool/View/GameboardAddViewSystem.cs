using System;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

/// <summary>
/// Gameboard Add View System.
/// </summary>
public sealed class GameboardAddViewSystem : ISetPool, IReactiveSystem
{

    public TriggerOnEvent trigger { get { return GameboardMatcher.Asset.OnEntityAdded(); } }

    readonly Transform _viewContainer = new GameObject("Views").transform;

    Pool _pool;

    public void SetPool(Pool pool)
    {
        _pool = pool;
    }

    public void Execute(List<Entity> entities)
    {
        foreach (var e in entities)
        {
            var Resource = Resources.Load<GameObject>(e.asset.Source);

            GameObject gameObject = null;
            try
            {
                gameObject = UnityEngine.Object.Instantiate(Resource);
            }
            catch (Exception)
            {
                Debug.Log("Cannot instantiate " + Resource);
            }

            if (gameObject != null)
            {
               gameObject.transform.SetParent(_viewContainer, false);
               e.AddView(gameObject);
                gameObject.Link(e, _pool);
                
                if (e.hasPosition)
                {
                    var Position = e.position;
                    gameObject.transform.position = new Vector3(Position.X, Position.Z, Position.Z);
                }
            }
        }
    }
}