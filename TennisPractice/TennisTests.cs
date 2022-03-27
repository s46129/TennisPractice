using NUnit.Framework;

namespace TennisPractice
{
    [TestFixture]
    public class TennisTests
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
            ScoreShuldBe("Love All");
        }

        [Test]
        public void Fifteen_Love()
        {
            GivenFirstPlayerScore(1);
            ScoreShuldBe("Fifteen Love");
        }

        [Test]
        public void Thirty_Love()
        {
            GivenFirstPlayerScore(2);
            ScoreShuldBe("Thirty Love");
        }

        private void GivenFirstPlayerScore(int times)
        {
            for (int i = 0; i < times; i++)
            {
                _tennis.FirstPlayerScore();
            }
        }

        private void ScoreShuldBe(string expected)
        {
            Assert.AreEqual(expected, _tennis.Score());
        }
    }
}