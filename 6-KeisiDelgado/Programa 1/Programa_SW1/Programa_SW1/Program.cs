using System;
using System.Globalization;

// Nombre: Keisi Delgado
namespace Programa_Tienda
{
    class Program_Switch1
    {
        static void Main(string[] args)
        {
            // Pedimos el monto de la compra
            Console.Write("Ingrese el monto de la compra: ");

            double montoOriginal;

            switch (double.TryParse(
                Console.ReadLine().Replace(',', '.'),
                NumberStyles.Any,
                CultureInfo.InvariantCulture,
                out montoOriginal))
            {
                case false:
                    Console.WriteLine("El monto ingresado no es válido.");
                    return;
            }

            // Verificamos que el monto sea mayor que cero
            switch (montoOriginal > 0)
            {
                case false:
                    Console.WriteLine("El monto debe ser mayor que cero.");
                    return;
            }

            // Mostramos los tipos de cliente
            Console.WriteLine("\nTipos de clientes:");
            Console.WriteLine("1 = Regular");
            Console.WriteLine("2 = Frecuente");
            Console.WriteLine("3 = VIP");

            Console.Write("Seleccione el tipo de cliente: ");

            int tipoCliente;

            switch (int.TryParse(Console.ReadLine(), out tipoCliente))
            {
                case false:
                    Console.WriteLine("El tipo de cliente no es válido.");
                    return;
            }

            // Aplicamos el descuento según el tipo de cliente
            switch (tipoCliente)
            {
                case 1:
                    Console.WriteLine("\nNo se aplica descuento.");
                    Console.WriteLine($"Monto final: ${montoOriginal:F2}");
                    break;

                case 2:
                case 3:
                    switch (montoOriginal > 100)
                    {
                        case true:
                            double descuento = montoOriginal * 0.15;
                            double montoFinal = montoOriginal - descuento;

                            Console.WriteLine("\nDescuento aplicado: 15%");
                            Console.WriteLine($"Monto original: ${montoOriginal:F2}");
                            Console.WriteLine($"Descuento: ${descuento:F2}");
                            Console.WriteLine($"Monto final: ${montoFinal:F2}");
                            break;

                        case false:
                            Console.WriteLine("\nNo se aplica descuento.");
                            Console.WriteLine($"Monto final: ${montoOriginal:F2}");
                            break;
                    }
                    break;

                default:
                    Console.WriteLine("\n[Error]: El tipo de cliente debe ser 1, 2 o 3.");
                    break;
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}