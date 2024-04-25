using KRHash;

namespace NunitTestHash
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("Valami, bármi", "1404eadac631988d5e13d5f1e9cf9361")]
        [TestCase("Valami, bármi", "1404eadac631988d5e13d5f1e9cf9361")]
        [TestCase("Valami, bármi", "1404eadac631988d5e13d5f1e9cf9361")]
        [TestCase("Valami, bármi", "1404eadac631988d5e13d5f1e9cf9361")]
        [TestCase("Valami, bármi", "1404eadac631988d5e13d5f1e9cf9361")]
        [TestCase("Valami, bármi", "1404eadac631988d5e13d5f1e9cf9361")]
        [TestCase("Valami, bármi", "1404eadac631988d5e13d5f1e9cf9361")]
        [TestCase("Valami, bármi", "1404eadac631988d5e13d5f1e9cf9361")]
        [TestCase("Valami, bármi", "1404eadac631988d5e13d5f1e9cf9361")]
        [TestCase("Valami, bármi", "1404eadac631988d5e13d5f1e9cf9361")]
        [TestCase("Valami, bármi", "1404eadac631988d5e13d5f1e9cf9361")]
        [TestCase("Valami, bármi", "1404eadac631988d5e13d5f1e9cf9361")]
        [TestCase("Valami, bármi", "1404eadac631988d5e13d5f1e9cf9361")]
        [TestCase("Valami, bármi", "1404eadac631988d5e13d5f1e9cf9361")]
        [TestCase("Valami, bármi", "1404eadac631988d5e13d5f1e9cf9361")]
        [TestCase("Valami, bármi", "1404eadac631988d5e13d5f1e9cf9361")]
        [TestCase("Valami, bármi", "1404eadac631988d5e13d5f1e9cf9361")]
        [TestCase("Valami, bármi", "1404eadac631988d5e13d5f1e9cf9361")]
        [TestCase("nunit tesztprojekt", "b71b021fb411bc81264c798cd6b3cd80")]
        [TestCase("nunit tesztprojekt", "b71b021fb411bc81264c798cd6b3cd80")]
        [TestCase("nunit tesztprojekt", "b71b021fb411bc81264c798cd6b3cd80")]
        [TestCase("nunit tesztprojekt", "b71b021fb411bc81264c798cd6b3cd80")]
        [TestCase("nunit tesztprojekt", "b71b021fb411bc81264c798cd6b3cd80")]
        [TestCase("nunit tesztprojekt", "b71b021fb411bc81264c798cd6b3cd80")]
        [TestCase("nunit tesztprojekt", "b71b021fb411bc81264c798cd6b3cd80")]
        [TestCase("nunit tesztprojekt", "b71b021fb411bc81264c798cd6b3cd80")]

        public void Md5HashTest(string szoveg,string elvartHash)
        {
            CreateHash hash = new CreateHash();
            var generaltHash=hash.MakeHash(HashType.MD5,szoveg);

            Assert.AreEqual(elvartHash, generaltHash);
        }
    }
}