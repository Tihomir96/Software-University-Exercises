
using System.Collections.Generic;

class PrimitiveCalculator
{
    private Dictionary<char, IStrategy>strategies=new Dictionary<char, IStrategy>()
    {
        { '+', new AdditionStrategy()},
        { '-', new SubtractionStrategy()},
        { '*', new MultiplyStrategy()},
        { '/', new DivideStrategy()},
    };
    private IStrategy strategy;
    public PrimitiveCalculator()
    {
        this.strategy = this.strategies['+'];
    }

    public void changeStrategy(char @operator)
    {
        this.strategy = strategies[@operator];
    }

    public int performCalculation(int firstOperand, int secondOperand)
    {
        return this.strategy.Calculate(firstOperand, secondOperand);
    }
}