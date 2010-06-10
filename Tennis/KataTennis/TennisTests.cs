using NUnit.Framework;

namespace KataTennis
{
    [TestFixture]
    public class TennisTests
    {
        private Tennis game;
        private const string Deuce = "Deuce";

        [SetUp]
        public void InstantiateTennis()
        {
            game = new Tennis();
        }

        [Test]
        public void New_game_has_scores_0()
        {
            Assert.AreEqual("0 0", game.Score);
        }

        [Test]
        public void One_ball_won_gives_score_15()
        {
            game.PlayerOneScores();

            Assert.AreEqual("15", game.ScorePlayerOne);
        }

        [Test]
        public void Three_balls_won_each_is_deuce()
        {
            SetScoreForPlayers(3, 3);
            Assert.AreEqual(Deuce, game.Score);
        }

        [Test]
        public void Player_who_wins_ball_after_deuce_has_advantage()
        {
            SetScoreForPlayers(3,3);
            game.PlayerOneScores();

            Assert.AreEqual("Advantage 1", game.Score);
        }

        [Test]
        public void Score_is_deuce_after_advantage_if_opponent_scores()
        {
            SetScoreForPlayers(4, 3);
            game.PlayerTwoScores();

            Assert.AreEqual(Deuce, game.Score);
        }

        [Test]
        public void Player_wins_game_when_ball_is_won_with_advantage()
        {
            SetScoreForPlayers(3, 4);
            game.PlayerTwoScores();

            Assert.AreEqual("Player 2 won", game.Score);
        }

        private void SetScoreForPlayers(int scorePlayerOne, int scorePlayerTwo)
        {
            for (int i = 0; i < scorePlayerOne; i++)
            {
                game.PlayerOneScores();
            }
            for (int i = 0; i < scorePlayerTwo; i++)
            {
                game.PlayerTwoScores();
            }
        }
    }
}