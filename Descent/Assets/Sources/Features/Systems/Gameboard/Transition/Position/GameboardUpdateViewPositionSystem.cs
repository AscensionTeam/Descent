using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Entitas;

/// <summary>
/// Gameboard Update View Position System.
/// </summary>
public sealed class GameboardUpdateViewPositionSystem : IReactiveSystem
{
    /// <summary>
    /// Trigger On Event Property.
    /// </summary>
    public TriggerOnEvent trigger { get { return Matcher.AllOf(GameboardMatcher.Position, GameboardMatcher.View).OnEntityAdded(); } }

    /// <summary>
    /// System Execute Method.
    /// </summary>
    /// <param name="entities">Entities.</param>
    public void Execute(List<Entity> entities)
    {
        /* Loop Gameboard Entity(s). */
        foreach (var e in entities)
        {
            /* Cache Position Component. */
            var Position = e.position;

            /* Move Unity Gameobject using Dotween. */
            e.view.ViewObject.transform.DOMove(new Vector3(Position.X, Position.Y, Position.Z), 0.3f);
        }
    }
}