internal class Program
    {
        static void Main(string[] args)
        {
        CalculatorService op = new CalculatorService(CalcOps.add);
        double x = op.compute(5, 5);
        Console.WriteLine(x);
        }
    }
