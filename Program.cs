internal class Program
    {
        static void Main(string[] args)
        {
        CalculatorService op = new CalculatorService(CalcOps.add);
      
        Console.WriteLine("First paramater: ");
        var arg1 = Console.ReadLine();
        int num1 = int.Parse(arg1);

        Console.WriteLine("second paramater: ");
        var arg2 = Console.ReadLine();
        int num2 = int.Parse(arg2);

        Console.WriteLine("1-add");
        Console.WriteLine("2-subtract");
        Console.WriteLine("3-multiply");
        Console.WriteLine("4-divide");

        Console.WriteLine("select an operationt: ");
        var choice = Console.ReadLine();
        
        switch (choice)
        {
            case "1":
                op._op = CalcOps.add;
                Console.WriteLine(op.compute(num1,num2));
                break;
            case "2":
                op._op = CalcOps.subtract;
                Console.WriteLine(op.compute(num1,num2));
                break;
            case "3":
                op._op = CalcOps.multiply;
                Console.WriteLine(op.compute(num1,num2));
                break;
            case "4":
                op._op = CalcOps.divide;
                Console.WriteLine(op.compute(num1,num2));
                break;
            default:
                Console.WriteLine("Invalid");
                break ;

        }
        }
    }
