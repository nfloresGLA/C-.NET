using System;

namespace integrador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Bienvenido al formulario de inscripcion!\n");            

            Console.Write("Ingresa tu nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingresa tu apellido: ");
            string apellido = Console.ReadLine();
            
            Console.Write("Ingresa tu edad: ");
            int edad = int.Parse(Console.ReadLine());

            Console.Write("Ingresa tu email: ");
            string email = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Los datos ingresados son:");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Apellido: " + apellido);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Email: " + email);
        }
    }
}
