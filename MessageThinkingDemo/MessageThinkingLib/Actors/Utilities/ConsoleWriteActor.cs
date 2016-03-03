using System;
using Akka.Actor;
using MessageThinkingLib.Messages;

namespace MessageThinkingLib.Actors.Utilities
{
   /// <summary>
   /// Actor that faciliates sending output to the console. To
   ///  output to the console, send the actor a message of type, string 
   /// or a <see cref="WriterMessage"/>.
   /// 
   ///A new <see cref="WriterMessage"/> will be sent to the caller. Successful output
   /// will have <see cref="WriterMesssage.CommandType"/> set to CommandType.Ok. Failure
    /// will have <see cref="WriterMesssage.CommandType"/> set to CommandType.Error.
   /// 
   /// </summary>
    public class ConsoleWriteActor : ReceiveActor
    {
        public ConsoleWriteActor()
        {
            ReceiveAny(x =>
            {
                CommandType commandType;
                var msg = x as WriterMessage;
                var s = string.Empty;
                if (msg == null)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    s = "Bad Message Format";
                    commandType = CommandType.Error;
                }

                else
                {
                    s = msg.Output;
                    Console.ForegroundColor = msg.OutputColor;
                    commandType = CommandType.Ok;
                }
                Console.WriteLine(s);

                Sender.Tell(new WriterMessage(commandType, Console.ForegroundColor, s));
                Console.ForegroundColor = DefaultColor;
            });
        }

        /// <summary>
        /// Rerturns the default font color used for output
        /// </summary>
        public ConsoleColor DefaultColor
        {
            get { return ConsoleColor.White; }
        }
    }
}