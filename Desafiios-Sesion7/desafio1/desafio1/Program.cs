// See https://aka.ms/new-console-template for more information

using System;

class Calculadora {
    public string Marca;
    public string Serie;

    public int Sumar(int a, int b) => a + b;
    public int Restar(int a, int b) => a - b;
    public int Multiplicar(int a, int b) => a * b;
    public double Dividir(int a, int b) => (double)a / b;
}

class CalculadoraCientifica : Calculadora {
    public double Potencia(double a, double b) => Math.Pow(a, b);
    public double Raiz(double a) => Math.Sqrt(a);
    public int Modulo(int a, int b) => a % b;
    public double Logaritmo(double a) => Math.Log(a);
}

class Program {
    static void Main() {
        Calculadora calc = new Calculadora();
        Console.WriteLine("Suma: " + calc.Sumar(5, 3));

        CalculadoraCientifica cient = new CalculadoraCientifica();
        Console.WriteLine("Potencia: " + cient.Potencia(2, 4));
    }
}
