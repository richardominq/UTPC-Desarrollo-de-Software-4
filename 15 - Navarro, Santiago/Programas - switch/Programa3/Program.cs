
/*Programa 3: Entrada a un evento: Un sistema necesita verificar si una persona 
 * cumple las condiciones * necesarias para ingresar a un evento. Solicite la edad, 
 * la cantidad de boletos disponibles y el tipo de entrada (1 = General, 2 = VIP, 3 = Invitado). 
 * Si la persona tiene 18 años o más * y posee al menos un boleto y seleccionó como tipo de entrada 
 * la opción 1, 2 o 3, muestre * “Entrada autorizada” junto con el tipo seleccionado. De lo contrario, 
 * muestre “Entrada rechazada” * indicando que no cumple con las condiciones establecidas. 
 */

using System;
using System.Text;

namespace Programa3
{
    class Programa
    {
        static void Main(string[] args)
        {
            int edad = 0, cant_boletos = 0, opcion = 0;

            // Solicitar la edad
            Console.Write("Ingrese su edad: ");

            if (!int.TryParse(Console.ReadLine(), out edad))//validar que la edad sea un numero
            {
                Console.WriteLine("Error: debe ingresar un numero valido");
                return;
            }

            if (edad < 0)//validar que la edad no sea negativa
            {
                Console.WriteLine("Error: la edad no puede ser negativa");
                return;
            }

            // Solicitar la cantidad de boletos
            Console.Write("Ingrese la cantidad de boletos disponibles: ");

            if (!int.TryParse(Console.ReadLine(), out cant_boletos))
            {
                Console.WriteLine("Error: debe ingresar un numero valido");//validar que la cantidad de boletos sea un numero
                return;
            }

            if (cant_boletos < 0)
            {
                Console.WriteLine("Error: la cantidad de boletos no puede ser negativa");//validar que la cantidad de boletos no sea negativa
                return;
            }

            // Seleccionar el tipo de entrada
            Console.WriteLine("Seleccione cuál es su tipo de entrada:");
            Console.WriteLine("1 - General");
            Console.WriteLine("2 - VIP");
            Console.WriteLine("3 - Invitado");
            Console.Write("Opción seleccionada: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Error: debe ingresar un número.");
                return;
            }

            // Verificar el tipo de entrada
            switch (opcion)
            {
                case 1:
                    if (edad >= 18 && cant_boletos >= 1)
                    {
                        Console.WriteLine("Entrada autorizada");
                        Console.WriteLine("Tipo de entrada: General");
                    }
                    else
                    {
                        Console.WriteLine("Entrada rechazada, no cumple los requisitos");
                    }
                    break;

                case 2:
                    if (edad >= 18 && cant_boletos >= 1)
                    {
                        Console.WriteLine("Entrada autorizada");
                        Console.WriteLine("Tipo de entrada: VIP");
                    }
                    else
                    {
                        Console.WriteLine("Entrada rechazada, no cumple los requisitos");
                    }
                    break;

                case 3:
                    if (edad >= 18 && cant_boletos >= 1)
                    {
                        Console.WriteLine("Entrada autorizada");
                        Console.WriteLine("Tipo de entrada: Invitado");
                    }
                    else
                    {
                        Console.WriteLine("Entrada rechazada, no cumple los requisitos");
                    }
                    break;

                default:
                    Console.WriteLine("Opción incorrecta, debe seleccionar 1, 2 o 3");
                    break;
            }
        }
    }
}
