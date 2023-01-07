using System;

namespace integrador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Bienvenido al formulario de inscripcion!\n");

            string[] cursadas = {"", "", ""};
            string[] cursos = { "Programacion .NET", "Programacion JAVA", "Programacion PHP" };
            
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

                    for (int i = 0; i < cursadas.Length; i++)
                    {
                        if (opc != 0 && cursadas[i].Equals(cursos[opc - 1]))
                        {
                            opc = 5;
                            break;
                        }
                    }

                    switch (opc)
                    {
                        case 1: 
                            Helper.posicionDisponible(cursadas, cursos, 0);
                            Console.WriteLine("Seleccionaste el curso de Programacion .NET\n");
                            break;
                        case 2: 
                            Console.WriteLine("Seleccionaste el curso de Programacion JAVA\n");
                            Helper.posicionDisponible(cursadas, cursos, 1); 
                            break;
                        case 3: 
                            Console.WriteLine("Seleccionaste el curso de Programacion PHP\n");
                            Helper.posicionDisponible(cursadas, cursos, 2); 
                            break;
                        case 5: Console.WriteLine("Ya seleccionaste esa cursada!\n"); break;
                        case 0: Console.WriteLine("Saliste correctamente de la seleccion de cursadas\n"); break;
                        default: Console.WriteLine("No existe el curso para la opcion seleccionada\n"); break;
                    }

                    if (opc != 0)
                    {
                        Console.WriteLine("Puede seguir eligiendo carreras o guardar y salir");
                        Console.Write("'S' para continuar, 'N' para guardar y salir: ");
                        string guardar = Console.ReadLine().ToUpper();

                        if (guardar.Equals("N"))
                        {
                            opc = 0;
                            Console.WriteLine("\nCursos guardados correctamente!\n");
                        }
                        else
                        {
                            Console.WriteLine("Presione 'Enter' para continuar");
                        }
                    }

                } while (opc != 0);
            }
            else
            {
                Console.WriteLine("Datos incorrectos. Ejecutar nuevamente la aplicacion");
            }

            Console.WriteLine("Constancia de incripcion");
            Console.WriteLine($"Alumno: {nombre} {apellido}");
            Console.WriteLine($"Correo electronico: {email}");
            Console.WriteLine("Cursadas:");
            for(int i = 0; i < cursadas.Length; i++)
            {
                Console.WriteLine(cursadas[i]);
            }
        }
    }

    class Helper
    {
        public static void posicionDisponible(string[] cursadas, string[] cursos, int posicion)
        {
            for (int i = 0; i < cursadas.Length; i++)
            {
                if (cursadas[i].Equals(""))
                {
                    cursadas[i] = cursos[posicion];
                    i = cursadas.Length;
                }
            }
        }
    }


}
