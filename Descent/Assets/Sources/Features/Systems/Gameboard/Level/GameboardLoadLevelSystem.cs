using System;
using System.IO;
using UnityEngine;
using Entitas;
using TiledSharp;
using Descent.Data;
using Descent.Helper;
using System.Collections.Generic;

// Created: 20/11/2016 ~ Alexander Hunt.

/// <summary>
/// Gameboard Load Level System.
/// </summary>
public class GameboardLoadLevelSystem : IInitializeSystem, IExecuteSystem
{
    /* Occurrence Component. */
    OccurrenceComponent _Component = null;

    /// <summary>
    /// Initialize Method.
    /// </summary>
    public void Initialize()
    {
        /* Register OnOccurrence Callback. */
        Occurrence.OnOccurrence += OnOccurrence;
    }

    /// <summary>
    /// OnOccurrence Callback Method.
    /// </summary>
    /// <param name="Component">Component.</param>
    private void OnOccurrence(OccurrenceComponent Component)
    {
        /* Occurrence Type Validation. */
        if (Component.Type == OccurrenceType.Level.LoadLevel) {

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
            /* Load Level. */
            LoadLevel((String)_Component.Args[0], (Boolean)_Component.Args[1]);

            /* Cleanup Component. */
            _Component = null;
        }
    }

    /// <summary>
    /// Load Level Method.
    /// </summary>
    /// <param name="File">File.</param>
    private void LoadLevel(string File, bool Internal = true)
    {
        /* Internal File? */
        if (Internal)
        {
            /* Load XML File. */
            TextAsset Resource = Resources.Load("Map/" + File) as TextAsset;

            if (Resource != null)
            {
                /* Convert To Stream. */
                Stream ResourceStream = new MemoryStream(Resource.bytes);

                /* Process Map. */
                var Map = new TmxMap(ResourceStream);

                /* Build Level. */
                if (BuildLevel(Map))
                {
                    /* Cache Map Title. */
                    Blackboard.Shared.SetObject("TileMapTitle", File);

                    /* Invoke Signal. */
                    Occurrence.Level.Signal.CreateLevelLoadedSignal(File);
                }
            }
        }
        else
        {
            /* UnImpemented Feature. */
            throw new NotImplementedException("External Level Loading Not Implemented.");
        }
    }

    /// <summary>
    /// Build Level Method.
    /// </summary>
    /// <param name="Map">Map.</param>
    private bool BuildLevel(TmxMap Map)
    {
        if (Map != null)
        {
            /* Cache Map . */
            Blackboard.Shared.SetObject("TileMap", Map);

            Dictionary<int, TmxTilesetTile> TmxTilesetTiles = new Dictionary<int, TmxTilesetTile>();

            if (Map.Tilesets.Count > 0)
            {
                var Tileset = Map.Tilesets[0];

                foreach (var t in Tileset.Tiles)
                {
                    TmxTilesetTiles.Add(t.Value.Id, t.Value);
                }
            }


                /* Loop Map Layer(s). */
                foreach (var TmxLayer in Map.Layers)
            {
                /* Loop Map Layer Tile(s). */
                foreach (var TmxTile in TmxLayer.Tiles)
                {
                    /* Tile Exist(s)? */
                    if (TmxTile.Gid > 0)
                    {
                        /* Create Tile. */
                        Entity Entity = Pools.sharedInstance.gameboard.CreateEntity()
                            /* Add Position Component. */
                            .AddPosition(TmxTile.X, -TmxTile.Y, 0)
                            /* Add Asset Component. */
                            .AddAsset(Tile.TileSheetPath
                            + TmxTile.Gid.ToString());

                        /* Validate Map Property(s). */


                        if (TmxTilesetTiles != null)
                        {
                            if (TmxTilesetTiles.ContainsKey(TmxTile.Gid - 1))
                            {
                                var Properties = TmxTilesetTiles[TmxTile.Gid - 1].Properties;
                                if (Properties.ContainsKey("Type"))
                                {
                                    /* Add Gameboard Element Component. */
                                    Entity.AddGameboardElement("Tile", Properties["Type"]);
                                }
                            }
                        }
                    }
                }
            }

            return true;
        }
        else
        {
            return false;
        }
    }
}
