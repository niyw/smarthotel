using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmartHotel.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHotel.Common.Tests
{
    [TestClass()]
    public class NonPlayerCharacterTests
    {
        public TestContext TestContext { get; set; }

        private readonly NonPlayerCharacter _sut;
        public NonPlayerCharacterTests()
        {
            _sut = new NonPlayerCharacter();
        }
        [TestMethod()]
        public void TakeDamageSuccess()
        {
            _sut.TakeDamage(0);
            Assert.AreEqual<int>(100, _sut.Health);
        }
        [DataTestMethod]
        [DataRow(0, 100)]
        [DataRow(1, 99)]
        [DataRow(50, 50)]
        [DataRow(101, 1)]
        public void TakeDamage(int damage, int expectedHealth)
        {
            _sut.TakeDamage(damage);
            Assert.AreEqual<int>(expectedHealth, _sut.Health);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"|DataDirectory|\data\TestData.csv", "data#csv", DataAccessMethod.Sequential)]
        public void TakeDamageFromCsv()
        {
            //int damage = Int32.Parse(TestContext.DataRow["damage"].ToString());
            //int health = Int32.Parse(TestContext.DataRow["health"].ToString());
            var damage = 0;
            var health = 100;
            _sut.TakeDamage(damage);
            Assert.AreEqual<int>(health, _sut.Health);
        }
    }
}