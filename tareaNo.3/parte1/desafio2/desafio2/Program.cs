// See https://aka.ms/new-console-template for more information

/*DESAFIO NO.2
Crear una clase que contenga 4 métodos que realicen las operaciones básicas (Sumar, Restar, Multiplicar, Dividir),
 debe pedir como parámetro dos números de tipo int y retornar un valor del mismo tipo. 
Debe invocar los 4 métodos desde el método main.*/

using System;

class Program
{
    static int Sumar(int a, int b)
    {
        return a + b;
    }
    static int Restar(int a, int b)
    {
        return a - b;
    }
    static int Multiplicar(int a, int b)
    {
        return a * b;
    }
    static int Dividir(int a, int b)
    {
        return a / b;
    }

    static void Main(string[] args)
    {
        int num1 = 10;
        int num2 = 5;

        Console.WriteLine("Suma: " + Sumar(num1, num2));
        Console.WriteLine("Resta: " + Restar(num1, num2));
        Console.WriteLine("Multiplicación: " + Multiplicar(num1, num2));
        Console.WriteLine("División: " + Dividir(num1, num2));

        Console.Read();
    }
}
