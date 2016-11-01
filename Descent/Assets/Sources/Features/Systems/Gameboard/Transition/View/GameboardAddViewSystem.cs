﻿using System;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

/// <summary>
/// Gameboard Add View System.
/// </summary>
public sealed class GameboardAddViewSystem : ISetPool, IReactiveSystem
{
    /// <summary>
    /// Trigger On Event Property.
    /// </summary>
    public TriggerOnEvent trigger { get { return GameboardMatcher.Asset.OnEntityAdded(); } }

    /// <summary>
    /// Unity View (GameObject) Container.
    /// </summary>
    readonly Transform _ViewContainer = new GameObject("View").transform;

    /// <summary>
    /// Gameboard Pool.
    /// </summary>
    Pool _pool;

    /// <summary>
    /// Set Pool Method.
    /// </summary>
    /// <param name="pool">Pool.</param>
    public void SetPool(Pool pool)
    {
        /* Cache Pool. */
        _pool = pool;
    }

    /// <summary>
    /// System Execute Method.
    /// </summary>
    /// <param name="entities">Entities.</param>
    public void Execute(List<Entity> entities)
    {
        /* Loop Gameboard Entity(s). */
        foreach (var e in entities)
        {
            /* Retrieve Prefab from Resources folder. */
            var Resource = Resources.Load<GameObject>(e.asset.Source);

            
            GameObject gameObject = null;
            try
            {
                /* Instantiate new GameObject from prefab. */
                gameObject = UnityEngine.Object.Instantiate(Resource);
            }
            catch (Exception)
            {
                Debug.Log("Cannot instantiate " + Resource);
            }

            if (gameObject != null)
            {
                /* Parent new GameObject under 'View' GameObject. */
                gameObject.transform.SetParent(_ViewContainer, false);

                /* Add view component to entitas entity. */
                e.AddView(gameObject);

                /* Create entity inspector for debugging purposes. */
                gameObject.Link(e, _pool);

                if (e.hasPosition)
                {
                    /* Cache Position. */
                    var Position = e.position;
                    /* Update unity GameObject position. */
                    gameObject.transform.position = new Vector3(Position.X, Position.Z, Position.Z);
                }
            }
        }
    }
}