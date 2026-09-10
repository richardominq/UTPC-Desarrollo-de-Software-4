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
      int posicion = 0;

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
        posicion = 1;
      }

      if (numero2 > numero1 && numero2 > numero3 && numero2 > numero4)
      {
        posicion = 2;
      }

      if (numero3 > numero1 && numero3 > numero2 && numero3 > numero4)
      {
        posicion = 3;
      }

      if (numero4 > numero1 && numero4 > numero2 && numero4 > numero3)
      {
        posicion = 4;
      }

      switch (posicion)
      {
        case 1:
          Console.WriteLine($"El número mayor es: {numero1}");
          Console.WriteLine("El número mayor corresponde al número 1 ingresado.");
          break;

        case 2:
          Console.WriteLine($"El número mayor es: {numero2}");
          Console.WriteLine("El número mayor corresponde al número 2 ingresado.");
          break;

        case 3:
          Console.WriteLine($"El número mayor es: {numero3}");
          Console.WriteLine("El número mayor corresponde al número 3 ingresado.");
          break;

        case 4:
          Console.WriteLine($"El número mayor es: {numero4}");
          Console.WriteLine("El número mayor corresponde al número 4 ingresado.");
          break;
      }
    }
  }
}
