
using clase_11;

bool salir = false;

// Conexión a la base de datos
ConexionSqlite con = new ConexionSqlite("Data Source=C:\\Users\\aylli\\OneDrive\\Documents\\Programacion 1\\Progra 1 Github correcto\\clase-11\\base11.db");


while (!salir)
{
    Console.Clear();

    Console.WriteLine("MENU DE ALUMNOS:");
    Console.WriteLine("1. Crear alumno");
    Console.WriteLine("2. Listar alumnos");
    Console.WriteLine("3. Buscar alumno por carnet");
    Console.WriteLine("4. Eliminar alumno");
    Console.WriteLine("5. Salir");
    Console.Write("Seleccione una opcion: ");

    string opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":

            Console.Clear();
            Console.WriteLine("===== CREAR ALUMNO =====");

            Alumno nuevoAlumno = new Alumno();

            Console.Write("Carnet: ");
            nuevoAlumno.Carnet = Console.ReadLine();

            Console.Write("Nombres: ");
            nuevoAlumno.Nombres = Console.ReadLine();

            Console.Write("Apellidos: ");
            nuevoAlumno.Apellidos = Console.ReadLine();

            Console.Write("Correo: ");
            nuevoAlumno.Correo = Console.ReadLine();

            Console.Write("DPI: ");
            nuevoAlumno.DPI = Console.ReadLine();

            Console.Write("Telefono: ");
            nuevoAlumno.Telefono = Console.ReadLine();

            con.CrearAlumno(nuevoAlumno);

            Console.WriteLine("Alumno creado correctamente.");
            Console.ReadKey();

            break;

        case "2":

            Console.Clear();
            Console.WriteLine(" LISTA DE ALUMNOS:");

            List<Alumno> alumnos = con.ListarAlumnos();

            for (int i = 0; i < alumnos.Count; i++)
            {
                Console.WriteLine(
                    alumnos[i].Carnet + " - " +
                    alumnos[i].Nombres + " " +
                    alumnos[i].Apellidos
                );
            }

            Console.ReadKey();

            break;

        case "3":

            Console.Clear();
            Console.WriteLine(" BUSCAR ALUMNO ");

            Console.Write("Ingrese el carnet: ");
            string carnetBuscar = Console.ReadLine();

            Alumno alumnoEncontrado = con.AlumnoPorCarnet(carnetBuscar);

            if (alumnoEncontrado != null)
            {
                Console.WriteLine("\nAlumno encontrado:");
                Console.WriteLine("Carnet: " + alumnoEncontrado.Carnet);
                Console.WriteLine("Nombre: " + alumnoEncontrado.Nombres);
                Console.WriteLine("Apellidos: " + alumnoEncontrado.Apellidos);
                Console.WriteLine("Correo: " + alumnoEncontrado.Correo);
                Console.WriteLine("DPI: " + alumnoEncontrado.DPI);
                Console.WriteLine("Telefono: " + alumnoEncontrado.Telefono);
            }
            else
            {
                Console.WriteLine("Alumno no encontrado.");
            }

            Console.ReadKey();

            break;

        case "4":

            Console.Clear();
            Console.WriteLine(" ELIMINAR ALUMNO ");

            Console.Write("Ingrese el carnet: ");
            string carnetEliminar = Console.ReadLine();

            con.EliminarAlumno(carnetEliminar);

            Console.WriteLine("Alumno eliminado correctamente.");
            Console.ReadKey();

            break;

        case "5":

            salir = true;

            break;

        default:

            Console.WriteLine("Opcion invalida.");
            Console.ReadKey();

            break;
    }
}