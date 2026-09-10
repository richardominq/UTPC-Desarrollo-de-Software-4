using System;

namespace P1
{
  class Program
  {
    static void Main(string[] args)
    {
      double comp;
      int tipoC;
      double descuento;
      double montofinal;

      Console.Write("Ingrese el total de la compra: ");
      comp = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("Tipo de cliente (1 = Regular, 2 = Frecuente, 3 = VIP): ");
      tipoC = Convert.ToInt32(Console.ReadLine());

      // tipo de cliente
      switch (tipoC)
      {
        case 1:
          Console.WriteLine("Cliente Regular");
          break;

        case 2:
          Console.WriteLine("Cliente Frecuente");
          break;

        case 3:
          Console.WriteLine("Cliente VIP");
          break;

        default:
          Console.WriteLine("Tipo de cliente no válido");
          break;
      }

      // 
      if (comp > 100 && (tipoC == 2 || tipoC == 3))
      {
        descuento = comp * 0.15;
        montofinal = comp - descuento;

        Console.WriteLine($"Aplica a descuento");
        Console.WriteLine($"Descuento: ${descuento}");
        Console.WriteLine($"El monto final a pagar es de: ${montofinal}");
      }
      else
      {
        Console.WriteLine("No recibe descuento para esta compra.");
        Console.WriteLine($"El monto original a pagar es: ${comp}");
      }
    }
  }
}
