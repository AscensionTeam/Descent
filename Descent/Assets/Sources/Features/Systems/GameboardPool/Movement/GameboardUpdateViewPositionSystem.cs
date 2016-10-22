using System;
using System.Collections.Generic;
using DG.Tweening;
using Entitas;
using UnityEngine;

/// <summary>
/// Gameboard Update View Position System.
/// </summary>
public sealed class GameboardUpdateViewPositionSystem : IReactiveSystem
{

    public TriggerOnEvent trigger { get { return Matcher.AllOf(GameboardMatcher.Position, GameboardMatcher.View).OnEntityAdded(); } }

    public void Execute(List<Entity> entities)
    {
        foreach (var e in entities)
        {
            var Position = e.position;
            e.view.ViewObject.transform.DOMove(new Vector3(Position.X, Position.Y, Position.Z), 0.3f);
        }
    }
}