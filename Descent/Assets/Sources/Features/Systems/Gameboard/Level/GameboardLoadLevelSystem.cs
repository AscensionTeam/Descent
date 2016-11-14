using Descent.Helper;
using Entitas;

using System;
using UnityEngine;

// Created: 14/11/2016 ~ Alexander Hunt.

/// <summary>
/// Gameboard Load Level System.
/// </summary>
public class GameboardLoadLevelSystem : IExecuteSystem
{
    /// <summary>
    /// System Execute Method.
    /// </summary>
    public void Execute()
    {
        /* Loop Action Entity(s) */
        foreach (var e in Pools.sharedInstance.action.GetEntities())
        {
            /* Component Validation */
            if (e.hasAction && e.action.Type == ActionType.LoadLevel)
            {
                /* Load Level */
                LoadLevel(e.action.Args[0] as String);
            }
        }
    }

    /// <summary>
    /// Load Level Method.
    /// </summary>
    /// <param name="File">File.</param>
    private void LoadLevel(string File)
    {
        // TODO: Implement.

        // Variable/Method Check.
        Debug.Log("Loading Level: " + File);
    }
}
