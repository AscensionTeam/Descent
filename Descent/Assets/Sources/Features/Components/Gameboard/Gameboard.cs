using Entitas;
using Entitas.CodeGenerator;

// Created: 14/12/2016 ~ Alexander Hunt.

/// <summary>
/// Gameboard Component Class.
/// </summary>
[Gameboard, SingleEntity]
public class GameboardComponent : IComponent
{
    /// <summary>
    /// Selected Unit.
    /// </summary>
    public Entity SelectedUnit;
}