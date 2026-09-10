// Programa 1: Descuento en una tienda
// Determinar si un cliente recibe un descuento del 15 % evaluando el monto de su compra y su tipo de cliente.

using System;

namespace StoreDiscountIf
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

            // Check whether the purchase amount and customer type meet the discount requirements.
            if (purchaseAmount > 100 && (customerType == 2 || customerType == 3))
            {
                // Calculate the final amount after applying a 15% discount.
                double finalAmount = purchaseAmount * 0.85;

                // Display the discounted amount the customer must pay.
                Console.WriteLine($"Monto final: ${finalAmount:F2}");
            }
            else
            {
                // Inform the customer that no discount is applied and show the original amount.
                Console.WriteLine("No recibe descuento.");
                Console.WriteLine($"Monto final: ${purchaseAmount:F2}");
            }
        }
    }
}
