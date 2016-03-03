using Akka.Actor;
using Akka.TestKit.VsTest;
using MessageThinkingLib.Actors;
using MessageThinkingLib.Messages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ActorTests
{
    [TestClass]
    public class ActorTests : TestKit

    {
        private readonly int[] _numbers = {1, 2, 3, 4};

        //TODO: Figure out a way to eliminate hard coding expected
        //      answer declaration

        /// <summary>
        /// This test exercises a MathActor by sending an 'add' command via a 
        /// <see cref="MessageThinkingLib.Messages.MathOperatorMessage"/> to
        /// a <see cref="MathActor"/>. Check that a <see cref="MathAnswerMessage"/>
        /// is sent back with the proper answer.
        /// </summary>
        [TestMethod]
        public void MathActorAddTest()
        {
            var message = new MathOperationMessage(_numbers, MathOperation.Add);

            //Create the ActorSystem
            var system = ActorSystem.Create("MySystem");
            //Create the MathActor
            var actor = system.ActorOf(Props.Create(() => new MathActor()), "MyMathActor");
            actor.Tell(message);
            //Let the testing framework get an answer message
            var answer = ExpectMsg<MathAnswerMessage>();
            //Make sure it's correct. (yeah, hardcoding is bad business)
            Assert.AreEqual(answer.Answer, 10);
        }


        /// <summary>
        /// This test exercises a MathActor by sending an 'subtract' command via a 
        /// <see cref="MessageThinkingLib.Messages.MathOperatorMessage"/> to
        /// a <see cref="MathActor"/>. Check that a <see cref="MathAnswerMessage"/>
        /// is sent back with the proper answer.
        /// </summary>
        [TestMethod]
        public void MathActorSubtractTest()
        {
            var message = new MathOperationMessage(_numbers, MathOperation.Subtract);

            //Create the ActorSystem
            var system = ActorSystem.Create("MySystem");
            //Create the MathActor
            var actor = system.ActorOf(Props.Create(() => new MathActor()), "MyMathActor");
            actor.Tell(message);
            var answer = ExpectMsg<MathAnswerMessage>();
            Assert.AreEqual(answer.Answer, -10);
        }


        /// <summary>
        /// This test exercises a MathActor by sending an 'multiply' command via a 
        /// <see cref="MessageThinkingLib.Messages.MathOperatorMessage"/> to
        /// a <see cref="MathActor"/>. Check that a <see cref="MathAnswerMessage"/>
        /// is sent back with the proper answer.
        /// </summary>
        [TestMethod]
        public void MathActorMultiplyTest()
        {
            var message = new MathOperationMessage(_numbers, MathOperation.Multiply);

            //Create the ActorSystem
            var system = ActorSystem.Create("MySystem");
            //Create the MathActor
            var actor = system.ActorOf(Props.Create(() => new MathActor()), "MyMathActor");
            actor.Tell(message);
            var answer = ExpectMsg<MathAnswerMessage>();
            Assert.AreEqual(answer.Answer, 24);
        }
    }
}