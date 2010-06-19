using System;

namespace TennisKataTest
{
    public class Game
    {
        private int _player1BallsWon;
        private int _player2BallsWon;
        private readonly string[] _scoreArray = {"Love", "15", "30", "40"};
        
        public Game()
        {
            _player1BallsWon = 0;
            _player2BallsWon = 0;
        }

        public void SetPlayer1BallsWon(int score)
        {
            _player1BallsWon = score;
        }

        public void SetPlayer2BallsWon(int score)
        {
            _player2BallsWon = score;
        }


        public string GetScore()
        {
            if (GetBallsWonDifference() >= 5 && OnePlayerHasMoreThan40Points())
                return "Invalid Score";

            if (IsDeuce())
                return "Deuce";
            
            if (IsAdvantage())
                return GetAdvantage();

            if (IsGameWon())
                return GetWinner();

            return GetPlayer1Score() + "-" + GetPlayer2Score();

        }

        private string GetAdvantage()
        {
            if (_player1BallsWon > _player2BallsWon)
                return "A-40";
                
            return "40-A";
        }

        private string GetWinner()
        {
            if (_player1BallsWon > _player2BallsWon)
                return "Player1 Wins";

            return "Player2 Wins";
        }

        private bool IsGameWon()
        {
            return GetBallsWonDifference() >= 2 &&
                   OnePlayerHasMoreThan40Points();

        }

        private bool OnePlayerHasMoreThan40Points()
        {
            return _player1BallsWon >= 4 || _player2BallsWon >= 4;   
        }

        private int GetBallsWonDifference()
        {
            return Math.Abs(_player1BallsWon - _player2BallsWon);
        }

        private bool IsAdvantage()
        {
            return (BothPlayersHasAtLeast40Points() && GetBallsWonDifference() == 1);

        }

        private bool IsDeuce()
        {
            return (BothPlayersHasAtLeast40Points() && GetBallsWonDifference() == 0) ;
        }

        private bool BothPlayersHasAtLeast40Points()
        {
            return _player1BallsWon >= 3 && _player2BallsWon >= 3;
        }

        private string GetPlayer1Score()
        {
            return _scoreArray[_player1BallsWon];
        }
        private string GetPlayer2Score()
        {
            return _scoreArray[_player2BallsWon];
        }
    }
}