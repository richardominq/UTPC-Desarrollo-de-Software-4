// Programa 3: Entrada a un evento
// Validar la entrada a un evento comprobando la mayoría de edad, la posesión de un boleto y la validez del tipo de entrada.

using System;

namespace EventEntrySwitch
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

            // Process the authorization result using a modern switch expression with pattern matching.
            string entryMessage = (age, ticketQuantity, ticketType) switch
            {
                // Assign the authorized message when all conditions are met.
                (>= 18, >= 1, 1 or 2 or 3) => "Resultado: Entrada autorizada",
                
                // Assign the denied message when any condition fails.
                _ => "Resultado: Entrada rechazada"
            };

            // Display the final decision mapped by the switch expression on the console.
            Console.WriteLine(entryMessage);
        }
    }
}
