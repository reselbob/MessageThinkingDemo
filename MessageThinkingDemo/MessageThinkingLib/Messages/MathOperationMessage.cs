using Akka.Pattern;
using MessageThinkingLib.Actors;

namespace MessageThinkingLib.Messages
{
    /// <summary>
    /// A message that describes a Math Operation Messsage
    /// </summary>
    public class MathOperationMessage
    {
        
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="numbers">An array of numbers upone which to perform a math operation</param>
        /// <param name="operation">The math operation to perform, of enum, <see cref="MathOperation"/></param>
        public MathOperationMessage(int[] numbers, MathOperation operation)
        {
            Numbers = numbers;
            Operation = operation;
        }
        /// <summary>
        /// An array of numbers to process
        /// </summary>
        public int[] Numbers { get; private set; }
        /// <summary>
        /// The operation to apply to the numbers
        /// </summary>
        public MathOperation Operation { get; private set; }

    }
}