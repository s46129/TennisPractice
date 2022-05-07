using System.Collections.Generic;

namespace TennisPractice0506_2
{
    public class Tennis
    {
        private int firstPlayerScore;

        private Dictionary<int, string> _scoreLookup = new Dictionary<int, string>()
        {
            {1, "Fifteen"},
            {2, "Thirty"},
            {3, "Forty"},
        };

        public string Score()
        {
            if (firstPlayerScore >= 1)
            {
                return $"{_scoreLookup[firstPlayerScore]} Love";
            }

            return "Love All";
        }

        public void FirstPlayerScoreTime()
        {
            firstPlayerScore++;
        }
    }
}