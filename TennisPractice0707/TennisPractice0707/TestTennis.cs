using NUnit.Framework;

namespace TennisPractice0707
{
    public class TestTennis
    {
        [SetUp]
        public void SetUp()
        {
            _tennis = new Tennis();
        }

        private Tennis? _tennis;

        [Test]
        public void Love_All()
        {
            ScoreSuildBe("Leve All");
        }

        [Test]
        public void Fifteen_Love()
        {
            GivenFirstPlayerScore(1);
            ScoreSuildBe("Fifteen Love");
        }

        [Test]
        public void Thirty_Love()
        {
            GivenFirstPlayerScore(2);
            ScoreSuildBe("Thirty Love");
        }

        [Test]
        public void Forty_Love()
        {
            GivenFirstPlayerScore(3);
            ScoreSuildBe("Forty Love");
        }

        private void GivenFirstPlayerScore(int times)
        {
            for (int i = 0; i < times; i++)
            {
                _tennis.FirstPlayerScoreTime();
            }
        }

        private void ScoreSuildBe(string expected)
        {
            Assert.AreEqual(expected, _tennis.Score());
        }
    }
}