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

            // Verificar que la edad sea de 18 años o más
            if (edad >= 18)

                // Verificar que haya al menos un boleto
                if (boletosDisponibles >= 1)

                    // Verificar que el tipo de entrada sea válido
                    if (tipoEntrada == 1 | tipoEntrada == 2 | tipoEntrada == 3)
                    {
                        // Se cumplen todas las condiciones
                        Console.WriteLine("Entrada autorizada");
                    }
                    else
                    {
                        // El tipo de entrada no es válido
                        Console.WriteLine("Entrada rechazada");
                    }
                else
                {
                    // No hay boletos disponibles
                    Console.WriteLine("Entrada rechazada");
                }
            else
            {
                // La persona es menor de 18 años
                Console.WriteLine("Entrada rechazada");
                Console.WriteLine("No cumple con las condiciones establecidas.");
            }
        }
    }
}
