using System;


public interface IOperation {
    double Execute(double a, double b);
}

public class OpAdd : IOperation {
    public double Execute(double a, double b) {
        return a + b;
    }
}

public class OpSub : IOperation {
    public double Execute(double a, double b) {
        return a - b;
    }
}

public class OpMagic : IOperation {
    public double Execute(double a, double b) {
        return a * b / 2;
    }
}


public class CalculatorContext {
    public IOperation operation;

    public CalculatorContext(IOperation operation) {
        this.operation = operation;
    }

    public double ExecuteOperation(double a, double b) {
        return operation.Execute(a, b);
    }
}


class CalculatorApp {
    static void Main() {

        IOperation addOperation = new OpAdd();
        IOperation subOperation = new OpSub();
        IOperation magicOperation = new OpMagic();
        
        CalculatorContext calculator = new CalculatorContext(addOperation);

        Console.WriteLine("Zadej prvni číslo: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Zadej druhé číslo: ");
        double b = Convert.ToDouble(Console.ReadLine());

        double result = calculator.ExecuteOperation(a, b);
        Console.WriteLine("Výsledek sčítání: " + result);

        calculator.operation = subOperation;

        result = calculator.ExecuteOperation(a, b);
        Console.WriteLine("Výsledek odčítání: " + result);

        calculator.operation = magicOperation;

        result = calculator.ExecuteOperation(a, b);
        Console.WriteLine("Výsledek magické operace: " + result);
    }
}
