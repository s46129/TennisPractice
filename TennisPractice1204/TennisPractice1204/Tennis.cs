using System.Collections.Generic;

namespace TennisPractice1204
{
    public class Tennis
    {
        private int _firstPlayerScoreTimes;

        private readonly Dictionary<int, string> _scoreLookUp = new Dictionary<int, string>()
        {
            {1, "Fifteen Love"},
            {2, "Thirty Love"},
            {3, "Forty Love"},
        };

        public string Score()
        {
            if (_firstPlayerScoreTimes > 0)
            {
                return _scoreLookUp[_firstPlayerScoreTimes];
            }


            return "Love All";
        }

        public void FirstPlayerScore()
        {
            _firstPlayerScoreTimes++;
        }
    }
}