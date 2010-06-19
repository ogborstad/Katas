using System;
using NUnit.Framework;

namespace TennisKataTest
{
    [TestFixture]
    public class TennisTest
    {
        private Game _game;

        [SetUp]
        public void SetUp()
        {
            _game = new Game();  
        }

        [Test]
        public void Assure_0_1_returns_Love_15()
        {
            SetBallsWon(0,1);
            var score = _game.GetScore();
            
            Assert.AreEqual("Love-15",score);
            
        }

        [Test]
        public void Assure_1_1_returns_15_15()
        {
            SetBallsWon(1,1);
            var score = _game.GetScore();
            
            Assert.AreEqual("15-15",score);
        }

        [Test]
        public void Assure_0_0_returns_Love_Love()
        {
            SetBallsWon(0,0);
            var score = _game.GetScore();
            
            Assert.AreEqual("Love-Love", score);
        }

        [Test]
        public void Assure_1_0_returns_15_Love()
        {
            SetBallsWon(1, 0);
            var score = _game.GetScore();
            
            Assert.AreEqual("15-Love", score);
        }

        [Test]
        public void Assure_3_3_returns_Deuce()
        {
            SetBallsWon(3, 3);
            var score = _game.GetScore();
            
            Assert.AreEqual("Deuce", score);
        }

        [Test]
        public void Assure_4_4_returns_Deuce()
        {
            SetBallsWon(4, 4);
            var score = _game.GetScore();

            Assert.AreEqual("Deuce", score);  
        }

        [Test]
        public void Assure_3_4_returns_40_A()
        {
            SetBallsWon(3,4);
            var score = _game.GetScore();

            Assert.AreEqual("40-A", score);
            
        }
        [Test]
        public void Assure_4_3_returns_A_40()
        {
            SetBallsWon(4, 3);
            var score = _game.GetScore();

            Assert.AreEqual("A-40", score);

        }

        [Test]
        public void Assure_4_0_returns_Player1Wins()
        {
            SetBallsWon(4,0);
            var score = _game.GetScore();

            Assert.AreEqual("Player1 Wins", score);
        }

        [Test]
        public void Assure_0_4_returns_Player2Wins()
        {
            SetBallsWon(0, 4);
            var score = _game.GetScore();

            Assert.AreEqual("Player2 Wins", score);
        }

        [Test]
        public void Assure_6_5_does_not_give_win()
        {
            SetBallsWon(6, 5);
            var score = _game.GetScore();

            Assert.AreNotEqual("Player1 Wins", score);
        }

        [Test]
        public void Assure_6_0_returns_invalid_score()
        {
            SetBallsWon(6,0);
            var score = _game.GetScore();
            Assert.AreEqual("Invalid Score", score);
        }

        private void SetBallsWon(int player1BallsWon, int player2BallsWon)
        {
            _game.SetPlayer1BallsWon(player1BallsWon);
            _game.SetPlayer2BallsWon(player2BallsWon);
        }
    }
}
