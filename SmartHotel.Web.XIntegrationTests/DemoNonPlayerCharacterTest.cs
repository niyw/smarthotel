using SmartHotel.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using Xunit;
using Xunit.Sdk;

namespace SmartHotel.Web.XIntegrationTests
{
    public class DemoNonPlayerCharacterTest
    {
        private readonly NonPlayerCharacter _sut;
        public DemoNonPlayerCharacterTest() {
            _sut = new NonPlayerCharacter();
        }
        [Fact]
        public void TakeZeroDamage()
        {
            _sut.TakeDamage(0);
            Assert.Equal(100, _sut.Health);
        }

        [Fact]
        public void TakeSmallDamage()
        {
            _sut.TakeDamage(1);
            Assert.Equal(99, _sut.Health);
        }

        [Fact]
        public void TakeMediumDamage()
        {
            _sut.TakeDamage(50);
            Assert.Equal(50, _sut.Health);
        }

        [Fact]
        public void TakeMinimum1Damage()
        {
            _sut.TakeDamage(101);
            Assert.Equal(1, _sut.Health);
        }

        [Theory]
        [InlineData(0, 100)]
        [InlineData(1, 99)]
        [InlineData(50, 50)]
        [InlineData(101, 1)]
        public void TakeDamage(int damage, int expectedHealth)
        {
            _sut.TakeDamage(damage);
            Assert.Equal(expectedHealth, _sut.Health);
        }

        [Theory]
        [MemberData(nameof(InternalHealthDamageTestData.TestData), MemberType = typeof(InternalHealthDamageTestData))]
        public void TakeDamageShare(int damage, int expectedHealth)
        {
            _sut.TakeDamage(damage);
            Assert.Equal(expectedHealth, _sut.Health);
        }
        [Theory]
        [MemberData(nameof(ExternalHealthDamageTestData.TestData), MemberType = typeof(ExternalHealthDamageTestData))]
        public void TakeDamageCsv(int damage, int expectedHealth)
        {
            NonPlayerCharacter sut = new NonPlayerCharacter();

            sut.TakeDamage(damage);

            Assert.Equal(expectedHealth, sut.Health);
        }

        [Theory]
        [HealthDamageData]
        public void TakeDamageDataAttribute(int damage, int expectedHealth)
        {
            NonPlayerCharacter sut = new NonPlayerCharacter();

            sut.TakeDamage(damage);

            Assert.Equal(expectedHealth, sut.Health);
        }
    }

    public class InternalHealthDamageTestData
    {
        private static readonly List<object[]> Data = new List<object[]>
        {
            new object[] {0, 100},
            new object[] {1, 99},
            new object[] {50, 50},
            new object[] {101, 1}
        };

        public static IEnumerable<object[]> TestData => Data;
    }

    public class ExternalHealthDamageTestData
    {
        public static IEnumerable<object[]> TestData
        {
            get
            {
                string[] csvLines = File.ReadAllLines("Data\\TestData.csv");
                var testCases = new List<object[]>();
                foreach (var csvLine in csvLines)
                {
                    IEnumerable<int> values = csvLine.Split(',').Select(int.Parse);
                    object[] testCase = values.Cast<object>().ToArray();
                    testCases.Add(testCase);
                }
                return testCases;
            }
        }
    }

    public class HealthDamageDataAttribute : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            yield return new object[] { 0, 100 };
            yield return new object[] { 1, 99 };
            yield return new object[] { 50, 50 };
            yield return new object[] { 101, 1 };
        }
    }
}
