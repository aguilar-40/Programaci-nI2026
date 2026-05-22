using System.Collections.Generic;
using System.Data.SqlClient;

namespace EscuelaApp2026
{
    public class AlumnoRepository
    {
        private ConexionDB conexion = new ConexionDB();

        public void Crear(Alumno alumno)
        {
            using var conn = conexion.GetConnection();
            conn.Open();
            var cmd = new SqlCommand("INSERT INTO Alumno (Nombre, Apellido, Correo) VALUES (@Nombre, @Apellido, @Correo)", conn);

            cmd.Parameters.AddWithValue("@Nombre", alumno.Nombre);
            cmd.Parameters.AddWithValue("@Apellido", alumno.Apellido);
            cmd.Parameters.AddWithValue("@Correo", alumno.Correo);
            cmd.ExecuteNonQuery();
        }

        public List<Alumno> Listar()
        {
            var lista = new List<Alumno>();
            using var conn = conexion.GetConnection();
            conn.Open();
            var cmd = new SqlCommand("SELECT Id, Nombre, Apellido, Correo FROM Alumno", conn);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lista.Add(new Alumno
                {
                    Id = reader.GetInt32(0),
                    Nombre = reader.GetString(1),
                    Apellido = reader.GetString(2),
                    Correo = reader.GetString(3)
                });
            }
            return lista;
        }

        public void Actualizar(Alumno alumno)
        {
            using var conn = conexion.GetConnection();
            conn.Open();
            var cmd = new SqlCommand("UPDATE Alumno SET Nombre=@Nombre, Apellido=@Apellido, Correo=@Correo WHERE Id=@Id", conn);
            cmd.Parameters.AddWithValue("@Id", alumno.Id);
            cmd.Parameters.AddWithValue("@Nombre", alumno.Nombre);
            cmd.Parameters.AddWithValue("@Apellido", alumno.Apellido);
            cmd.Parameters.AddWithValue("@Correo", alumno.Correo);
            cmd.ExecuteNonQuery();
        }

        public void Eliminar(int id)
        {
            using var conn = conexion.GetConnection();
            conn.Open();
            var cmd = new SqlCommand("DELETE FROM Alumno WHERE Id=@Id", conn);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.ExecuteNonQuery();
        }
    }
}
