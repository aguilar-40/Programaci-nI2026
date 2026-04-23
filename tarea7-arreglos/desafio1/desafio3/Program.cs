// See https://aka.ms/new-console-template for more information

//           DESAFIO NO,3
//Se te ha encargado realices una aplicacion con la que el usuario pueda crear una lista de
//tareas por realizar. Debe crear un menu con las siguientes operaciones

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> tareas = new List<string>();
        int opcion;

        do
        {
            Console.WriteLine("\n MENU:");
            Console.WriteLine("1. Mostrar");
            Console.WriteLine("2. Agregar");
            Console.WriteLine("3. Eliminar");
            Console.WriteLine("4. Salir");
            Console.Write("Elige una opción: ");
            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                Console.WriteLine("Tareas:");
                if (tareas.Count == 0) Console.WriteLine("No hay tareas.");
                else
                {
                    for (int i = 0; i < tareas.Count; i++)
                        Console.WriteLine($"{i+1}. {tareas[i]}");
                }
            }
            else if (opcion == 2)
            {
                Console.Write("Nueva tarea: ");
                string nueva = Console.ReadLine();
                tareas.Add(nueva);
            }
            else if (opcion == 3)
            {
                Console.Write("Número de tarea a eliminar: ");
                int num = int.Parse(Console.ReadLine());
                if (num > 0 && num <= tareas.Count)
                    tareas.RemoveAt(num-1);
                else
                    Console.WriteLine("Número inválido.");
            }

        } while (opcion != 4);
    }
}

