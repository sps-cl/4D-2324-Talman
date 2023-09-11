using System;

class Calculator {

    public static void Main (string[] args) {

        Console.WriteLine("Zadej 2 čísla: ");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());

        Operator operace = new Operator(a, b);

    }
}

class Operator(float a, float b) {

    private float a;
    private float b;

    public void ConstructorBuilder (float a, float b) {
        this.a = a;
        this.b = b;
    }

    public static int Add() {
        return a + b;
    }

    public static int Subtract(int a, int b) {
        return a - b;
    }

    public static int Multiply(int a, int b) {
        return a * b;
    }

    public static int Divide(int a, int b) {
        return a / b;
    }

    public static int Modulo(int a, int b) {
        return a % b;
    }

    public static int Power(int a, int b) {
        return (int)Math.Pow(a, b);
    }

}