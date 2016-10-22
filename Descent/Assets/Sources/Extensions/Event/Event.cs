using Entitas;

namespace Helpers
{
    /// <summary>
    /// Event Helper Class.
    /// </summary>
    public static class Event
    {
        /// <summary>
        /// Create Event.
        /// </summary>
        /// <param name="Layer">Event Layer.</param>
        /// <param name="Type">Event Type.</param>
        /// <param name="Args">Event Argument(s).</param>
        /// <returns>Event Pool Entity.</returns>
        public static Entity Create(int Layer, int Type, params object[] Args)
        {
            /* Create & Return Event Entity. */
            return Pools.sharedInstance.action.CreateEntity()
                /* Create Action Component. */
                .AddAction(Layer, Type, Args);
        }
    }
}