// See https://aka.ms/new-console-template for more information

using System;

namespace EscuelaApp2026
{
    class Program
    {
        static void Main(string[] args)
        {
            var repo = new AlumnoRepository();
            int opcion;
            do
            {
                Console.WriteLine("\nMantenimiento de Alumnos:");
                Console.WriteLine("1. Crear alumno");
                Console.WriteLine("2. Listar alumnos");
                Console.WriteLine("3. Actualizar alumno");
                Console.WriteLine("4. Eliminar alumno");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine() ?? "0");

                switch (opcion)
                {
                    case 1:
                        Console.Write("Nombre: ");
                        string nombre = Console.ReadLine() ?? string.Empty;
                        Console.Write("Apellido: ");
                        string apellido = Console.ReadLine() ?? string.Empty;
                        Console.Write("Correo: ");
                        string correo = Console.ReadLine() ?? string.Empty;
                        repo.Crear(new Alumno { Nombre = nombre, Apellido = apellido, Correo = correo });
                        Console.WriteLine("Alumno creado.");
                        break;

                    case 2:
                        var alumnos = repo.Listar();
                        foreach (var a in alumnos)
                            Console.WriteLine($"{a.Id} - {a.Nombre} {a.Apellido} - {a.Correo}");
                        break;

                    case 3:
                        Console.Write("Id del alumno: ");
                        int idUpdate = int.Parse(Console.ReadLine() ?? "0");
                        Console.Write("Nuevo nombre: ");
                        string nNombre = Console.ReadLine() ?? string.Empty;
                        Console.Write("Nuevo apellido: ");
                        string nApellido = Console.ReadLine() ?? string.Empty;
                        Console.Write("Nuevo correo: ");
                        string nCorreo = Console.ReadLine() ?? string.Empty;
                        repo.Actualizar(new Alumno { Id = idUpdate, Nombre = nNombre, Apellido = nApellido, Correo = nCorreo });
                        Console.WriteLine("Alumno actualizado.");
                        break;

                    case 4:
                        Console.Write("Id del alumno a eliminar: ");
                        int idDelete = int.Parse(Console.ReadLine() ?? "0");
                        repo.Eliminar(idDelete);
                        Console.WriteLine("Alumno eliminado.");
                        break;
                }

            } while (opcion != 5);
        }
    }
}
