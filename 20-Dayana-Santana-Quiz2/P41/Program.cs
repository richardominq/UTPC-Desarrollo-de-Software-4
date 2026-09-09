using System;

class Program
{
  static void Main()
  {
    // slicitar datos 
    Console.Write("Ingrese la humedad del suelo (%): ");
    double humedad = double.Parse(Console.ReadLine());

    Console.Write("Ingrese la temperatura (°C): ");
    double temperatura = double.Parse(Console.ReadLine());

    Console.Write("Ingrese la probabilidad de lluvia (%): ");
    double probLluvia = double.Parse(Console.ReadLine());

    Console.Write("Ingrese el tipo de cultivo (1 = Arroz, 2 = Tomate, 3 = Maíz): ");
    int tipoCultivo = int.Parse(Console.ReadLine());

    //  nombre del cultivo 
    string nombreCultivo;
    switch (tipoCultivo)
    {
      case 1:
        nombreCultivo = "Arroz";
        break;
      case 2:
        nombreCultivo = "Tomate";
        break;
      case 3:
        nombreCultivo = "Maíz";
        break;
      default:
        Console.WriteLine("Tipo de cultivo no válido.");
        return;
    }

    //  si se debe activar el riego 
    bool activarRiego;
    if ((humedad < 40 && probLluvia < 30) || (temperatura > 35))
    {
      activarRiego = true;
    }
    else
    {
      activarRiego = false;
    }

    // mostrar resultados
    Console.WriteLine("\n=== SISTEMA DE RIEGO ===");
    Console.WriteLine($"Cultivo: {nombreCultivo}");
    Console.WriteLine($"Humedad del suelo: {humedad:F1}%");

    if (activarRiego)
    {
      Console.WriteLine("Riego: ACTIVADO");
      Console.WriteLine("Motivo: " + (humedad < 40 && probLluvia < 30 ? "Baja humedad y poca probabilidad de lluvia" : "Temperatura elevada"));
    }
    else
    {
      Console.WriteLine("Riego: DESACTIVADO");
    }
  }
}
