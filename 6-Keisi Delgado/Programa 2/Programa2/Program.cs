using System;
using System.IO;

namespace ReporteEstacionamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            string placa;
            int horas;
            int tipoVehiculo;
            double tarifa = 0;
            string vehiculo = "";

            // Placa
            Console.Write("Ingrese la placa del vehículo: ");
            placa = Console.ReadLine();

            // Horas estacionado
            Console.Write("Ingrese la cantidad de horas estacionado: ");

            if (int.TryParse(Console.ReadLine(), out horas))
            {
                if (horas < 1 || horas > 24)
                {
                    Console.WriteLine("Las horas deben estar entre 1 y 24.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Debe ingresar un número válido.");
                return;
            }

            // Tipo de vehículo
            Console.Write("Ingrese el tipo de vehículo (1-Moto, 2-Auto, 3-Camioneta): ");

            if (int.TryParse(Console.ReadLine(), out tipoVehiculo))
            {
                if (tipoVehiculo < 1 || tipoVehiculo > 3)
                {
                    Console.WriteLine("El tipo de vehículo no es válido.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Debe ingresar un número.");
                return;
            }

            // Definir tarifa
            switch (tipoVehiculo)
            {
                case 1:
                    tarifa = 0.75;
                    vehiculo = "Moto";
                    break;

                case 2:
                    tarifa = 1.50;
                    vehiculo = "Auto";
                    break;

                case 3:
                    tarifa = 2.25;
                    vehiculo = "Camioneta";
                    break;

                default:
                    Console.WriteLine("Tipo de vehículo no válido.");
                    return;
            }

            // Cálculos
            double costoBase = horas * tarifa;
            double descuento = 0;

            if (horas > 8)
            {
                descuento = costoBase * 0.10;
            }

            double total = costoBase - descuento;

            // Mostrar resultados
            Console.WriteLine("\n--- REPORTE DE ESTACIONAMIENTO ---");
            Console.WriteLine("Placa: " + placa);
            Console.WriteLine("Tipo de vehículo: " + vehiculo);
            Console.WriteLine("Horas: " + horas);
            Console.WriteLine("Costo base: $" + costoBase.ToString("F2"));
            Console.WriteLine("Total a pagar: $" + total.ToString("F2"));

            // Fecha y hora
            DateTime fechaHora = DateTime.Now;

            // Crear reporte
            string reporte =
                "========== REPORTE DE ESTACIONAMIENTO ==========\n" +
                "Placa: " + placa + "\n" +
                "Tipo de vehículo: " + vehiculo + "\n" +
                "Horas estacionado: " + horas + "\n" +
                "Tarifa por hora: $" + tarifa.ToString("F2") + "\n" +
                "Costo base: $" + costoBase.ToString("F2") + "\n" +
                "Descuento: $" + descuento.ToString("F2") + "\n" +
                "Total a pagar: $" + total.ToString("F2") + "\n" +
                "Fecha y hora: " + fechaHora.ToString("dd/MM/yyyy HH:mm:ss") + "\n" +
                "================================================";

            // Guardar archivo
            File.WriteAllText("reporte_estacionamiento.txt", reporte);

            Console.WriteLine("\nEl reporte fue guardado en reporte_estacionamiento.txt");
        }
    }
}
