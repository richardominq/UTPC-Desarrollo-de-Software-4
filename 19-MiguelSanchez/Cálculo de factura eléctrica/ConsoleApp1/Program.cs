using System;
using System.IO;

class ConsoleApp1
{
    public static void Main(string[] args)
    {
        string filePath = @"C:\Users\Estudiantes\Documents\Formativa\ConsoleApp1\factura_electrica.txt";

    inicio:

        Console.WriteLine("Ingrese el nombre del cliente: ");
        string nombre = Console.ReadLine();

        Console.WriteLine("Ingrese la cantidad de Kilovatios consumidos: ");
        double consumo = double.Parse(Console.ReadLine());


        Console.WriteLine("Ingrese el tipo de cliente:" +
            "\n1 - Residencial" +
            "\n2 - Comercial" +
            "\n3 - Industrial: ");
        int tipoCliente = int.Parse(Console.ReadLine());


        if (consumo < 0)
        {
            Console.WriteLine("Datos del consumo no pueden ser negativos");
            goto inicio;
        }

        double tarifa;
        string nombreTipoCliente;

        switch (tipoCliente)
        {
            case 1:
                tarifa = 0.15;
                nombreTipoCliente = "Residencial";
                break;
            case 2:
                tarifa = 0.22;
                nombreTipoCliente = "Comercial";
                break;
            case 3:
                tarifa = 0.30;
                nombreTipoCliente = "Industrial";
                break;
            default:
                Console.WriteLine("Opción inválida");
                goto inicio;
        }

        // Cálculos
        double subtotal = consumo * tarifa;
        double montoRecargo = subtotal * 0.07;
        double total = subtotal + montoRecargo;
       
      


        File.AppendAllText(filePath,
            $"Fecha y hora: {DateTime.Now}" +
            $"\nCliente: {nombre}" +
            $"\nConsumo:{consumo} " +
            $"\nTipo de cliente: {nombreTipoCliente}" +
            $"\nTarifa por Kw: {tarifa:f2}" +
            $"\nSubTotal: {subtotal}"+
            $"\nRecargo (7%): {montoRecargo}"+
            $"\nTotal a pagar: {total}"
        );

        Console.WriteLine("\nReporte guardado en " + filePath);
    }
}
 
