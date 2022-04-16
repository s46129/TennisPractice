using System.Collections.Generic;

namespace PracticeTennis0417
{
    public class Tennis
    {
        private int FirstPlayerScoreTime;

        public string Score()
        {
            var scoreLookup = new Dictionary<int, string>()
            {
                {1, "Fifteen"},
                {2, "Thirty"},
                {3, "Forty"},
            };

            if (FirstPlayerScoreTime >= 1)
            {
                return $"{scoreLookup[FirstPlayerScoreTime]} Love";
            }

            return "Love All";
        }

        public void FirstPlayerScore()
        {
            FirstPlayerScoreTime++;
        }
    }
}