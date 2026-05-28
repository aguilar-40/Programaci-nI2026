namespace clase_11;

//Sirve para mappear los datos de la tabla en la base de datos
//hacia una clase de C#
public class Alumno
{
    public string Carnet { get; set; }
    public string Nombres { get; set; }
    public string Apellidos { get; set; }
    public string DPI  { get; set; }
    public string Telefono { get; set; }
    public string Correo { get; set; }
}