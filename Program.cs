using System;

// Definición de la clase Estudiante
public class Estudiante
{
    public int id { get; set; }
    public required string nombres { get; set; }
    public required string apellidos { get; set; }
    public required string direccion { get; set; }
    public string[] telefonos { get; set; } = new string[3];

    // Método para mostrar los datos del estudiante en consola
    public void MostrarDatos()
    {
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Nombres: " + nombres);
        Console.WriteLine("Apellidos: " + apellidos);
        Console.WriteLine("Dirección: " + direccion);
        Console.WriteLine("Teléfonos:");
        // Itera sobre el arreglo de teléfonos y los muestra uno por uno
        for (int i = 0; i < telefonos.Length; i++)
        {
            Console.WriteLine($"  Teléfono {i + 1}: {telefonos[i]}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Instancia de la clase Estudiante
        Estudiante estudiante = new Estudiante
        {
            id = 1,
            nombres = "Christian Gonzalo",
            apellidos = "Peña Ramos",
            direccion = "Quito",
            telefonos = new string[] { "09888888888", "0966666666", "0991234569" }
        };

        //Llamada de la función para mostrar los datos
        estudiante.MostrarDatos();
    }
}
