namespace KataTennis
{
    public class Tennis
    {
        private int _ballsWonPlayerOne;
        private int _ballsWonPlayerTwo;
        private readonly int[] Scores = new[]{ 0, 15 , 30, 40 };

        public Tennis()
        {
            _ballsWonPlayerOne = 0;
            _ballsWonPlayerTwo = 0;
        }

        public object Score
        {
            get
            {
                if (_ballsWonPlayerOne > 3 && _ballsWonPlayerOne - _ballsWonPlayerTwo >= 2)
                    return "Player 1 won";

                if (_ballsWonPlayerTwo > 3 && _ballsWonPlayerTwo - _ballsWonPlayerOne >= 2)
                    return "Player 2 won";

                if (_ballsWonPlayerOne + _ballsWonPlayerTwo > 5)
                {
                    if (_ballsWonPlayerOne == _ballsWonPlayerTwo)
                        return "Deuce";
                    
                    return _ballsWonPlayerOne > _ballsWonPlayerTwo ? "Advantage 1" : "Advantage 2";
                }
                
                return ScorePlayerOne + " " + ScorePlayerTwo;
            }
        }

        public string ScorePlayerTwo
        {
            get { return Scores[_ballsWonPlayerTwo].ToString(); }
        }

        public string ScorePlayerOne
        {
            get { return Scores[_ballsWonPlayerOne].ToString(); }
        }

        public void PlayerOneScores()
        {
            _ballsWonPlayerOne++;
        }

        public void PlayerTwoScores()
        {
            _ballsWonPlayerTwo++;
        }
    }
}