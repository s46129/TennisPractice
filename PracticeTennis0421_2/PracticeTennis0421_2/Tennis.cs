using System.Collections.Generic;

namespace PracticeTennis0421_2
{
    public class Tennis
    {
        private int _firstPlayerScore;

        public string Score()
        {
            var scoreLookup = new Dictionary<int, string>()
            {
                {1, "Fifteen"},
                {2, "Thirty"},
                {3, "Forty"},
            };
            if (_firstPlayerScore >= 1)
            {
                return $"{scoreLookup[_firstPlayerScore]} Love";
            }

            return "Love All";
        }

        public void FirstPlayerScoreTime()
        {
            _firstPlayerScore++;
        }
    }
}