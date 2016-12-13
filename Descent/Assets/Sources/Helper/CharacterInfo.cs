using System;

namespace Descent.Helper.MetaData
{
    /// <summary>
    /// Character Info Class.
    /// </summary>
    public class CharacterInfo : EventArgs
    {
        /// <summary>
        /// Character Name Property.
        /// </summary>
        public String CharacterName { get; private set; }

        /// <summary>
        /// Avatar Index Property.
        /// </summary>
        public int AvatarIndex { get; private set; }

        public SpawnInfo SpawnInfo { get; private set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="CharacterName">Character Name.</param>
        /// <param name="AvatarIndex">Avatar Index.</param>
        public CharacterInfo(String CharacterName, int AvatarIndex, SpawnInfo SpawnInfo)
        {
            this.CharacterName = CharacterName;
            this.AvatarIndex = AvatarIndex;
            this.SpawnInfo = SpawnInfo;
        }
    }
}