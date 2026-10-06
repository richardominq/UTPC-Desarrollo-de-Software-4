using System;
using System.IO;

namespace VentaBoletos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for the buyer's name
            Console.WriteLine("--- Venta de Boletos ---");
            Console.Write("Ingrese el nombre del comprador: ");
            string buyer = Console.ReadLine();

            // Ask for ticket quantity and validate using if-else
            Console.Write("Ingrese la cantidad de boletos a comprar: ");
            if (!int.TryParse(Console.ReadLine(), out int ticketQuantity) || ticketQuantity < 1 || ticketQuantity > 10)
            {
                Console.WriteLine("Error: La cantidad de boletos debe estar entre 1 y 10.");
                return;
            }

            // Ask for the ticket category and validate the selection
            Console.WriteLine("Categoría:\n1 = General\n2 = Preferencial\n3 = VIP");
            Console.Write("Seleccione la categoría (1-3): ");
            if (!int.TryParse(Console.ReadLine(), out int category) || category < 1 || category > 3)
            {
                Console.WriteLine("Error: Categoría no válida.");
                return;
            }

            // Determine the unit price based on the selected category using a switch statement
            double unitPrice = 0;
            string categoryStr = "";
            switch (category)
            {
                case 1:
                    unitPrice = 15.00; categoryStr = "General"; break;
                case 2:
                    unitPrice = 30.00; categoryStr = "Preferencial"; break;
                case 3:
                    unitPrice = 50.00; categoryStr = "VIP"; break;
            }

            // calculations
            double subtotal = ticketQuantity * unitPrice;
            double discount = 0;
            
            // Apply a 12% discount if purchasing 5 or more tickets
            if (ticketQuantity >= 5)
            {
                discount = subtotal * 0.12;
            }
            double finalTotal = subtotal - discount;

            // Output
            Console.WriteLine("\n--- Resumen de Compra ---");
            Console.WriteLine($"Subtotal: ${subtotal:F2}");
            Console.WriteLine($"Total final a pagar: ${finalTotal:F2}");

            // Save the transaction details to a text file
            string filename = "reporte_boletos.txt";
            using (StreamWriter sw = new StreamWriter(filename, true)) // StreamWriter
            {
                sw.WriteLine("---------------------------------------");
                sw.WriteLine($"Fecha y hora: {DateTime.Now}"); // Log date and time
                sw.WriteLine($"Comprador: {buyer}");
                sw.WriteLine($"Categoría: {categoryStr}");
                sw.WriteLine($"Cantidad de boletos: {ticketQuantity}");
                sw.WriteLine($"Subtotal: ${subtotal:F2}");
                sw.WriteLine($"Descuento aplicado: ${discount:F2}");
                sw.WriteLine($"Total a pagar: ${finalTotal:F2}");
                sw.WriteLine("---------------------------------------\n");
            }

            Console.WriteLine($"\nLos datos se han guardado en {filename}");
        }
    }
}
