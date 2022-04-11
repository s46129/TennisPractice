using System.Collections.Generic;

namespace TennisPractice0412
{
    public class Tennis
    {
        private int _firstPlayerScoreTimes;

        public string Score()
        {
            var scoreLookup = new Dictionary<int, string>
            {
                {1, "Fifteen"},
                {2, "Thirty"},
            };
            if (_firstPlayerScoreTimes == 1 || _firstPlayerScoreTimes == 2)
            {
                return $"{scoreLookup[_firstPlayerScoreTimes]} Love";
            }

            return "Love All";
        }

        public void FirstPlayerScore()
        {
            _firstPlayerScoreTimes++;
        }
    }
}