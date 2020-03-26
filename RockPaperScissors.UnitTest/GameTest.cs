using NUnit.Framework;

namespace RockPaperScissors.UnitTest
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var game = new Game();
            var winner = game.GetWinner(PlayChoice.Rock, PlayChoice.Paper);
            Assert.AreEqual(2, winner);
        }

        [Test]
        public void Test2()
        {
            var game = new Game();
            var winner = game.GetWinner(PlayChoice.Rock, PlayChoice.Scissors);
            Assert.AreEqual(1, winner);
        }

        [Test]
        public void Test3()
        {
            var game = new Game();
            var winner = game.GetWinner(PlayChoice.Paper, PlayChoice.Scissors);
            Assert.AreEqual(2, winner);
        }


        [Test]
        public void Test4()
        {
            var game = new Game();
            var winner = game.GetWinner(PlayChoice.Scissors, PlayChoice.Paper);
            Assert.AreEqual(1, winner);
        }

        [Test]
        public void TestEqual()
        {
            var game = new Game();
            var winner = game.GetWinner(PlayChoice.Paper, PlayChoice.Paper);
            Assert.AreEqual(0, winner);
        }

        [Test]
        public void TestNumberToChoice1()
        {
            var game = new Game();
            var choice = game.GetChoice(1);
            Assert.AreEqual(PlayChoice.Rock, choice);
        }

        [Test]
        public void TestNumberToChoice2()
        {
            var game = new Game();
            var choice = game.GetChoice(2);
            Assert.AreEqual(PlayChoice.Paper, choice);
        }

        [Test]
        public void TestNumberToChoice3()
        {
            var game = new Game();
            var choice = game.GetChoice(3);
            Assert.AreEqual(PlayChoice.Scissors, choice);
        }
    }
}