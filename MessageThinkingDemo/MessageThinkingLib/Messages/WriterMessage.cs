using System;
using System.Data;

namespace MessageThinkingLib.Messages
{
    /// <summary>
    /// Describes a message to send to a <see cref="ConsoleWriter"/>
    /// </summary>
    public class WriterMessage
    {
        /// <summary>
        /// Constructor that intializes the values of the classs's properties
        /// </summary>
        /// <param name="commandType">The <see cref="CommandType"/></param>
        /// <param name="outputColor">The font color of the output</param>
        /// <param name="output">A string that represents the output to send to the console.</param>
        public WriterMessage(CommandType commandType, ConsoleColor outputColor, string output = null)
        {
            Output = output;
            OutputColor = outputColor;
            CommandType = commandType;
        }
        public string Output { get; private set; }
        public ConsoleColor OutputColor { get; private set; }
        public CommandType CommandType { get; private set; }
    }
}
