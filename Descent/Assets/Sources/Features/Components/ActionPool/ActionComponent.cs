using Entitas;

// Created: 22/10/2016 ~ Alexander Hunt.

/// <summary>
/// Action Component.
/// </summary>
[Action]
public class ActionComponent : IComponent {

    /// <summary>
    /// Action Layer.
    /// </summary>
    public int Layer;

    /// <summary>
    /// Action Type.
    /// </summary>
    public int Type;

    /// <summary>
    /// Action Argument(s).
    /// </summary>
    public object[] Args;
}
