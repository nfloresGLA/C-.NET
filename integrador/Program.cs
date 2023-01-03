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

            Console.WriteLine("\n¿Los datos proporcionados son correctos?");
            Console.Write("'S' para confirmar, 'N' para cancelar la operacion: ");
            string datosValidos = Console.ReadLine().ToUpper();    

            if(datosValidos.Equals("S"))
            {
                Console.WriteLine("\nDatos guardados correctamente.");

                int opc;

                Console.WriteLine("\n¡Inscripcion de cursadas!");
                Console.WriteLine("Presione 'Enter' para continuar");
                do
                {
                    
                    Console.ReadKey();
                    Console.Clear();

                    Console.WriteLine("1. Programacion .NET");
                    Console.WriteLine("2. Programacion JAVA");
                    Console.WriteLine("3. Programacion PHP");
                    Console.WriteLine("0. Salir de la aplicacion");

                    Console.Write("Seleccione el codigo de la carrera elegida: ");
                    opc = int.Parse(Console.ReadLine());

                    Console.WriteLine();

                    switch (opc)
                    {
                        case 1: Console.WriteLine("Seleccionaste el curso de Programacion .NET"); break;
                        case 2: Console.WriteLine("Seleccionaste el curso de Programacion JAVA"); break;
                        case 3: Console.WriteLine("Seleccionaste el curso de Programacion PHP"); break;
                        default: Console.WriteLine("No existe el curso para la opcion seleccionada"); break;
                    }

                    if (opc != 0)
                    {
                        Console.WriteLine("Puede seguir eligiendo carreras o guardar y salir");
                        Console.WriteLine("Presione 'Enter' para continuar");
                    }

                } while (opc != 0);
            }
            else
            {
                Console.WriteLine("Datos incorrectos. Ejecutar nuevamente la aplicacion");
            }
        }
    }
}
