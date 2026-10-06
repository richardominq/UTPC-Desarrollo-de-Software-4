using System;
namespace Basics
{

    class Program
    {
        static void Main()
        {
            // Solicitar datos al usuario
            Console.Write("Ingrese la placa del vehículo: ");
            string placa = Console.ReadLine();

            Console.Write("Ingrese la cantidad de horas estacionado: ");
            int horas = Convert.ToInt32(Console.ReadLine());

            // Solicitar tipo de vehículo
            Console.WriteLine("Tipo de vehículo:");
            Console.WriteLine("1 = Moto");
            Console.WriteLine("2 = Auto");
            Console.WriteLine("3 = Camioneta");
            Console.Write("Ingrese el tipo de vehículo: ");
            int tipoVehiculo = Convert.ToInt32(Console.ReadLine());

            // Comprobar que las horas estén entre 1 y 24
            if (horas < 1 || horas > 24)
            {
                Console.WriteLine("Las horas deben estar entre 1 y 24.");
                return;
            }
            else
            {
                double tarifa = 0;
                string tipoTexto = "";

                // Definir la tarifa
                switch (tipoVehiculo)
                {
                    case 1:
                        tarifa = 0.75;
                        tipoTexto = "Moto";
                        break;

                    case 2:
                        tarifa = 1.50;
                        tipoTexto = "Auto";
                        break;

                    case 3:
                        tarifa = 2.25;
                        tipoTexto = "Camioneta";
                        break;

                    default:
                        Console.WriteLine("Tipo de vehículo no válido.");
                        return;
                }

                // Calcular costo base
                double costoBase = horas * tarifa;

                // Aplicar descuento del 10% si supera 8 horas
                double total = costoBase;

                if (horas > 8)
                {
                    total = costoBase - (costoBase * 0.10);
                }

                // Fecha y hora
                DateTime fechaHora = DateTime.Now;

                // Crear reporte
                string reporte =
                    "===== REPORTE DE ESTACIONAMIENTO =====\n" +
                    "Placa: " + placa + "\n" +
                    "Horas estacionado: " + horas + "\n" +
                    "Tipo de vehículo: " + tipoTexto + "\n" +
                    "Tarifa por hora: $" + tarifa.ToString("F2") + "\n" +
                    "Costo base: $" + costoBase.ToString("F2") + "\n" +
                    "Total a pagar: $" + total.ToString("F2") + "\n" +
                    "Fecha y hora: " + fechaHora.ToString("dd/MM/yyyy HH:mm:ss");

                
                File.WriteAllText("reporte_estacionamiento.txt", reporte);

                Console.WriteLine("\nEl reporte se guardó correctamente.");

                System.Diagnostics.Process.Start("notepad.exe", "reporte_estacionamiento.txt");
            }
        }
    }
}