using System;
namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaración de variables
            int edad;
            int boletosDisponibles;
            int tipoEntrada;

            // Solicitar la edad
            Console.Write("Ingrese la edad: ");
            edad = int.Parse(Console.ReadLine());

            // Solicitar la cantidad de boletos
            Console.Write("Ingrese la cantidad de boletos disponibles: ");
            boletosDisponibles = int.Parse(Console.ReadLine());

            // Mostrar las opciones de entrada
            Console.WriteLine("1 = General");
            Console.WriteLine("2 = VIP");
            Console.WriteLine("3 = Invitado");

            // Solicitar el tipo de entrada
            Console.Write("Ingrese el tipo de entrada: ");
            tipoEntrada = int.Parse(Console.ReadLine());

            // Evaluar el tipo de entrada seleccionado
            switch (tipoEntrada)
            {
                case 1:

                    // Verificar la edad y la cantidad de boletos
                    if (edad >= 18 & boletosDisponibles >= 1)
                    {
                        // Se cumplen las condiciones
                        Console.WriteLine("Entrada autorizada");
                        Console.WriteLine("Tipo de entrada seleccionado: General");
                    }
                    else
                    {
                        // No se cumplen las condiciones
                        Console.WriteLine("Entrada rechazada");
                        Console.WriteLine("No cumple con las condiciones establecidas.");
                    }

                    break;

                case 2:

                    // Verificar la edad y la cantidad de boletos
                    if (edad >= 18 & boletosDisponibles >= 1)
                    {
                        // Se cumplen las condiciones
                        Console.WriteLine("Entrada autorizada");
                        Console.WriteLine("Tipo de entrada seleccionado: VIP");
                    }
                    else
                    {
                        // No se cumplen las condiciones
                        Console.WriteLine("Entrada rechazada");
                        Console.WriteLine("No cumple con las condiciones establecidas.");
                    }

                    break;

                case 3:

                    // Verificar la edad y la cantidad de boletos
                    if (edad >= 18 & boletosDisponibles >= 1)
                    {
                        // Se cumplen las condiciones
                        Console.WriteLine("Entrada autorizada");
                        Console.WriteLine("Tipo de entrada seleccionado: Invitado");
                    }
                    else
                    {
                        // No se cumplen las condiciones
                        Console.WriteLine("Entrada rechazada");
                        Console.WriteLine("No cumple con las condiciones establecidas.");
                    }

                    break;

                default:

                    // Mostrar mensaje si el tipo de entrada no es válido
                    Console.WriteLine("Tipo de entrada no válido.");

                    break;
            }
        }
    }
}
