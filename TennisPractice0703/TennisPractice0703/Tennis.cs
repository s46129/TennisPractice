using System.Collections.Generic;

namespace TennisPractice0703
{
    public class Tennis
    {
        private int _firstPlayerScore;

        private readonly Dictionary<int, string> _scoreLookup = new Dictionary<int, string>()
        {
            {1, "Fifteen"},
            {2, "Thirty"},
            {3, "Forty"},
        };

        public string Score()
        {
            if (_firstPlayerScore > 0)
            {
                return $"{_scoreLookup[_firstPlayerScore]} Love";
            }

            return "Love All";
        }

        public void FirstPlayerScoreTime()
        {
            _firstPlayerScore++;
        }
    }
}