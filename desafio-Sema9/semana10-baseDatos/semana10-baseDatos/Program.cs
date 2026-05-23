using Microsoft.Data.Sqlite;


ProbarConexion();

return;

static void ProbarConexion()
{
    using SqliteConnection connection = new SqliteConnection("Data Source =C:\\Users\\aylli\\OneDrive\\Documents\\Programacion 1\\ ejemploDataBase.db");
    try
    {
        connection.Open();
        Console.WriteLine("Conectado");
        connection.Close();
    }
    catch (Exception ex)
    {
        Console.WriteLine("Coneccion ha fallar");
        Console.WriteLine(ex.Message);
        throw;
    }
}