using System;
using System.IO;

namespace FacturaElectrica
{
    class Program
    {
        static void Main(string[] args)
        {
            // inputs
            // Ask the user for the customer's name
            Console.WriteLine("--- Cálculo de Factura Eléctrica ---");
            Console.Write("Ingrese el nombre del cliente: ");
            string name = Console.ReadLine();

            // Ask for the consumed kilowatts and validate using if-else
            Console.Write("Ingrese la cantidad de kilovatios consumidos (kWh): ");
            if (!double.TryParse(Console.ReadLine(), out double kwh) || kwh <= 0)
            {
                Console.WriteLine("Error: El consumo de kilovatios debe ser mayor que cero.");
                return;
            }

            // Ask for the customer type and validate the selection
            Console.WriteLine("Tipo de cliente:\n1 = Residencial\n2 = Comercial\n3 = Industrial");
            Console.Write("Seleccione el tipo de cliente (1-3): ");
            if (!int.TryParse(Console.ReadLine(), out int customerType) || customerType < 1 || customerType > 3)
            {
                Console.WriteLine("Error: Tipo de cliente no válido.");
                return;
            }

            // Determine the rate per kWh based on the customer type using a switch statement
            double rate = 0;
            string typeStr = "";
            switch (customerType)
            {
                case 1:
                    rate = 0.15; typeStr = "Residencial"; break;
                case 2:
                    rate = 0.22; typeStr = "Comercial"; break;
                case 3: 
                    rate = 0.30; typeStr = "Industrial"; break;
            }

            // calculations subtotal and apply a 7% surcharge
            double subtotal = kwh * rate;
            double surcharge = subtotal * 0.07;
            double totalToPay = subtotal + surcharge;

            // Output
            Console.WriteLine("\n--- Resumen de Facturación ---");
            Console.WriteLine($"Subtotal: ${subtotal:F2}");
            Console.WriteLine($"Total a pagar (incluye 7% de recargo): ${totalToPay:F2}");

            // Save the transaction details to a text file
            string filename = "factura_electrica.txt";
            using (StreamWriter sw = new StreamWriter(filename, true)) // StreamWriter
            {
                sw.WriteLine("---------------------------------------");
                sw.WriteLine($"Fecha y hora: {DateTime.Now}"); // Log date and time
                sw.WriteLine($"Cliente: {name}");
                sw.WriteLine($"Consumo: {kwh} kWh");
                sw.WriteLine($"Tipo de cliente: {typeStr}");
                sw.WriteLine($"Subtotal: ${subtotal:F2}");
                sw.WriteLine($"Total a pagar: ${totalToPay:F2}");
                sw.WriteLine("---------------------------------------\n");
            }

            Console.WriteLine($"\nLos resultados se han guardado en {filename}");
        }
    }
}
