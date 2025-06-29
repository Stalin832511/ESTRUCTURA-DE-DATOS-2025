using System;
using RegistroEstudiantes; // <- Esto tiene que ir antes de la declaración de la clase

class Program
{
    static void Main(string[] args)
    {
        Estudiante[] estudiantes = new Estudiante[2];
        
        estudiantes[0] = new Estudiante(1, "Juan Carlos", "Pérez López", "Av. Siempre Viva 123", new string[] { "0991234567", "0987654321", "0971122334" });
        estudiantes[1] = new Estudiante(2, "María Fernanda", "Gómez Sánchez", "Calle Falsa 456", new string[] { "0999988776", "0988776655", "0977443322" });

        foreach (var estudiante in estudiantes)
        {
            estudiante.MostrarInfo();
            Console.WriteLine("----------------------------");
        }
    }
}
