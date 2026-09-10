using System;
using System.IO;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaración de variables
            string placa;
            int horas;
            int TipoVehiculo;

            // Solicita la placa del vehículo
            Console.Write("Ingrese la placa del vehiculo: ");
            placa = Console.ReadLine();

            // Solicita las horas estacionado
            Console.Write("Ingrese la cantidad de horas estacionado: ");
            horas = int.Parse(Console.ReadLine());

            // Tipo de vehículo
            Console.WriteLine("Tipo de vehiculo");
            Console.WriteLine("1= Moto");
            Console.WriteLine("2= Auto");
            Console.WriteLine("3= Camioneta");

            Console.Write("Ingrese el tipo de vehiculo: ");
            TipoVehiculo = Convert.ToInt32(Console.ReadLine());

            // Valida que las horas estén entre 1 y 24
            if (horas < 1 || horas > 24)
            {
                Console.WriteLine("Las horas deben estar entre 1 y 24");
                return;
            }
            else
            {
                double tarifa = 0;
                string TipoTexto = "";

                // Define la tarifa según el tipo de vehículo
                switch (TipoVehiculo)
                {
                    case 1:
                        tarifa = 0.75;
                        TipoTexto = "Moto";
                        break;

                    case 2:
                        tarifa = 1.50;
                        TipoTexto = "Auto";
                        break;

                    case 3:
                        tarifa = 2.25;
                        TipoTexto = "Camioneta";
                        break;

                    default:
                        Console.WriteLine("Opcion invalida");
                        return;
                }

                // Operación 1: calcular costo base
                double costoBase = horas * tarifa;

                // Operación 2: aplicar descuento si estuvo más de 8 horas
                double descuento = 0;

                if (horas > 8)
                {
                    descuento = costoBase * 0.10;
                }

                double totalPagar = costoBase - descuento;

                // Fecha y hora del reporte
                DateTime fechahora = DateTime.Now;

                // Crear reporte
                string reporte =
                "Reporte de Estacionamiento \n" +
                "Placa del vehiculo: " + placa + "\n" +
                "Horas estacionado: " + horas + "\n" +
                "Tipo de vehiculo: " + TipoTexto + "\n" +
                "Tarifa por hora: $" + tarifa.ToString("F2") + "\n" +
                "Costo base: $" + costoBase.ToString("F2") + "\n" +
                "Descuento aplicado: $" + descuento.ToString("F2") + "\n" +
                "Total a pagar: $" + totalPagar.ToString("F2") + "\n" +
                "Fecha y hora: " + fechahora.ToString("dd/MM/yy HH:mm:ss") + "\n";

                // Guardar reporte
                File.WriteAllText("reporte_estacionamiento.txt", reporte);

                // Mostrar las dos salidas solicitadas
                Console.WriteLine("Costo base: $" + costoBase.ToString("F2"));
                Console.WriteLine("Total a pagar: $" + totalPagar.ToString("F2"));

                Console.WriteLine("El reporte se guardo correctamente.");

                // Abrir automáticamente el archivo
                System.Diagnostics.Process.Start("notepad.exe", "reporte_estacionamiento.txt");

            }
        }
    }
}