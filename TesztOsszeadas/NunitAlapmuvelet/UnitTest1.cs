using TesztAlapmuveletek;
namespace NunitAlapmuvelet
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        //[TestCase(10,20,30)]
        //[TestCase(20,20,40)]
        //[TestCase(50,50,100)]
        [TestCaseSource("GetOsszeadasAdatok")]
        public void OsszeadTest(double a,double b,double elvart)
        {
            //Arrange
            Alapmuvelet alapmuvelet = new Alapmuvelet();

            //Act
            var eredmeny = alapmuvelet.Osszead(a, b);

            //Assert
            Assert.AreEqual(elvart, eredmeny);
            
        }

        public static IEnumerable<double[]> GetOsszeadasAdatok()
        {
            var sorok = File.ReadAllLines("tesztesetek_osszeadas.csv");
            for (int i = 0; i < sorok.Length; i++)
            {
                var adatok = sorok[i].Split(';');
                double a = Convert.ToDouble(adatok[0]);
                double b = Convert.ToDouble(adatok[1]);
                double elvart= Convert.ToDouble(adatok[2]);

                yield return new[] { a, b, elvart };
            }

        }

        [Test]
        public void KivonTest()
        {
            Alapmuvelet alapmuvelet=new Alapmuvelet();
            var eredmeny = alapmuvelet.Kivon(100, 50);
            Assert.AreEqual(50, eredmeny);
        }

        [Test]
        [TestCase(12.56768, 8.774535345, 1.432290088)]
        public void OsztasTeszt(double a,double b,double elvart)
        {
            Alapmuvelet alapmuvelet = new Alapmuvelet();
            var eredmeny = alapmuvelet.Oszt(a, b);
            Assert.AreEqual(elvart, eredmeny,0.0001);
        }
    }
}