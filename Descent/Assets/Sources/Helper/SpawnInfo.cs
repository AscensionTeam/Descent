using Entitas;

namespace Descent.Helper.MetaData
{
    /// <summary>
    /// SpawnInfo Class.
    /// </summary>
    public class SpawnInfo
    {
        /// <summary>
        /// Spawn Index Property.
        /// </summary>
        public int SpawnIndex { get; private set; }

        /// <summary>
        /// Spawn Property.
        /// </summary>
        public Entity Spawn { get; private set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="SpawnIndex">Spawn Index.</param>
        /// <param name="Spawn">Spawn.</param>
        public SpawnInfo(int SpawnIndex, Entity Spawn)
        {
            this.SpawnIndex = SpawnIndex;
            this.Spawn = Spawn;
        }
    }
}
