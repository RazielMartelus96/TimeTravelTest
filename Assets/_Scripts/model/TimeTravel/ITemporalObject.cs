namespace _Scripts.model.TimeTravel
{
    /// <summary>
    /// Interface representing the general functionality of an object within the game world that is effected by the
    /// primary "Time Travel" mechanic of the game. This can include things such as diffrent collision boxes, 
    /// </summary>
    public interface ITemporalObject
    {
        /// <summary>
        /// Executes a Shifting of the object's state, typically caused by the player invoking a Time Shift. 
        /// </summary>
        void ExecuteTemporalShift();
    }
}