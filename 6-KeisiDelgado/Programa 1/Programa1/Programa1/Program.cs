using System;
using System.Globalization;

/*
 * Nombre: Keisi Delgado
 */
namespace Programa_Tienda
{
    class Program_If1
    {
        static void Main(string[] args)
        {
            // Pedimos el monto total de la compra
            Console.Write("Ingrese el monto total de la compra: ");

            double montoOriginal;

            if (!double.TryParse(
                Console.ReadLine().Replace(',', '.'),
                NumberStyles.Number,
                CultureInfo.InvariantCulture,
                out montoOriginal))
            {
                Console.WriteLine("\n[Error]: Debe ingresar un monto válido.");
                Console.ReadKey();
                return;
            }

            // Mostramos los tipos de clientes
            Console.WriteLine("\nTipos de clientes:");
            Console.WriteLine("1. Regular");
            Console.WriteLine("2. Frecuente");
            Console.WriteLine("3. VIP");

            Console.Write("Seleccione el tipo de cliente (1, 2, 3): ");
            int tipoCliente = Convert.ToInt32(Console.ReadLine());

            // Verificamos si aplica el descuento
            if (montoOriginal > 100 &&
                (tipoCliente == 2 || tipoCliente == 3))
            {
                double descuento = montoOriginal * 0.15;
                double montoFinal = montoOriginal - descuento;

                Console.WriteLine("\nSí aplica el descuento del 15%.");
                Console.WriteLine($"Monto total a pagar: ${montoFinal:F2}");
            }
            else
            {
                Console.WriteLine("\nNo recibes ningún descuento.");
                Console.WriteLine($"Monto total a pagar: ${montoOriginal:F2}");
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}