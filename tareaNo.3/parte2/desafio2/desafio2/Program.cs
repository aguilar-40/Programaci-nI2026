// See https://aka.ms/new-console-template for more information

/*DESAFIO NO.2
 Crea una aplicación que maneje los puntajes de un juego imaginario. Tendrá un puntaje, un puntaje record y 
 un jugador record.
Crea un método que tenga dos parámetros, uno para el puntaje obtenido y otro para el nombre del jugador.

Cuando se llama a ese método, se debe verificar si el puntaje del jugador es mayor que la puntuación más alta,
si es así, que se escriba en la consola algo así como"La nueva puntuación más alta es " + puntuación.
Y en otra línea "La puntuación más alta fue lograda por " + nombre del jugador.

Si no fue así, entonces que se escriba algo como "La puntuación más alta de " + puntuación más alta + " 
no se ha podido superar, y aún está en manos de " + jugador record.
Considera qué variables se requieren globalmente y cuáles localmente.*/
using System;

class Program
{
 // Variables globales
 static int puntajeRecord = 0;
 static string jugadorRecord = "";

 static void Main(string[] args)
 {
  // Ejemplo de llamadas al método
  VerificarPuntaje(50, "Aylin");
  VerificarPuntaje(30, "Carlos");
  VerificarPuntaje(80, "María");

  Console.Read();
 }
 static void VerificarPuntaje(int puntaje, string jugador)
 {
  if (puntaje > puntajeRecord)
  {
   puntajeRecord = puntaje;
   jugadorRecord = jugador;
   Console.WriteLine("La nueva puntuación más alta es " + puntaje);
   Console.WriteLine("La puntuación más alta fue lograda por " + jugador);
  }
  else
  {
   Console.WriteLine("La puntuación más alta de " + puntajeRecord +
                     " no se ha podido superar, y aún está en manos de " + jugadorRecord);
  }
 }
}
