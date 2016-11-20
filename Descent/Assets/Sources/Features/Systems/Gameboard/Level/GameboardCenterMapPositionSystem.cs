using Descent.Data;
using Descent.Helper;
using Entitas;

using System;
using TiledSharp;
using UnityEngine;

// Created: 20/11/2016 ~ Alexander Hunt.

/// <summary>
/// Gameboard Center Map Position System.
/// </summary>
public class GameboardCenterMapPositionSystem : IInitializeSystem, IExecuteSystem
{
    /* Occurrence Component. */
    OccurrenceComponent _Component = null;

    /// <summary>
    /// Initialize Method.
    /// </summary>
    public void Initialize()
    {
        /* Register OnOccurrence Callback. */
        OccurrenceExecuteSystem.OnOccurrence += OnOccurrence;
    }

    /// <summary>
    /// OnOccurrence Callback Method.
    /// </summary>
    /// <param name="Component">Component.</param>
    private void OnOccurrence(OccurrenceComponent Component)
    {
        /* Occurrence Type Validation. */
        if (Component.Type == OccurrenceType.Level.LoadLevel)
        {
            /* Cache Occurrence Component. */
            _Component = Component;
        }
    }

    /// <summary>
    /// System Execute Method.
    /// </summary>
    public void Execute()
    {
        if (_Component != null)
        {
            /* Center Map. */
            CenterMap(Blackboard.Shared.GetObject("TileMap") as TmxMap);

            /* Cleanup Component. */
            _Component = null;
        }
    }

    /// <summary>
    /// Unload Level Method.
    /// </summary>
    private void CenterMap(TmxMap Map)
    {
        if (Map != null)
        {
            /* Re-position Main Camera. */
            Camera.main.transform.position = new Vector3(
                Map.Width / 2,
                -Map.Height / 2,
                -(Map.Width +
                Map.Height) / 2);
        }
    }
}
