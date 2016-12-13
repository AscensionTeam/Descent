using Descent.Data;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Descent.Helper
{
    /// <summary>
    /// Sprite Class.
    /// </summary>
    public static class Sprite
    {
        /// <summary>
        /// Sprite Dictionary.
        /// </summary>
        static Dictionary<String, UnityEngine.Sprite> SpriteCache;

        /// <summary>
        /// Sprite Constructor.
        /// </summary>
        static Sprite()
        {
            /* Initialize SpriteCache. */
            SpriteCache = new Dictionary<String, UnityEngine.Sprite>();

            /* Populate SpriteCache. */
            Fetch();
        }

        /// <summary>
        /// Fetch Method.
        /// </summary>
        private static void Fetch()
        {
            /* Fetch Sprite(s). */
            var Resource = Resources.LoadAll<UnityEngine.Sprite>("SpriteSheet");

            /* Loop Sprite(s). */
            foreach (var Sprite in Resource)
            {
                /* Cache Sprite(s). */
                SpriteCache.Add(Sprite.name, Sprite);
            }
        }

        /// <summary>
        /// Get Method.
        /// </summary>
        /// <param name="Source">Source.</param>
        /// <returns>Sprite.</returns>
        public static UnityEngine.Sprite Get(String Source)
        {
            /* Return Sprite. */
            return (SpriteCache != null && SpriteCache.ContainsKey(Source)) ? SpriteCache[Source] : null;
        }
    }
}
