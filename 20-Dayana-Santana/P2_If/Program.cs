using System;

namespace P2
{
  class Program
  {
    static void Main(string[] args)
    {
      double nota;
      double asistencia;
      int tipoE;

      Console.Write("Ingrese la nota final: ");
      nota = Convert.ToDouble(Console.ReadLine());

      Console.Write("Ingrese el porcentaje de asistencia: ");
      asistencia = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("Tipo de estudiante (1 = Regular, 2 = Becado, 3 = Intercambio): ");
      tipoE = Convert.ToInt32(Console.ReadLine());

      if (nota >= 71 && asistencia >= 80 &&
          (tipoE == 1 || tipoE == 2 || tipoE == 3))
      {
        Console.WriteLine("Aprobado");
        Console.WriteLine($"Nota obtenida: {nota}");
        Console.WriteLine($"Tipo de estudiante: {tipoE}");
      }
      else
      {
        Console.WriteLine("No aprobado");
        Console.WriteLine($"Nota final: {nota}");
      }
    }
  }
}
