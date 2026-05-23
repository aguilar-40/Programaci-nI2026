// See https://aka.ms/new-console-template for more information

using System;

interface INotificable {
    void Notifica(string mensaje);
}

class NotificacionEmail : INotificable {
    public string direccionCorreo;
    public void Notifica(string mensaje) {
        Console.WriteLine($"Email a {direccionCorreo}: {mensaje}");
    }
}

class NotificacionWhatsap : INotificable {
    public string numeroTelefono;
    public void Notifica(string mensaje) {
        Console.WriteLine($"WhatsApp a {numeroTelefono}: {mensaje}");
    }
}

class NotificacionSMS : INotificable {
    public string numeroTelefono;
    public void Notifica(string mensaje) {
        Console.WriteLine($"SMS a {numeroTelefono}: {mensaje}");
    }
}

class Program {
    static void Main() {
        NotificacionEmail email = new NotificacionEmail { direccionCorreo = "correo@ejemplo.com" };
        email.Notifica("Hola por Email!");

        NotificacionWhatsap whatsapp = new NotificacionWhatsap { numeroTelefono = "555-1234" };
        whatsapp.Notifica("Hola por WhatsApp!");

        NotificacionSMS sms = new NotificacionSMS { numeroTelefono = "555-5678" };
        sms.Notifica("Hola por SMS!");
    }
}
