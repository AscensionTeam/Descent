using Entitas;

using UnityEngine;

// Created: 22/11/2016 ~ Alexander Hunt.

/// <summary>
/// Gameboard Element Component Class.
/// </summary>
[Gameboard]
public class GameboardElementComponent : IComponent
{
    /// <summary>
    /// Type.
    /// </summary>
    public string Type;

    /// <summary>
    /// Subtype.
    /// </summary>
    public string Subtype;
}