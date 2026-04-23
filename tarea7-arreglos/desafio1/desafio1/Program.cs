// See https://aka.ms/new-console-template for more information

// DESAFIO NO.1
//Crear una copia del juego ToTiTo usando arreglos de múltiples dimensiones.
 
using System;

class Program
{
    static void Main()
    {
        string[,] tablero = {
            { "-", "-", "-" },
            { "-", "-", "-" },
            { "-", "-", "-" }
        };

        string jugador = "X";

        for (int turno = 0; turno < 9; turno++)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{tablero[i,0]} {tablero[i,1]} {tablero[i,2]}");
            }

        
            Console.WriteLine($"Jugador {jugador}, ingresa fila y columna (0-2):");
            int fila = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());

           
            if (tablero[fila,col] == "-")
                tablero[fila,col] = jugador;
            else
                turno--; 

           
            jugador = (jugador == "X") ? "O" : "X";
        }
    }
}
