using NUnit.Framework;

namespace TennisPractice0506_2
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
        public void LoveAll()
        {
            ScoreShouldBe("Love All");
        }

        [Test]
        public void FifteenLove()
        {
            GivenFirstPlayerScoreTime(1);
            ScoreShouldBe("Fifteen Love");
        }

        [Test]
        public void ThirtyLove()
        {
            GivenFirstPlayerScoreTime(2);
            ScoreShouldBe("Thirty Love");
        }

        [Test]
        public void FortyLove()
        {
            GivenFirstPlayerScoreTime(3);
            ScoreShouldBe("Forty Love");
        }

        private void GivenFirstPlayerScoreTime(int times)
        {
            for (int i = 0; i < times; i++)
            {
                _tennis.FirstPlayerScoreTime();
            }
        }

        private void ScoreShouldBe(string ex)
        {
            Assert.AreEqual(ex, _tennis.Score());
        }
    }
}