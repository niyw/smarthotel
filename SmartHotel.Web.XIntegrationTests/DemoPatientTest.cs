using System;
using System.Collections.Generic;
using System.Text;
using SmartHotel.Common;
using Xunit;
using Xunit.Sdk;

namespace SmartHotel.Web.XIntegrationTests
{
    public class DemoPatientTest
    {
        [Fact]
        public void HaveHeartBeatWhenNew()
        {
            var patient = new Patient();

            Assert.True(patient.IsNew);
        }
        [Fact]
        public void CalculateFullName()
        {
            var p = new Patient
            {
                FirstName = "Nick",
                LastName = "Carter"
            };
            Assert.Equal("Nick Carter", p.FullName);
        }
        [Fact]
        public void CalculateFullNameStartsWithFirstName()
        {
            var p = new Patient
            {
                FirstName = "Nick",
                LastName = "Carter"
            };
            Assert.StartsWith("Nick", p.FullName);
        }

        [Fact]
        public void CalculateFullNameEndsWithFirstName()
        {
            var p = new Patient
            {
                FirstName = "Nick",
                LastName = "Carter"
            };
            Assert.EndsWith("Carter", p.FullName);
        }
        [Fact]
        public void CalculateFullNameSubstring()
        {
            var p = new Patient
            {
                FirstName = "Nick",
                LastName = "Carter"
            };
            Assert.Contains("ck Ca", p.FullName);
        }
        [Fact]
        public void CalculcateFullNameWithTitleCase()
        {
            var p = new Patient
            {
                FirstName = "Nick",
                LastName = "Carter"
            };
            Assert.DoesNotMatch("[A-Z]{1}{a-z}+ [A-Z]{1}[a-z]+", p.FullName);
        }
        [Fact]
        public void BloodSugarStartWithDefaultValue()
        {
            var p = new Patient();
            Assert.Equal(5.0, p.BloodSugar);
        }
        [Fact]
        public void BloodSugarIncreaseAfterDinner()
        {
            var p = new Patient();
            p.HaveDinner();
            Assert.InRange(p.BloodSugar, 5, 6);
        }

        [Fact]
        public void HaveCorrectSalary()
        {
            var plumber = new Plumber();
            Assert.NotEqual(66.666, plumber.Salary);
            Assert.NotEqual(66.666, plumber.Salary, precision: 3);
            Assert.Equal(66.667, plumber.Salary, precision: 3);
        }
        [Fact]
        public void NotHaveNameByDefault()
        {
            var plumber = new Plumber();
            Assert.Null(plumber.Name);
        }

        [Fact]
        public void HaveNameValue()
        {
            var plumber = new Plumber
            {
                Name = "Brian"
            };
            Assert.NotNull(plumber.Name);
        }
        [Fact]
        public void HaveScrewdriver()
        {
            var plumber = new Plumber();
            Assert.Contains("螺丝刀", plumber.Tools);
            Assert.DoesNotContain("键盘", plumber.Tools);
        }
        [Fact]
        public void HaveAllTools()
        {
            var plumber = new Plumber();
            var expectedTools = new[]
            {
                "螺丝刀",
                "扳子",
                "钳子"
            };
            Assert.Equal(expectedTools, plumber.Tools);
        }
        [Fact]
        public void HaveNoEmptyDefaultTools()
        {
            var plumber = new Plumber();
            Assert.All(plumber.Tools, t => Assert.False(string.IsNullOrEmpty(t)));
        }
        [Fact]
        public void CreatePlumberByDefault()
        {
            var factory = new WorkerFactory();
            Worker worker = factory.Create("Nick");
            Assert.IsType<Plumber>(worker);
        }

        [Fact]
        public void CreateProgrammerAndCastReturnedType()
        {
            var factory = new WorkerFactory();
            Worker worker = factory.Create("Nick", isProgrammer: true);
            Programmer programmer = Assert.IsType<Programmer>(worker);
            Assert.Equal("Nick", programmer.Name);
        }
        [Fact]
        public void CreateProgrammer_AssertAssignableTypes()
        {
            var factory = new WorkerFactory();
            Worker worker = factory.Create("Nick", isProgrammer: true);
            Assert.IsType<Worker>(worker);
        }
        [Fact]
        public void CreateSeperateInstances()
        {
            var factory = new WorkerFactory();
            var p1 = factory.Create("Nick");
            var p2 = factory.Create("Nick");
            Assert.NotSame(p1, p2);
        }
        [Fact]
        public void NotAllowNullName()
        {
            var factory = new WorkerFactory();
            Assert.Throws<ArgumentNullException>(() => factory.Create(null));
            Assert.Throws<ArgumentNullException>("name", () => factory.Create(null));
        }
    }
}
