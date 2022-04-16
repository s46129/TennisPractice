using NUnit.Framework;

namespace PracticeTennis0417
{
    public class PracticeTennis0417
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
            ScoreSuoldBe("Love All");
        }

        [Test]
        public void fifteenLove()
        {
            GivenFirstPlayerScore(1);
            ScoreSuoldBe("Fifteen Love");
        }

        [Test]
        public void ThirtyLove()
        {
            GivenFirstPlayerScore(2);
            ScoreSuoldBe("Thirty Love");
        }

        [Test]
        public void FortyLove()
        {
            GivenFirstPlayerScore(3);
            ScoreSuoldBe("Forty Love");
        }

        private void GivenFirstPlayerScore(int time)
        {
            for (int i = 0; i < time; i++)
            {
                _tennis.FirstPlayerScore();
            }
        }

        private void ScoreSuoldBe(string expected)
        {
            Assert.AreEqual(expected, _tennis.Score());
        }
    }
}