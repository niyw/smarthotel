using NUnit.Framework;
using SmartHotel.Common;

namespace SmartHotel.Web.NIntegrationTests
{
    [TestFixture]
    public class NonPlayerCharacterTests
    {
        private NonPlayerCharacter _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new NonPlayerCharacter();
        }

        [Test]
        public void TakeDamageSuccess()
        {
            _sut.TakeDamage(0);
            Assert.AreEqual(100, _sut.Health);
        }       
        [TestCase(0, 100)]
        [TestCase(1, 99)]
        [TestCase(50, 50)]
        [TestCase(101, 1)]        
        public void TakeDamage(int damage, int expectedHealth)
        {
            _sut.TakeDamage(damage);
            Assert.AreEqual(expectedHealth, _sut.Health);            
        }
        [TearDown]
        public void Dispose() { }
    }
}