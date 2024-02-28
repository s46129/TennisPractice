using NUnit.Framework;

namespace TennisPractice20240228
{
    public class TennisPractice
    {
        private Tennis _tennis;

        [SetUp]
        public void SetUp()
        {
            _tennis = new Tennis();
        }

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
            for (var i = 0; i < times; i++) _tennis.FirstPlayerScore();
        }

        private void ScoreShouldBe(string expected)
        {
            Assert.AreEqual(expected, _tennis.FistPlayerScore());
        }
    }
}