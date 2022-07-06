using System.Collections.Generic;

namespace TennisPractice_0526
{
    public class Tennis
    {
        private Dictionary<int, string> _scoreLookup = new Dictionary<int, string>()
        {
            {1, "Fifteen"},
            {2, "Thirty"},
            {3, "FortＵy"},
        };

        private int _FirstPlayerScore;

        public string Score()
        {
            if (_FirstPlayerScore > 0)
            {
                return $"{_scoreLookup[_FirstPlayerScore]} Love";
            }

            return "Love All";
        }

        public void FirstPlayerScoreTime()
        {
            _FirstPlayerScore++;
        }
    }
}