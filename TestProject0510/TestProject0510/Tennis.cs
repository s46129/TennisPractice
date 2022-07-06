using System.Collections.Generic;

namespace TestProject0510
{
    public class Tennis
    {
        private int _firstPLayerScore;

        private readonly Dictionary<int, string> _scoreLookup = new Dictionary<int, string>()
        {
            {1, "Fifteen"},
            {2, "Thirty"},
            {3, "Forty"},
        };

        public string Score()
        {
            if (_firstPLayerScore > 0)
            {
                return $"{_scoreLookup[_firstPLayerScore]} Love";
            }

            return "Love All";
        }

        public void FirstPlayerScoreTime()
        {
            _firstPLayerScore++;
        }
    }
}