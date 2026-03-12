// See https://aka.ms/new-console-template for more information
/*DESAFIO NO.1
Crear un método static, que pida los ingresos de los últimos 3 meses, así como el nombre del usuario e imprima 
en pantalla la suma de todos los ingresos y un promedio con un mensaje similiar a "Hola <usuario> en total
ganaste suma y promediaste promedio ". */

using System;

class Program
{
    static void Main(string[] args)
    {
        // Pedir nombre del usuario
        Console.WriteLine("Por favor, ingresa tu nombre:");
        string nombre = Console.ReadLine();

        // Pedir ingresos de los últimos 3 meses
        Console.WriteLine("Ingresa tu ingreso del primer mes:");
        double ingreso1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingresa tu ingreso del segundo mes:");
        double ingreso2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingresa tu ingreso del tercer mes:");
        double ingreso3 = double.Parse(Console.ReadLine());

        // Calcular suma y promedio
        double suma = ingreso1 + ingreso2 + ingreso3;
        double promedio = suma / 3;

        // Mostrar resultado
        Console.WriteLine("Hola " + nombre + ", en total ganaste " + suma + " y promediaste " + promedio);

        Console.Read();
    }
}
