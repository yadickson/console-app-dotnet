namespace App
{
    internal class Program {
        private static void Main(string[] args) {
            Console.WriteLine("Hello, World!");
            Calc.ICalc calculator = new Calc.Calc();
            Console.WriteLine(calculator.Sum(1,2));
        }
    }
}
