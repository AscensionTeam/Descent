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
public class GameboardLoadLevelSystem : IExecuteSystem, ISetPool
{
    /// <summary>
    /// Gameboard Pool.
    /// </summary>
    Pool _pool;

    /// <summary>
    /// Occurrence Component.
    /// </summary>
    OccurrenceComponent _Component = null;

    /// <summary>
    /// Constructor.
    /// </summary>
    public GameboardLoadLevelSystem()
    {
        /* Register OnOccurrence Callback. */
        Occurrence.OnOccurrence += OnOccurrence;
    }

    /// <summary>
    /// Deconstructor.
    /// </summary>
    ~GameboardLoadLevelSystem()
    {
        /* Remove OnOccurrence Callback. */
        Occurrence.OnOccurrence -= OnOccurrence;
    }

    /// <summary>
    /// Set Pool Method.
    /// </summary>
    /// <param name="pool">Pool.</param>
    public void SetPool(Pool pool)
    {
        /* Cache Pool. */
        _pool = pool;
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

            /* Loop Map Layer(s). */
            for (int LayerID = 0; LayerID < Map.Layers.Count; LayerID++)
            {
                var Layer = Map.Layers[LayerID];
                var TileSet = Map.Tilesets[LayerID];

                /* Loop Map Layer Tile(s). */
                for (int TileID = 0; TileID < Layer.Tiles.Count; TileID++)
                {
                    var TileSetTileList = TileSet.Tiles;
                    var Tile = Layer.Tiles[TileID];

                    /* Tile Exist(s)? */
                    if (Tile.Gid > 0)
                    {
                        int FirstGid = TileSet.FirstGid;
                        int Id = Tile.Gid - FirstGid;

                        if (TileSetTileList.ContainsKey(Id))
                        {
                            var TileSetTile = TileSetTileList[Id];
                            var TileSetTileInfo = TileSetTile.Properties;

                            /* Create Tile. */
                            Entity Entity = _pool.CreateEntity()
                                /* Add Position Component. */
                                .AddPosition(Tile.X, -Tile.Y, 0);

                            if (TileSetTileInfo.ContainsKey("Type"))
                            {
                                var Type = TileSetTileInfo["Type"];
                                Entity.AddGameboardElement("Tile", Type);

                                if (Type != "Spawn")
                                {
                                    Entity.AddAsset(Descent.Helper.Tile.TileSheetPath + (Id+1).ToString());
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
