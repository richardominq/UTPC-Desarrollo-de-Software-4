using System;

namespace P4
{
  class Program
  {
    static void Main(string[] args)
    {
      double numero1;
      double numero2;
      double numero3;
      double numero4;

      Console.Write("Ingrese el número 1: ");
      numero1 = Convert.ToDouble(Console.ReadLine());

      Console.Write("Ingrese el número 2: ");
      numero2 = Convert.ToDouble(Console.ReadLine());

      Console.Write("Ingrese el número 3: ");
      numero3 = Convert.ToDouble(Console.ReadLine());

      Console.Write("Ingrese el número 4: ");
      numero4 = Convert.ToDouble(Console.ReadLine());

      if (numero1 > numero2 && numero1 > numero3 && numero1 > numero4)
      {
        Console.WriteLine($"El número mayor es: {numero1}");
      }

      if (numero2 > numero1 && numero2 > numero3 && numero2 > numero4)
      {
        Console.WriteLine($"El número mayor es: {numero2}");
      }

      if (numero3 > numero1 && numero3 > numero2 && numero3 > numero4)
      {
        Console.WriteLine($"El número mayor es: {numero3}");
      }

      if (numero4 > numero1 && numero4 > numero2 && numero4 > numero3)
      {
        Console.WriteLine($"El número mayor es: {numero4}");
      }
    }
  }
}
