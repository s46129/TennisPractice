using NUnit.Framework;

namespace TennisPractice_4
{
    [TestFixture]
    public class TennisPractice
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
            ScoreSholdBe("Love All");
        }

        [Test]
        public void FifteenLove()
        {
            GivenFirstPlayerScore(1);
            ScoreSholdBe("Fifteen Love");
        }

        [Test]
        public void ThirtyLove()
        {
            GivenFirstPlayerScore(2);
            ScoreSholdBe("Thirty Love");
        }

        [Test]
        public void FortyLove()
        {
            GivenFirstPlayerScore(3);
            ScoreSholdBe("Forty Love");
        }

        private void GivenFirstPlayerScore(int times)
        {
            for (int i = 0; i < times; i++)
            {
                _tennis.FirstPlayerScoreTime();
            }
        }

        private void ScoreSholdBe(string expected)
        {
            Assert.AreEqual(expected, _tennis.Score());
        }
    }
}