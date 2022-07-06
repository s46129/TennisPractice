using System.Collections.Generic;

namespace TennisPractice0707
{
    public class Tennis
    {
        private int _FirestPlayerScore;

        private Dictionary<int, string>? _scoreLookup = new Dictionary<int, string>()
        {
            {1, "Fifteen"},
            {2, "Thirty"},
            {3, "Forty"},
        };

        public string Score()
        {
            if (_FirestPlayerScore > 0)
            {
                return $"{_scoreLookup[_FirestPlayerScore]} Love";
            }

            return "Leve All";
        }

        public void FirstPlayerScoreTime()
        {
            _FirestPlayerScore++;
        }
    }
}