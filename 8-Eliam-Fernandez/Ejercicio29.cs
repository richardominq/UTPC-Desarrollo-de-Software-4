// Ejercicio 29: Control de tanque de agua

using System;

class Program
{
    static void Main()
    {
        // Variables
        double porcentajeTanque;
        double consumoDiario;
        string estadoAbastecimiento = "Normal";

        // Input
        Console.Write("Ingrese el porcentaje actual del tanque: ");
        porcentajeTanque = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el consumo diario estimado: ");
        consumoDiario = Convert.ToDouble(Console.ReadLine());

        // Processing
        if (porcentajeTanque < 25 || consumoDiario > 20)
        {
            estadoAbastecimiento = "Advertencia";
        }

        // Output
        Console.WriteLine("\nNivel del tanque: " + porcentajeTanque + "%");
        Console.WriteLine("Estado de abastecimiento: " + estadoAbastecimiento);
    }
}
