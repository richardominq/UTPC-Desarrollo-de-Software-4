/*
 * Solicite la cantidad disponible y el nivel mínimo permitido.
 * Si la cantidad disponible es menor o igual al nivel mínimo, indique “Reabastecer inventario”; de lo contrario,
 * indique “Inventario suficiente”.
 * Muestre también la diferencia entre ambas cantidades.
 * Entradas: 2. Salidas: 2.
 * Utilizar: if.
 */

using System;

class ControlDeInventario
{
  static void Main(string[] args)
  {
    
    int cantidadDisponible;
    int cantidadMinima;
    int diferencia;

    inicio:
    Console.WriteLine("Ingrese la cantidad de disponibles:");
    cantidadDisponible = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingrese la cantidad minima:");
    cantidadMinima = Convert.ToInt32(Console.ReadLine());

    if (cantidadDisponible < 0 || cantidadMinima < 0)
    {
      Console.WriteLine("Las cantidades no pueden ser negativas.");
      goto inicio;
    }

    diferencia = cantidadDisponible - cantidadMinima;

    if (cantidadDisponible <= cantidadMinima)
    {
      Console.WriteLine($"Reabastecer inventario\nLa diferencia es : {diferencia}");

    }
    else
    {
      Console.WriteLine($"Inventario suficiente\nLa diferencia es : {diferencia}");
    }
  }
}

