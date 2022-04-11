using System.Collections.Generic;

namespace TennisPractice0405
{
    public class Tennis
    {
        private int firstPlayerScoreTimes;

        private Dictionary<int, string> _scoreLookup = new Dictionary<int, string>()
        {
            {
                1, "Fifteen"
            },
            {
                2, "Thirty"
            }
        };

        public string Score()
        {
            if (firstPlayerScoreTimes > 0)
            {
                return $"{_scoreLookup[firstPlayerScoreTimes]} Love";
            }

            return "Love All";
        }

        public void FirstPlayerScore()
        {
            firstPlayerScoreTimes++;
        }
    }
}