using TesztIsmetles;

namespace IdoTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(720,12)]
        [TestCase(600,10)]
        [TestCase(300,5)]
        
        public void MinuteToSecTest(int elvartsec,int perc)
        {
            var sec=IdoKonverter.MinuteToSec(perc);
            //Assert.AreEqual(elvartsec, sec);

            Assert.That(sec,Is.EqualTo(elvartsec));
        }
    }
}