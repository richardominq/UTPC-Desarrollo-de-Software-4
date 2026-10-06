using System;
using System.IO;

namespace ReporteEstacionamiento_P2
{
  internal class Program
  {
    static void Main(string[] args)
    {
      string placa;
      int horas;
      int tipoVehiculo;
      double tarifa = 0;
      string nombreTipoVehiculo = "";
      double costoBase;
      double descuento = 0;
      double total;

      Console.WriteLine("Ingrese la placa del vehículo: ");
      placa = Console.ReadLine();

      Console.WriteLine("Ingrese la cantidad de horas estacionado: ");
      horas = int.Parse(Console.ReadLine());

      Console.WriteLine("Ingrese el tipo de vehículo (1 = Moto, 2 = Auto, 3 = Camioneta): ");
      tipoVehiculo = int.Parse(Console.ReadLine());

      if (horas >= 1 && horas <= 24)
      {
        switch (tipoVehiculo)
        {
          case 1:
            tarifa = 0.75;
            nombreTipoVehiculo = "Moto";
            break;

          case 2:
            tarifa = 1.50;
            nombreTipoVehiculo = "Auto";
            break;

          case 3:
            tarifa = 2.25;
            nombreTipoVehiculo = "Camioneta";
            break;

          default:
            Console.WriteLine("Tipo de vehículo no válido");
            return;
        }

        costoBase = horas * tarifa;

        if (horas > 8)
        {
          descuento = costoBase * 0.10;
        }

        total = costoBase - descuento;

        Console.WriteLine();
 
        Console.WriteLine($"Costo base: {costoBase:f2}");
        Console.WriteLine($"Total a pagar: {total:f2}");

        string filePath = "reporte_estacionamiento.txt";

        File.AppendAllText(filePath,
            $"Fecha y hora: {DateTime.Now}" +
            $"\nPlaca: {placa}" +
            $"\nHoras estacionado: {horas}" +
            $"\nTipo de vehículo: {nombreTipoVehiculo}" +
            $"\nTarifa por hora: {tarifa:f2}" +
            $"\nCosto base: {costoBase:f2}" +
            $"\nDescuento (10%): {descuento:f2}" +
            $"\nTotal a pagar: {total:f2}" +
            "\n-----------------------------\n"
        );

        Console.WriteLine();
        Console.WriteLine("El reporte ha sido guardado correctamente.");
        Console.WriteLine($"UbicaciOn: {Path.GetFullPath(filePath)}");
      }
      else
      {
        Console.WriteLine("Error: las horas deben estar entre 1 y 24.");
      }
    }
  }
}
