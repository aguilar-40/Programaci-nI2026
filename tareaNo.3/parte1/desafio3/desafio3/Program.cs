// See https://aka.ms/new-console-template for more information
/*DESAFIO NO.3
Crear un método static, que pida dos valores de entrada, los cuales debe convertir a entero y sumarlos, 
este método debe estar en un bloque Try-Catch-Finally y mostrar un mensaje de Error si sucede algún 
fallo durante la ejecución (por ejemplo si el valor introducido es un texto en lugar de un número o sí
 el valor introducido esta en blanco).
 */
using System;

class Program
{
    static void Main(string[] args)
    {
        SumarDosValores();
        Console.Read();
    }
    static void SumarDosValores()
    {
        try
        {
            Console.WriteLine("Ingresa el primer número:");
            int num1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingresa el segundo número:");
            int num2 = int.Parse(Console.ReadLine());
            
            int suma = num1 + num2;
            Console.WriteLine("La suma es: " + suma);
        }
        catch
        {
            Console.WriteLine("Error: el valor ingresado no es válido.");
        }
        finally
        {
            Console.WriteLine("Fin del programa.");
        }
    }
}
