

using System;
using System.IO;

class ConsoleApp2
{
    static void Main (string[] args)
    {
        string filePath = @"C:\Users\Estudiantes\Documents\Formativa\ConsoleApp2\reporte_estacionamiento.txt";

        Console.Write("Ingrese la placa del vehículo: ");
        string placa = Console.ReadLine();

        regresarAhoras:
        Console.Write("Ingrese la cantidad de horas estacionado (1-24): ");
        int horas = int.Parse(Console.ReadLine());

        if (horas < 1 || horas > 24)
        {
            Console.WriteLine("Horas fuera de rango.");
            return;
            goto regresarAhoras;
        }

        Console.Write("Ingrese el tipo de vehículo " +
            "\n1-Moto " +
            "\n2=Auto " +
            "\n3=Camioneta:");
        int tipo = int.Parse(Console.ReadLine());

        double tarifa = 0;
        string tipoNombre;
        switch (tipo)
        {
            case 1:
                tipoNombre = "Moto";
                tarifa = 0.75; 
                break;
            case 2:
                tipoNombre = "Auto";
                tarifa = 1.50; 
                break;
            case 3:
                tipoNombre = "Camioneta";
                tarifa = 2.25; 
                break;
            default:
                Console.WriteLine("Tipo inválido.");
                return;
        }

        double costoBase = horas * tarifa;
        double total = costoBase;

        if (horas > 8)
        {
            total = costoBase - (costoBase * 0.10);
        }

        Console.WriteLine("\nCosto base: $" + costoBase);
        Console.WriteLine("Total a pagar: $" + total);

        
        File.AppendAllText(filePath,
            $"Fecha y hora: {DateTime.Now}" + 
            $"\nPlaca: {placa}" +
            $"\nHoras:{horas} " +
            $"\nTipo: {tipo} {tipoNombre}" +
            $"\nCosto base: {costoBase}" +
            $"\nTotal a pagar: {total}" 
        );

        Console.WriteLine("\nReporte guardado en " + filePath);
    }
}
