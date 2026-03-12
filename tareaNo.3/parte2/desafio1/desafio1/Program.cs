// See https://aka.ms/new-console-template for more information
/*DESAFIO NO.1
 Crea un sistema de inicio de sesión de usuario, donde el usuario puede primero registrarse y luego iniciar sesión.
 El programa debe verificar si el usuario ha ingresado el nombre de usuario y la contraseña correctos al
 iniciar sesión (por lo tanto, los mismos que utilizó al registrarse).
Utiliza declaraciones If, ingresos del usuario y métodos para resolver el desafío.
*/
using System;

class Program
{
 static string usuarioRegistrado = "";
 static string contraseñaRegistrada = "";

 static void Main(string[] args)
 {
  RegistrarUsuario();
  IniciarSesion();
  Console.Read();
 }
 static void RegistrarUsuario()
 {
  Console.WriteLine("Registro de Usuario");
  Console.Write("Ingresa tu nombre de usuario: ");
  usuarioRegistrado = Console.ReadLine();

  Console.Write("Ingresa tu contraseña: ");
  contraseñaRegistrada = Console.ReadLine();

  Console.WriteLine("Registro exitoso!\n");
 }
 static void IniciarSesion()
 {
  Console.WriteLine("Inicio de Sesión");
  Console.Write("Usuario: ");
  string usuario = Console.ReadLine();

  Console.Write("Contraseña: ");
  string contraseña = Console.ReadLine();

  if (usuario == usuarioRegistrado && contraseña == contraseñaRegistrada)
  {
   Console.WriteLine("¡Bienvenid@, " + usuario + "!");
  }
  else
  {
   Console.WriteLine("Error: usuario o contraseña incorrectos.");
  }
 }
}
