using System;
using System.IO;

namespace Estacionamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            // inputs
            // Ask the user for the vehicle's license plate
            Console.WriteLine("--- Cobro de Estacionamiento ---");
            Console.Write("Ingrese la placa del vehículo: ");
            string licensePlate = Console.ReadLine();

            // Ask for parked hours and validate using if-else
            Console.Write("Ingrese la cantidad de horas estacionado: ");
            if (!int.TryParse(Console.ReadLine(), out int hours) || hours < 1 || hours > 24)
            {
                Console.WriteLine("Error: La cantidad de horas debe estar entre 1 y 24.");
                return;
            }

            // Ask for the vehicle type and validate the selection
            Console.WriteLine("Tipo de vehículo:\n1 = Moto\n2 = Auto\n3 = Camioneta");
            Console.Write("Seleccione el tipo de vehículo (1-3): ");
            if (!int.TryParse(Console.ReadLine(), out int vehicleType) || vehicleType < 1 || vehicleType > 3)
            {
                Console.WriteLine("Error: Tipo de vehículo no válido.");
                return;
            }

            // Determine the hourly rate based on the vehicle type using a switch statement
            double hourlyRate = 0;
            string typeStr = "";
            switch (vehicleType)
            {
                case 1:
                    hourlyRate = 0.75; typeStr = "Moto"; break;
                case 2:
                    hourlyRate = 1.50; typeStr = "Auto"; break;
                case 3:
                    hourlyRate = 2.25; typeStr = "Camioneta"; break;
            }

            // Perform calculations: compute base cost based on hours parked
            double baseCost = hours * hourlyRate;
            double discount = 0;
            
            // Apply a 10% discount if the vehicle was parked for more than 8 hours
            if (hours > 8)
            {
                discount = baseCost * 0.10;
            }
            double totalToPay = baseCost - discount;

            // Output
            Console.WriteLine("\n--- Resumen de Cobro ---");
            Console.WriteLine($"Costo base: ${baseCost:F2}");
            Console.WriteLine($"Total a pagar (con posible descuento): ${totalToPay:F2}");

            // Save the transaction details to a text file
            string filename = "reporte_estacionamiento.txt";
            using (StreamWriter sw = new StreamWriter(filename, true)) // StreamWriter
            {
                sw.WriteLine("---------------------------------------");
                sw.WriteLine($"Fecha y hora: {DateTime.Now}"); // Log date and time
                sw.WriteLine($"Placa del vehículo: {licensePlate}");
                sw.WriteLine($"Horas estacionado: {hours}");
                sw.WriteLine($"Tipo de vehículo: {typeStr}");
                sw.WriteLine($"Costo base: ${baseCost:F2}");
                sw.WriteLine($"Descuento aplicado: ${discount:F2}");
                sw.WriteLine($"Total a pagar: ${totalToPay:F2}");
                sw.WriteLine("---------------------------------------\n");
            }

            Console.WriteLine($"\nLos datos se han guardado en {filename}");
        }
    }
}
