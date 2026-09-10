// Programa 1: Descuento en una tienda
// Determinar si un cliente recibe un descuento del 15 % evaluando el monto de su compra y su tipo de cliente.

using System;

namespace StoreDiscountSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the total purchase amount entered by the user.
            Console.Write("Ingrese el monto total de la compra: ");
            double purchaseAmount = double.Parse(Console.ReadLine());

            // Read the customer type to evaluate discount eligibility.
            Console.WriteLine("Tipos de cliente: 1 = Regular, 2 = Frecuente, 3 = VIP");
            Console.Write("Ingrese el tipo de cliente: ");
            int customerType = int.Parse(Console.ReadLine());

            // Evaluate the condition using pattern matching within the switch statement.
            switch (purchaseAmount, customerType)
            {
                case (> 100, 2 or 3):
                    // Calculate and display the final amount with a 15% discount.
                    double finalAmount = purchaseAmount * 0.85;
                    Console.WriteLine($"Monto final: ${finalAmount:F2}");
                    break;
                
                default:
                    // Inform the user that the original amount remains unchanged.
                    Console.WriteLine("No recibe descuento.");
                    Console.WriteLine($"Monto final: ${purchaseAmount:F2}");
                    break;
            }
        }
    }
}
