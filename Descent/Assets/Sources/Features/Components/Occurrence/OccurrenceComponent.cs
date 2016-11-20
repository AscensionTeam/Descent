using Entitas;

// Created: 22/10/2016 ~ Alexander Hunt.

/// <summary>
/// Occurrence Component.
/// </summary>
[Occurrence]
public class OccurrenceComponent : IComponent {

    /// <summary>
    /// Action Layer.
    /// </summary>
    public int Layer;

    /// <summary>
    /// Action Type.
    /// </summary>
    public string Type;

    /// <summary>
    /// Action Argument(s).
    /// </summary>
    public object[] Args;
}
