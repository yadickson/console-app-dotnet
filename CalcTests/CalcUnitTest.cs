namespace CalcTests;

public class CalcUnitTest
{
    private Calc.ICalc calculator;

    [SetUp]
    public void Setup()
    {
        calculator = new Calc.Calc();
    }

    [Test]
    public void ShouldCheckSumResponse()
    {
        int lefthValue = Faker.RandomNumber.Next(10, 15);
        int rightValue = Faker.RandomNumber.Next(20, 25);
        
        int expected = lefthValue + rightValue;

        int result = calculator.Sum(lefthValue, rightValue);

        Assert.That(result, Is.EqualTo(expected));
    }
}