using Microsoft.Data.Sqlite;
using Dapper;

namespace clase_11;
public class ConexionSqlite
{
    private readonly SqliteConnection _conexion;

    public ConexionSqlite(string cadena)
    {
        _conexion = new SqliteConnection(cadena);
        ProbarConexion();
    }
    void ProbarConexion()
    { 
        try
        {
            _conexion.Open();
            Console.WriteLine("Conectado");
            _conexion.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Conexion ha fallado");
            Console.WriteLine(ex.Message);
        }
    }

    public void CrearAlumno(Alumno alumno)
    {
        _conexion.Open();
        string query =
            "INSERT INTO Alumno(Carnet,Nombres,Apellidos,Correo,DPI,Telefono) VALUES (@Carnet,@Nombres,@Apellidos,@Correo, @DPI, @Telefono)";
        _conexion.Execute(query, alumno);
        _conexion.Close();
        Console.WriteLine("alumno creado correctamente");
    }

    public List<Alumno> ListarAlumnos()
    {
        _conexion.Open();
        string query = "SELECT Carnet,Nombres,Apellidos,Correo,DPI,Telefono FROM Alumno";
        List<Alumno> alumnos = _conexion.Query<Alumno>(query).ToList();
        _conexion.Close();
        return alumnos;
    }

    public void EliminarAlumno(string carnet)
    {
        _conexion.Open();
        string query = "DELETE FROM Alumno WHERE Carnet = @Carnet";
        _conexion.Execute(query, new { Carnet = carnet });
        _conexion.Close();
        Console.WriteLine("Alumno eliminado correctamente");
    }

    public Alumno AlumnoPorCarnet(string carnet)
    {
        _conexion.Open();
        string query = "SELECT Carnet,Nombres,Apellidos,Correo,DPI,Telefono FROM Alumno Where Carnet = @Carnet";
        Alumno alumno = _conexion.QuerySingle<Alumno>(query, new {Carnet = carnet});
        _conexion.Close();
        return alumno;
    }
    
}