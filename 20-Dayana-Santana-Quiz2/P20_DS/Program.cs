using System;

class Program
{
  static void Main()
  {
    // solicitar datos 
    Console.Write("Ingrese los minutos consumidos: ");
    double minutos = double.Parse(Console.ReadLine());

    Console.Write("Ingrese los GB utilizados: ");
    double gb = double.Parse(Console.ReadLine());

    Console.Write("Ingrese el tipo de plan (1 = Básico, 2 = Plus, 3 = Premium): ");
    int tipoPlan = int.Parse(Console.ReadLine());

    //  switch expression - base 
    double costoBase = tipoPlan switch
    {
      1 => 20.00,
      2 => 35.00,
      3 => 50.00,
      _ => 0
    };

    // Usar switch expression - plan
    string nombrePlan = tipoPlan switch
    {
      1 => "Básico",
      2 => "Plus",
      3 => "Premium",
      _ => "Desconocido"
    };

    // limites según el plan 
    (int limiteMinutos, double limiteGB) = tipoPlan switch
    {
      1 => (100, 2.0),
      2 => (300, 5.0),
      3 => (500, 10.0),
      _ => (0, 0)
    };

    //  si el plan es valido
    if (costoBase == 0)
    {
      Console.WriteLine("Tipo de plan no válido.");
      return;
    }

    // recargo si excede los límites
    double recargo = 0;
    if (minutos > limiteMinutos || gb > limiteGB)
    {
      recargo = costoBase * 0.15; // 15% de recargo
    }

    //  total mensual
    double totalMensual = costoBase + recargo;

    //  resultados
    Console.WriteLine("\n=== DETALLES DEL PLAN ===");
    Console.WriteLine($"Plan: {nombrePlan}");
    //si hay regargo 
    if (recargo > 0)
    {
      Console.WriteLine($"Recargo: ${recargo:F2}");
    }
    //no hay recargo 
    else
    {
      Console.WriteLine("Recargo: No hay recargo");
    }
    //total mensual 
    Console.WriteLine($"Total mensual: ${totalMensual:F2}");
  }
}
