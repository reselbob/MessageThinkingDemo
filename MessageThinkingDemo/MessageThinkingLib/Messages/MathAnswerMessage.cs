namespace MessageThinkingLib.Messages
{
    /// <summary>
    /// This class defines a message to use to when needing
    /// to inform an actor about the answer to a MathActor calcuation
    /// </summary>
    public class MathAnswerMessage
    {
        /// <summary>
        /// Constructor to use to intialize the class with the answer
        /// </summary>
        /// <param name="answer">the answer</param>
        public MathAnswerMessage(decimal answer)
        {
            Answer = answer;
        }
        /// <summary>
        /// Answer of type, decimal
        /// </summary>
        public decimal Answer { get; private set; }
        
    }
}