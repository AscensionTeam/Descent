using Entitas;

namespace Descent.Helper
{
    /// <summary>
    /// Event Class.
    /// </summary>
    public static class Action
    {
        /// <summary>
        /// Create Action Method.
        /// </summary>
        /// <param name="Layer">Action Layer.</param>
        /// <param name="Type">Action Type.</param>
        /// <param name="Args">Action Argument(s).</param>
        /// <returns>Action Pool Entity.</returns>
        public static Entity Create(int Layer, int Type, params object[] Args)
        {
            /* Create & Return Action Entity. */
            return Pools.sharedInstance.action.CreateEntity()
                /* Create Action Component. */
                .AddAction(Layer, Type, Args);
        }
    }
}