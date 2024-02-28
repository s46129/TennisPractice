﻿using System.Collections.Generic;

namespace TennisPractice20240228
{
    public class Tennis
    {
        private int _firstPlayerScore;

        public string FistPlayerScore()
        {
            var scoreLookup = new Dictionary<int, string>
            {
                { 1, "Fifteen" },
                { 2, "Thirty" },
                { 3, "Forty" }
            };
            if (_firstPlayerScore > 0) return $"{scoreLookup[_firstPlayerScore]} Love";
            return "Love All";
        }

        public void FirstPlayerScore()
        {
            _firstPlayerScore++;
        }
    }
}