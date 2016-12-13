using System.Collections.Generic;
using System;
using Descent.Helper;
using UnityEngine;
using Entitas;

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
        /* Log. */
        DescentLogger.Shared.LogSystemInfo(this, "Set Pool.");

        /* Cache Pool. */
        _pool = pool;
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
            DescentLogger.Shared.LogSystemInfo(this, "Creating View For Entity " + e.creationIndex);

            GameObject gameObject = null;

            try
            {
                gameObject = new GameObject("Tile " + e.asset.Source);
                var renderer = gameObject.AddComponent<SpriteRenderer>();
                renderer.sprite = Descent.Helper.Sprite.Get(e.asset.Source);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }

            if (gameObject != null)
            {
                /* Log. */
                DescentLogger.Shared.LogSystemInfo(this, "GameObject Created, " + gameObject.name);

                /* Parent new GameObject under 'View' GameObject. */
                gameObject.transform.SetParent(_ViewContainer, false);

                /* Add view component to entitas entity. */
                e.AddView(gameObject);

                /* Log. */
                DescentLogger.Shared.LogSystemInfo(this, "View Linked. ");

                /* Create entity inspector for debugging purposes. */
                gameObject.Link(e, _pool);

                if (e.hasPosition)
                {
                    /* Cache Position. */
                    var Position = e.position;
                    /* Update unity GameObject position. */
                    gameObject.transform.position = new Vector3(Position.X, Position.Z, Position.Z);

                    /* Log. */
                    DescentLogger.Shared.LogSystemInfo(this, "GameObject Position Updated, " + gameObject.transform.position);
                }
            }else
            {
                /* Log. */
                DescentLogger.Shared.LogSystemWarning(this, "GameObject Failed To Be Created. ");
            }
        }
    }
}