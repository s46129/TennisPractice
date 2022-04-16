using System.Collections.Generic;

namespace TennisePracetice
{
    public class Tennis
    {
        private int firstPlayerScoreTime;

        public string Score()
        {
            var scoreLookup = new Dictionary<int, string>()
            {
                {1, "Fifteen"},
                {2, "Thirty"},
                {3, "Forty"},
            };
            if (firstPlayerScoreTime >= 1)
            {
                return $"{scoreLookup[firstPlayerScoreTime]} Love";
            }

            return "Love All";
        }

        public void FirstPlayerScore()
        {
            firstPlayerScoreTime++;
        }
    }
}