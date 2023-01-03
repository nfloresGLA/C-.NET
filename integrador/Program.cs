using System;

namespace integrador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre, apellido, email;
            int edad;

            Console.WriteLine("¡Bienvenido al formulario de inscripcion!\n");            

            Console.Write("Ingresa tu nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Ingresa tu apellido: ");
            apellido = Console.ReadLine();

            Console.Write("Ingresa tu edad: ");
            edad = int.Parse(Console.ReadLine());

            Console.Write("Ingresa tu email: ");
            email = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Los datos ingresados son:");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Nombre: " + apellido);
            Console.WriteLine("Nombre: " + edad);
            Console.WriteLine("Nombre: " + email);
        }
    }
}
