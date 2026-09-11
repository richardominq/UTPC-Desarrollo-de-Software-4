using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Solicitar datos
        Console.Write("Ingrese la placa del vehículo: ");
        string placa = Console.ReadLine();

        Console.Write("Ingrese la cantidad de horas estacionado (1-24): ");
        int horas = int.Parse(Console.ReadLine());

        Console.WriteLine("Tipo de vehículo:");
        Console.WriteLine("1 = Moto");
        Console.WriteLine("2 = Auto");
        Console.WriteLine("3 = Camioneta");
        Console.Write("Ingrese el tipo de vehículo: ");
        int tipo = int.Parse(Console.ReadLine());

        // Validar las horas usando if-else
        if (horas < 1 || horas > 24)
        {
            Console.WriteLine("Error: las horas deben estar entre 1 y 24.");
            return;
        }

        // Definir tarifa usando switch
        double tarifa = 0;
        string nombreVehiculo = "";

        switch (tipo)
        {
            case 1:
                tarifa = 0.75;
                nombreVehiculo = "Moto";
                break;

            case 2:
                tarifa = 1.50;
                nombreVehiculo = "Auto";
                break;

            case 3:
                tarifa = 2.25;
                nombreVehiculo = "Camioneta";
                break;

            default:
                Console.WriteLine("Error: tipo de vehículo no válido.");
                return;
        }

        // Calcular costo base
        double costoBase = horas * tarifa;

        // Aplicar descuento del 10% si supera las 8 horas
        double descuento = 0;

        if (horas > 8)
        {
            descuento = costoBase * 0.10;
        }

        double totalPagar = costoBase - descuento;

        // Obtener fecha y hora del reporte
        DateTime fechaHora = DateTime.Now;

        // Mostrar resultados
        Console.WriteLine("\n--- REPORTE DE ESTACIONAMIENTO ---");
        Console.WriteLine("Placa: " + placa);
        Console.WriteLine("Tipo de vehículo: " + nombreVehiculo);
        Console.WriteLine("Horas estacionado: " + horas);
        Console.WriteLine("Tarifa por hora: $" + tarifa.ToString("0.00"));
        Console.WriteLine("Costo base: $" + costoBase.ToString("0.00"));
        Console.WriteLine("Descuento: $" + descuento.ToString("0.00"));
        Console.WriteLine("Total a pagar: $" + totalPagar.ToString("0.00"));
        Console.WriteLine("Fecha y hora: " + fechaHora.ToString("dd/MM/yyyy HH:mm:ss"));

        // Guardar los datos en el archivo
        string reporte =
            "----------------------------------------\n" +
            "REPORTE DE ESTACIONAMIENTO\n" +
            "Fecha y hora: " + fechaHora.ToString("dd/MM/yyyy HH:mm:ss") + "\n" +
            "Placa: " + placa + "\n" +
            "Tipo de vehículo: " + nombreVehiculo + "\n" +
            "Horas estacionado: " + horas + "\n" +
            "Tarifa por hora: $" + tarifa.ToString("0.00") + "\n" +
            "Costo base: $" + costoBase.ToString("0.00") + "\n" +
            "Descuento: $" + descuento.ToString("0.00") + "\n" +
            "Total a pagar: $" + totalPagar.ToString("0.00") + "\n" +
            "----------------------------------------\n\n";

        File.AppendAllText("reporte_estacionamiento.txt", reporte);

        Console.WriteLine("\nEl reporte fue guardado en reporte_estacionamiento.txt");
    }
}
