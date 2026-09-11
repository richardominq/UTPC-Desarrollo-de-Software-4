
using System;
using System.IO;
using System.Globalization;

class Program
{
    static void Main()
    {
        
        
      
       
       
        string filePath = @"C:\Users\Estudiantes\Documents\Formativa\ConsoleApp3\reporte_boletos.txt";




        Console.Write("Ingrese el nombre del comprador: ");
        string nombreComprador = Console.ReadLine()?.Trim();


        
        Console.Write("Ingrese la cantidad de boletos (1 a 10): ");
        int cantidadBoletos = int.Parse(Console.ReadLine());


        if (cantidadBoletos < 1 || cantidadBoletos > 10)
        {
            Console.WriteLine("La cantidad de boletos debe estar entre 1 y 10.");
            return;
        }

      
        Console.Write("Seleccione la categoría:" +
            "\n1 - General " +
            "\n2 - Preferencial " +
            "\n3 - VIP : ");
        int categoria = int.Parse(Console.ReadLine());



        double precioUnitario;

        switch (categoria)
        {
            case 1:
                precioUnitario = 15.00;
                break;
            case 2:
                precioUnitario = 30.00;
                break;
            case 3:
                precioUnitario = 50.00;
                break;
            default:
                Console.WriteLine("Categoría inválida.");
                return;
        }

        double subtotal, descuento=0 , total;
        subtotal = precioUnitario * cantidadBoletos;

       
        if (cantidadBoletos >= 5)
        {
            descuento = subtotal * 0.12;
        }

       
        total = subtotal - descuento;

        
        Console.WriteLine($"\nSubtotal: {subtotal}");
        Console.WriteLine($"Total a pagar: {total}");



        File.AppendAllText(filePath,
            $"Fecha y hora: {DateTime.Now}" +
            $"\nComprador: {nombreComprador}" +
            $"\nCategoría: {categoria}" +
            $"\nCantidad de boletos: {cantidadBoletos}" +
            $"\nPrecio unitario: {precioUnitario}" +
            $"\nSubtotal: {subtotal}" +
            $"\nDescuento: {descuento}" +
            $"\nTotal a pagar: {total}"
        );

        Console.WriteLine("\nReporte guardado en " + filePath);

    }
}
