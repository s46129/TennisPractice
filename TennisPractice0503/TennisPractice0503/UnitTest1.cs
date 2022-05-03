using NUnit.Framework;

namespace TennisPractice0503
{
    public class TennisPractice
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
            FirstPlayerTime(1);
            ScoreShouldBe("Fifteen Love");
        }

        [Test]
        public void ThirtyLove()
        {
            FirstPlayerTime(2);
            ScoreShouldBe("Thirty Love");
        }

        [Test]
        public void FortyLove()
        {
            FirstPlayerTime(3);
            ScoreShouldBe("Forty Love");
        }

        private void FirstPlayerTime(int time)
        {
            for (int i = 0; i < time; i++)
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