using NUnit.Framework;

namespace TennisPractice0816
{
    public class TestTennisPractice
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
        public void Fifteen_Love()
        {
            GivenFirstPlayerScore(1);
            ScoreShouldBe("Fifteen Love");
        }

        [Test]
        public void Thirty_Love()
        {
            GivenFirstPlayerScore(2);
            ScoreShouldBe("Thirty Love");
        }

        [Test]
        public void Forty_Love()
        {
            GivenFirstPlayerScore(3);
            ScoreShouldBe("Forty Love");
        }

        private void GivenFirstPlayerScore(int times)
        {
            for (int i = 0; i < times; i++)
            {
                _tennis.FirstPlayerTime();
            }
        }

        private void ScoreShouldBe(string expected)
        {
            Assert.That(_tennis.Score(), Is.EqualTo(expected));
        }
    }
}