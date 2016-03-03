using Akka.Actor;
using MessageThinkingLib.Messages;

namespace MessageThinkingLib.Actors
{
    /// <summary>
    /// A simple <see cref="Akka.Actor"/>
    /// </summary>
    public enum MathOperation { Add, Multiply,Subtract, None}
    public class MathActor:UntypedActor
    {
        protected override void OnReceive(object message)
        {
            var op = message as MathOperationMessage;
            if (op != null)
            {
                var answer = 0;
                if (op.Operation.Equals(MathOperation.Multiply)) answer = 1;// seed the anwser to not messup the multiplication
                foreach (var number in op.Numbers)
                {
                    if (op.Operation.Equals(MathOperation.Add)) answer = answer + number;
                    if (op.Operation.Equals(MathOperation.Subtract)) answer = answer - number;
                    if (op.Operation.Equals(MathOperation.Multiply))
                    {
                        answer = answer * number;
                    }
                    
                }

                //Create an answer message and....
                var answerMessage = new MathAnswerMessage(answer);
                //... send it back to the actor that sent the message
                Sender.Tell(answerMessage);
                
               //The commented out lines below is code I left as an example of what NOT to do
                
                //var output = string.Format("The operation is [{0}] and the answer is [{1}]", op.Operation, answer);

                //var writer = Context.ActorOf(Props.Create(() => new ConsoleWriteActor()), "MyWriter");
                //var writerMessage = new WriterMessage(CommandType.Custom, ConsoleColor.Cyan,output);
                //writer.Tell(writerMessage);
                //Sender.Tell(writerMessage);
                
                //Console.WriteLine("The operation is [{0}] and the answer is [{1}]", op.Operation,answer);

            }
        }
    }
}
