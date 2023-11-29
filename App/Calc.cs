namespace App {
    public class Calc:  ICalc {
        int ICalc.Sum(int a, int b)
        {
            return a + b;
        }
    }
}