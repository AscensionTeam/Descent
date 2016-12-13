using System;
using Entitas;
using Descent.Helper.MetaData;

namespace Descent.Helper
{
    // Created: 22/10/2016 ~ Alexander Hunt.

    /// <summary>
    /// Occurrence Class.
    /// </summary>
    public static class Occurrence
    {
        /// <summary>
        /// OnOccurrence Event.
        /// </summary>
        public static event Action<OccurrenceComponent> OnOccurrence;

        /// <summary>
        /// Signal Class.
        /// </summary>
        public static class Signal
        {
            /// <summary>
            /// Create Occurrence Signal Method.
            /// </summary>
            /// <param name="Occurrence">Occurrence.</param>
            public static void CreateOccurrenceSignal(OccurrenceComponent Occurrence)
            {
                /* If OnCurrence Event(s). */
                if (OnOccurrence != null)
                {
                    /* Invoke Event. */
                    OnOccurrence.Invoke(Occurrence);
                }
            }
        }

        /// <summary>
        /// Create Occurrence Method.
        /// </summary>
        /// <param name="Layer">Occurrence Layer.</param>
        /// <param name="Type">Occurrence Type.</param>
        /// <param name="Args">Occurrence Argument(s).</param>
        /// <returns>Entity.</returns>
        public static Entity CreateOccurrence(int Layer, string Type, params object[] Args)
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
            public static event Action<String> OnLevelUnloaded;
            public static event Action<String> OnLevelLoaded;
            public static event EventHandler<CharacterInfo> OnCharacterAdded;

            /// <summary>
            ///  Signal Class.
            /// </summary>
            public static class Signal
            {

                /// <summary>
                /// Create Level Loaded Signal Method.
                /// </summary>
                /// <param name="Level">Level.</param>
                public static void CreateLevelLoadedSignal(String Level)
                {
                    /* If OnLevelLoaded Event(s) Contained. */
                    if (OnLevelLoaded != null)
                    {
                        /* Invoke Event. */
                        OnLevelLoaded.Invoke(Level);
                    }
                }

                /// <summary>
                /// Create Level Unloaded Signal Method.
                /// </summary>
                /// <param name="Level">Level.</param>
                public static void CreateLevelUnloadedSignal(String Level)
                {
                    /* If OnLevelUnloaded Event(s) Contained. */
                    if (OnLevelLoaded != null)
                    {
                        /* Invoke Event. */
                        OnLevelLoaded.Invoke(Level);
                    }
                }

                /// <summary>
                /// Create Character Added Signal Method.
                /// </summary>
                /// <param name="CharacterInfo">Info.</param>
                public static void CreateCharacterAddedSignal(Object Sender, CharacterInfo Info)
                {
                    /* If OnCharacterAdded Event(s) Contained. */
                    if (OnCharacterAdded != null)
                    {
                        /* Invoke Event. */
                        OnCharacterAdded.Invoke(Sender, Info);
                    }
                }
            }

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

            /// <summary>
            /// Add Character Method.
            /// </summary>
            /// <param name="CharacterName">Character Name.</param>
            /// <param name="AvatarIndex">Character Avatar Index.</param>
            /// <param name="SpawnIndex">Spawn Index.</param>
            /// <returns>Entity.</returns>
            public static Entity AddCharacter(string CharacterName, int AvatarIndex, int SpawnIndex=-1)
            {
                /* Create & Return Occurrence Entity. */
                return Pools.sharedInstance.occurrence.CreateEntity()
                    /* Create Occurrence Component. */
                    .AddOccurrence(0, OccurrenceType.Level.AddCharacter, new object[] { CharacterName, AvatarIndex, SpawnIndex });
            }
        }
    }
}