/*
 * Desarrolle un programa que permita determinar cuál es el número mayor entre cuatro valores diferentes ingresados por el usuario.
 * Solicite cuatro números diferentes y almacene cada uno en una variable independiente.
 * Para determinar el número mayor, utilice sentencias if y el operador lógico AND (&&), comparando cada número con los otros tres.
 * Por ejemplo, para determinar si el primer número es el mayor deberá comprobar simultáneamente que:
 * Número 1 > Número 2 AND Número 1 > Número 3 AND Número 1 > Número 4.
 * Realice las comparaciones correspondientes para los cuatro números.
 * Al finalizar, el programa deberá mostrar:
 * "El número mayor es:" seguido del valor correspondiente. 
 */

using System;

class DeterminarElMayorDeCuatroNumerosIf
{
  public static void Main(string[] args)
  {
    double numero1;
    double numero2;
    double numero3;
    double numero4;

    Console.WriteLine("Ingrese el primer numero");
    numero1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Ingrese el segundo numero");
    numero2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Ingrese el tercer numero");
    numero3 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Ingrese el cuarto numero");
    numero4 = Convert.ToDouble(Console.ReadLine());

    if (numero1 == numero2 ||
        numero1 == numero3 ||
        numero1 == numero4 ||
        numero2 == numero3 ||
        numero2 == numero4 ||
        numero3 == numero4)
    {
      Console.WriteLine("Los 4 numeros no pueden ser iguales");
    }
    else
    {
      if (numero1 > numero2 && numero1 > numero3 && numero1 > numero4)
      {
        Console.WriteLine($"El numero mayor es :{numero1}");
      }
      if (numero2 > numero1 && numero2 > numero3 && numero2 > numero4)
      {
        Console.WriteLine($"El numero mayor es:{numero2}");
      }
      if (numero3 > numero1 && numero3 > numero2 && numero3 > numero4)
      {
        Console.WriteLine($"El numero mayor es:{numero3}");
      }
      if (numero4 > numero1 && numero4 > numero2 && numero4 > numero3)
      {
        Console.WriteLine($"El numero mayor es:{numero4}");
      }
    }
  }
}
