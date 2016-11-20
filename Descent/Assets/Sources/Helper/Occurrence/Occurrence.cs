using Entitas;

namespace Descent.Helper
{
    // Created: 22/10/2016 ~ Alexander Hunt.

    /// <summary>
    /// Occurrence Class.
    /// </summary>
    public static class Occurrence
    {
        /// <summary>
        /// Create Occurrence Method.
        /// </summary>
        /// <param name="Layer">Occurrence Layer.</param>
        /// <param name="Type">Occurrence Type.</param>
        /// <param name="Args">Occurrence Argument(s).</param>
        /// <returns>Entity.</returns>
        public static Entity Create(int Layer, string Type, params object[] Args)
        {
            /* Create & Return Occurrence Entity. */
            return Pools.sharedInstance.occurrence.CreateEntity()
                /* Create Occurrence Component. */
                .AddOccurrence(Layer, Type, Args);
        }

        /// <summary>
        /// Occurrence.Level Class.
        /// </summary>
        public static class Level
        {
            /// <summary>
            /// Unload Level.
            /// </summary>
            /// <returns>Entity.</returns>
            public static Entity UnloadLevel()
            {
                /* Create & Return Occurrence Entity. */
                return Pools.sharedInstance.occurrence.CreateEntity()
                    /* Create Occurrence Component. */
                    .AddOccurrence(0, OccurrenceType.Level.UnloadLevel, null);
            }

            /// <summary>
            /// Load Level Method.
            /// </summary>
            /// <param name="File">File.</param>
            /// <param name="Internal">Internal.</param>
            /// <returns>Entity.</returns>
            public static Entity LoadLevel(string File, bool Internal = true)
            {
                /* Create & Return Occurrence Entity. */
                return Pools.sharedInstance.occurrence.CreateEntity()
                    /* Create Occurrence Component. */
                    .AddOccurrence(0, OccurrenceType.Level.LoadLevel, new object[] { File, Internal });
            }
        }
    }
}