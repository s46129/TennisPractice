using System.Collections.Generic;

namespace TennisPractice0503
{
    internal class Tennis
    {
        private int firstPlayerScore;

        public string Score()
        {
            var scoreLookup = new Dictionary<int, string>()
            {
                {1, "Fifteen"},
                {2, "Thirty"},
                {3, "Forty"},
            };
            if (firstPlayerScore >= 1)
            {
                return $"{scoreLookup[firstPlayerScore]} Love";
            }

            return "Love All";
        }

        public void FirstPlayerScoreTime()
        {
            firstPlayerScore++;
        }
    }
}