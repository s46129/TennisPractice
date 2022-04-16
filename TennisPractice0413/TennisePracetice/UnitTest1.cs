using NUnit.Framework;

namespace TennisePracetice
{
    public class Tests
    {
        private Tennis _tennis;

        [SetUp]
        public void SetUp()
        {
            _tennis = new Tennis();
        }

        [Test]
        public void LoveAll()
        {
            ScoreShouldBe("Love All");
        }

        [Test]
        public void FifteenLove()
        {
            GivenFirstPlayerScore(1);
            ScoreShouldBe("Fifteen Love");
        }

        [Test]
        public void ThirtyLove()
        {
            GivenFirstPlayerScore(2);
            ScoreShouldBe("Thirty Love");
        }

        [Test]
        public void FortyLove()
        {
            GivenFirstPlayerScore(3);
            ScoreShouldBe("Forty Love");
        }

        private void GivenFirstPlayerScore(int time)
        {
            for (int i = 0; i < time; i++)
            {
                _tennis.FirstPlayerScore();
            }
        }

        private void ScoreShouldBe(string expected)
        {
            Assert.AreEqual(expected, _tennis.Score());
        }
    }
}