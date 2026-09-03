using System;

namespace P3
{
  class Program
  {
    static void Main(string[] args)
    {
      int edad;
      int boletos;
      int tipoE;

      Console.Write("Ingrese su edad: ");
      edad = Convert.ToInt32(Console.ReadLine());

      Console.Write("Ingrese la cantidad de boletos disponibles: ");
      boletos = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Tipo de entrada (1 = General, 2 = VIP, 3 = Invitado): ");
      tipoE = Convert.ToInt32(Console.ReadLine());

      if (edad >= 18 && boletos >= 1 &&
          (tipoE == 1 || tipoE == 2 || tipoE == 3))
      {
        Console.WriteLine("Entrada autorizada");
        Console.WriteLine($"Tipo de entrada: {tipoE}");
      }
      else
      {
        Console.WriteLine("Entrada rechazada");
        Console.WriteLine("No cumple con las condiciones establecidas.");
      }
    }
  }
}
