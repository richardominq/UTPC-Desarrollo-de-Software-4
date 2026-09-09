using System;
using System.IO;

namespace VentaBoletos_P3
{
  internal class Program
  {
    static void Main(string[] args)
    {
      string nombreComprador;
      int cantidadBoletos;
      int categoria;
      double precio = 0;
      string nombreCategoria = "";
      double subtotal;
      double descuento = 0;
      double total;

      Console.WriteLine("Ingrese el nombre del comprador: ");
      nombreComprador = Console.ReadLine();

      Console.WriteLine("Ingrese la cantidad de boletos: ");
      cantidadBoletos = int.Parse(Console.ReadLine());

      Console.WriteLine("Ingrese la categoría (1 = General, 2 = Preferencial, 3 = VIP): ");
      categoria = int.Parse(Console.ReadLine());

      if (cantidadBoletos >= 1 && cantidadBoletos <= 10)
      {
        switch (categoria)
        {
          case 1:
            precio = 15.00;
            nombreCategoria = "General";
            break;

          case 2:
            precio = 30.00;
            nombreCategoria = "Preferencial";
            break;

          case 3:
            precio = 50.00;
            nombreCategoria = "VIP";
            break;

          default:
            Console.WriteLine("CategoraI no valida");
            return;
        }

        subtotal = cantidadBoletos * precio;

        if (cantidadBoletos >= 5)
        {
          descuento = subtotal * 0.12;
        }

        total = subtotal - descuento;

        Console.WriteLine();
        Console.WriteLine($"Comprador: {nombreComprador}");
        Console.WriteLine($"Cantidad de boletos: {cantidadBoletos}");
        Console.WriteLine($"CategorIa: {nombreCategoria}");
        Console.WriteLine($"Precio unitario: {precio:f2}");
        Console.WriteLine($"Subtotal: {subtotal:f2}");
        Console.WriteLine($"Descuento (12%): {descuento:f2}");
        Console.WriteLine($"Total final a pagar: {total:f2}");

        string filePath = "reporte_boletos.txt";

        File.AppendAllText(filePath,
            $"Fecha y hora: {DateTime.Now}" +
            $"\nComprador: {nombreComprador}" +
            $"\nCantidad de boletos: {cantidadBoletos}" +
            $"\nCategoría: {nombreCategoria}" +
            $"\nPrecio unitario: {precio:f2}" +
            $"\nSubtotal: {subtotal:f2}" +
            $"\nDescuento (12%): {descuento:f2}" +
            $"\nTotal final a pagar: {total:f2}" +
            "\n-----------------------------\n"
        );

        Console.WriteLine();
        Console.WriteLine("El reporte ha sido guardado correctamente.");
        Console.WriteLine($"Ubicación: {Path.GetFullPath(filePath)}");
      }
      else
      {
        Console.WriteLine("Error: la cantidad de boletos debe estar entre 1 y 10.");
      }
    }
  }
}
