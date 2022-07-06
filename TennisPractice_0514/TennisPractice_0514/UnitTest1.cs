using NUnit.Framework;

namespace TennisPractice_0514
{
    public class Tests
    {
        [SetUp]
        public void SetUp()
        {
            _tennis = new Tennis();
        }

        private Tennis _tennis;

        [Test]
        public void Love_All()
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

        private void GivenFirstPlayerScore(int Times)
        {
            for (int i = 0; i < Times; i++)
            {
                _tennis.FirstPlayerScoreTime();
            }
        }

        private void ScoreShouldBe(string expected)
        {
            Assert.AreEqual(expected, _tennis.Score());
        }
    }
}