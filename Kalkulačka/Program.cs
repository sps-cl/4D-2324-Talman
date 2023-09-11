using System;

class Calculator {

    public static void Main (string[] args) {

        Console.WriteLine("Zadej 1. číslo: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Zadej 2. číslo: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Operator operace = new Operator(a, b);

        Console.WriteLine("Zadej operaci: ");
        string operaceStr = "";
        try {
            operaceStr = Console.ReadLine();
        } catch (Exception e) {
            Console.WriteLine(e.Message);
        }

        if (operaceStr == "+") {
            Console.WriteLine(operace.Add());
        } else if (operaceStr == "-") {
            Console.WriteLine(operace.Subtract());
        } else if (operaceStr == "*") {
            Console.WriteLine(operace.Multiply());
        } else if (operaceStr == "/") {
            Console.WriteLine(operace.Divide());
        } else if (operaceStr == "%") {
            Console.WriteLine(operace.Modulo());
        } else if (operaceStr == "^") {
            Console.WriteLine(operace.Power());
        }
    }
}

class Operator {

    private int a;
    private int b;

    public Operator (int a, int b) {
        this.a = a;
        this.b = b;
    }

    public int Add() {
        return a + b;
    }

    public int Subtract() {
        return a - b;
    }

    public int Multiply() {
        return a * b;
    }

    public int Divide() {
        return a / b;
    }

    public int Modulo() {
        return a % b;
    }

    public int Power() {
        return (int)Math.Pow(a, b);
    }

}