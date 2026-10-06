
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Windows.Markup;
using System;
using System.IO;
namespace Factura_P1;

/*Cálculo de factura eléctrica según tipo de cliente

Desarrolle un programa en C# que solicite tres datos: nombre del cliente, cantidad de kilovatios consumidos y tipo de cliente (1 = Residencial, 2 = Comercial, 3 = Industrial).

Utilice if-else para validar que el consumo sea mayor que cero. Luego, use switch para aplicar una tarifa según el tipo de cliente:

Residencial: $0.15 por kWh
Comercial: $0.22 por kWh
Industrial: $0.30 por kWh

El programa debe realizar dos operaciones: calcular el subtotal del consumo y calcular un recargo del 7% sobre dicho subtotal. Debe mostrar dos salidas: el subtotal y el total a pagar con recargo.

Finalmente, guarde la respuesta en un archivo de texto llamado factura_electrica.txt, incluyendo nombre del cliente, consumo, tipo de cliente, resultados, fecha y hora de generación del reporte.

*/


internal class Program
{
  static void Main(string[] args)
  {
    string nomb;
    double cantidad_k;
    int tipoCliente;
    double tarifa = 0;
    string tipo = "";
    double subtotal, total, recargo;
    Console.WriteLine("Ingrese su nombre: ");
    nomb = Console.ReadLine();
    Console.WriteLine("Ingrese la cantidad de kilovatios consumidos: ");
    cantidad_k = double.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el tipo de cliente  (1 = Residencial, 2 = Comercial, 3 = Industrial): ");
    tipoCliente = int.Parse(Console.ReadLine());

    if (cantidad_k > 0)
    {

      switch (tipoCliente)
      {
        case 1:
          tarifa = 0.15;
          tipo = "Residencial ";
          break;

        case 2:
          tarifa = 0.22;
          tipo = "comercial";
          break;
        case 3:
          tarifa = 0.30;
          tipo = "industrial";
          break;
        default:
          Console.WriteLine("Tipo de cliente no valido");
          break;
      }

      subtotal = cantidad_k * tarifa;
      recargo = subtotal * 0.07;
      total = subtotal + recargo;
      Console.WriteLine($"Subtotal: {subtotal} ");
      Console.WriteLine($"Total: {total}, el recargo  fue de: {recargo} ");
      string filePath = "factura_electrica.txt";

      File.AppendAllText(filePath,
          $"Fecha y hora: {DateTime.Now}" +
          $"\nCliente: {nomb}" +
          $"\nConsumo: {cantidad_k} kWh" +
          $"\nTipo de cliente: {tipo}" +
          $"\nTarifa por Kw: {tarifa:f2}" +
          $"\nSubTotal: {subtotal:f2}" +
          $"\nRecargo (7%): {recargo:f2}" +
          $"\nTotal a pagar: {total:f2}" +
          "\n-----------------------------\n"
      );

      Console.WriteLine();
      Console.WriteLine("la factura ha sido guardada correctamente.");

    }
    else
    {
      Console.WriteLine("error es menor a cero");
    }


  }
}
