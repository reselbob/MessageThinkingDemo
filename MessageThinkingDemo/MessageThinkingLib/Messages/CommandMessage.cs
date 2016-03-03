namespace MessageThinkingLib.Messages
{
    /// <summary>
    /// enum that describes the commands avaiable for assignment to the property, CommandType
    /// available
    /// </summary>
    public enum CommandType { Stop, Start, Pause, Ok, Error, Unknown, Custom }
    
    public class CommandMessage
    {
        /// <summary>
        /// Constructor that initializes the class with a <see cref="CommandType"/>
        /// </summary>
        /// <param name="commandType"></param>
        public CommandMessage(CommandType commandType)
        {
            CommandType = commandType;
        }
        /// <summary>
        /// Property that reports the command type
        /// </summary>
        public CommandType CommandType { get; private set; }
    }
}
