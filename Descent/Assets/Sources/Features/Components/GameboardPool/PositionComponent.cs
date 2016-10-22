using Entitas;

// Created: 22/10/2016 ~ Alexander Hunt.

/// <summary>
/// Position Component Class.
/// </summary>
[Gameboard]
public class PositionComponent : IComponent
{
    /// <summary>
    /// X Position.
    /// </summary>
    public int X;

    /// <summary>
    /// Y Position.
    /// </summary>
    public int Y;

    /// <summary>
    /// Z Position.
    /// </summary>
    public int Z;
}