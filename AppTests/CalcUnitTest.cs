using NUnit.Framework;
using App;

namespace App.UnitTests
{
    public class CalcUnitTest
    {
        private ICalc calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calc();
        }

        [Test]
        public void ShouldCheckSum()
        {
            int aValue = Faker.RandomNumber.Next(0, 10);
            int bValue = Faker.RandomNumber.Next(20, 30);
            int response = calculator.Sum(aValue, bValue);
            Assert.That(response, Is.EqualTo(aValue + bValue));
        }
    }
}