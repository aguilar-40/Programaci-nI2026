// See https://aka.ms/new-console-template for more information


using System;
using System.Text.RegularExpressions;

class Program {
    static void Main() {
        string texto = "Este es mi correo electrónico: juan_perez.23@gmail.com. Por favor, envíeme un correo con sus comentarios.";
        
        string patron = @"[a-zA-Z0-9._-]+@[a-zA-Z.]+\.[a-z]{2,}";

        MatchCollection correos = Regex.Matches(texto, patron);

        foreach (Match correo in correos) {
            Console.WriteLine(correo.Value);
        }
    }
}