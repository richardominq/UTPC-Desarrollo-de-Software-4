// Ejercicio 8: Envío gratuito

using System;

class Program
{
    static void Main()
    {
        // Variables
        double montoCompra;
        string provinciaDestino;
        int cantidadProductos;
        int tipoCliente;
        string nombreTipoCliente = "";
        string envioGratuito = "No";

        // Input
        Console.Write("Ingrese el monto de la compra: ");
        montoCompra = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la provincia de destino: ");
        provinciaDestino = Console.ReadLine();

        Console.Write("Ingrese la cantidad de productos: ");
        cantidadProductos = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el tipo de cliente (1=Normal, 2=Frecuente, 3=Premium): ");
        tipoCliente = Convert.ToInt32(Console.ReadLine());

        // Processing
        switch (tipoCliente)
        {
            case 1:
                nombreTipoCliente = "Normal";
                break;
            case 2:
                nombreTipoCliente = "Frecuente";
                break;
            case 3:
                nombreTipoCliente = "Premium";
                break;
            default:
                nombreTipoCliente = "Desconocido";
                break;
        }

        if ((montoCompra > 150 && cantidadProductos >= 3) || tipoCliente == 3)
        {
            envioGratuito = "Sí";
        }

        // Output
        Console.WriteLine("\nEnvío gratuito: " + envioGratuito);
        Console.WriteLine("Tipo de cliente: " + nombreTipoCliente);
    }
}
