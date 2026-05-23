// See https://aka.ms/new-console-template for more information

//             DESAFIO NO,2
//Crea un Método que reciba como parámetro una arreglo bidimensional,
// el cual contenga por cada fila un listado de montos de las ultimas 5 
// compras de 5 clientes. el programa debe calcular el total de compras de cada
// cliente y otorgar un descuento segun las siguientes reglas"
using System;

class Program
{
    static void Main()
    {
        int[,] compras = {
            { 50, 20, 30, 10, 40 },
            { 200, 150, 100, 50, 80 },
            { 500, 300, 200, 100, 50 },
            { 1000, 200, 150, 100, 50 },
            { 1200, 300, 400, 200, 100 }
        };

        CalcularTotales(compras);
    }
    
    static void CalcularTotales(int[,] datos)
    {
        for (int i = 0; i < datos.GetLength(0); i++) 
        {
            int total = 0;
            for (int j = 0; j < datos.GetLength(1); j++) 
            {
                total += datos[i, j];
            }

           
            double descuento = 0;
            if (total >= 100 && total <= 1000)
                descuento = total * 0.10;
            else if (total > 1000)
                descuento = total * 0.20;

            Console.WriteLine($"Cliente {i+1}: Total = {total}, Descuento = {descuento}, Paga = {total - descuento}");
        }
    };
