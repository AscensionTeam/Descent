using Descent.Data;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Descent.Helper
{
    /// <summary>
    /// Tile Class.
    /// </summary>
    public static class Tile
    {
        /// <summary>
        /// TileSheet.
        /// </summary>
        static string _TileSheet = "Default";

        /// <summary>
        /// TileSheet Property.
        /// </summary>
        public static string TileSheet
        {
            get { return _TileSheet; }
        }

        /// <summary>
        /// TileSheet Path Property.
        /// </summary>
        public static string TileSheetPath
        {
            get { return _TileSheet + "_"; }
        }

        /// <summary>
        /// Set TileSheet Method.
        /// </summary>
        /// <param name="Source">Source.</param>
        public static void SetTileSheet(String Source)
        {
            /* Set TileSheet. */
            _TileSheet = (Source != null) ? Source : "Default";
        }

        /// <summary>
        /// Get Method.
        /// </summary>
        /// <param name="Source">Source.</param>
        /// <returns>Sprite.</returns>
        public static UnityEngine.Sprite Get(String Source)
        {
            /* Return Sprite. */
            return Sprite.Get(_TileSheet + "_" + Source);
        }
    }
}
