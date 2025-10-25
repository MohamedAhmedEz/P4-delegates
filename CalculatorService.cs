public delegate double OP(double num1, double num2);
public class CalculatorService
{

    public OP _op;
    public CalculatorService(OP operation)
    {
        _op = operation;
    }
    
    public double compute (double num1,double num2)
    {
        return _op(num1, num2);
    }

}