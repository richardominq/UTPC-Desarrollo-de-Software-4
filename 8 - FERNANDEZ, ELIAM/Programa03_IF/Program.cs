// Programa 3: Entrada a un evento
// Validar la entrada a un evento comprobando la mayoría de edad, la posesión de un boleto y la validez del tipo de entrada.

using System;

namespace EventEntryIf
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to input their age for age restriction checks.
            Console.Write("Ingrese su edad: ");
            int age = int.Parse(Console.ReadLine());

            // Ask the user to input the number of available tickets they hold.
            Console.Write("Ingrese la cantidad de boletos disponibles: ");
            int ticketQuantity = int.Parse(Console.ReadLine());

            // Ask the user to input the specific ticket type they possess.
            Console.WriteLine("Tipos de entrada: 1 = General, 2 = VIP, 3 = Invitado");
            Console.Write("Ingrese el tipo de entrada: ");
            int ticketType = int.Parse(Console.ReadLine());

            // Verify if age, ticket quantity, and ticket type meet the entry requirements.
            if (age >= 18 && ticketQuantity >= 1 && (ticketType == 1 || ticketType == 2 || ticketType == 3))
            {
                // Grant access to the event because all conditions are successfully met.
                Console.WriteLine("Resultado: Entrada autorizada");
            }
            else
            {
                // Deny access to the event due to failing one or more mandatory conditions.
                Console.WriteLine("Resultado: Entrada rechazada");
            }
        }
    }
}
