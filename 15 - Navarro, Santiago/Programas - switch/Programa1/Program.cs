
/*
 * Programa 1: Descuento en una tienda
 * Una tienda desea implementar un pequeño programa para determinar si un
 * cliente puede recibir un descuento especial. Solicite el monto total de
 * la compra y el tipo de cliente (1 = Regular, 2 = Frecuente, 3 = VIP).
 * Si la compra es mayor de $100 y el cliente pertenece al tipo 2 o al tipo 3,
 * calcule y muestre el monto final aplicando un 15 % de descuento.
 * De lo contrario, informe que no recibe descuento y muestre el monto original.
 */

using System;
using System.Text;
namespace Programa1
{
    class Program
    {
        static void Main(string[] args)
        {
            int tipoCliente=0;
            double montoTotal = 0, montoFinal = 0, descuento = 0;

            // Solicitar el monto total de la compra
            Console.Write("Ingrese el monto total de su compra: ");

            if (!double.TryParse(Console.ReadLine(), out montoTotal))
            {
                Console.WriteLine("Error: debe ingresar un número válido.");
                return;
            }

            // Seleccionar el tipo de cliente
            Console.WriteLine("Seleccione el tipo de cliente");
            Console.WriteLine("1 = Regular");
            Console.WriteLine("2 = Frecuente");
            Console.WriteLine("3 = VIP");
            Console.Write("Opción seleccionada: ");

            if (!int.TryParse(Console.ReadLine(), out tipoCliente))
            {
                Console.WriteLine("Error: debe ingresar un número válido.");
                return;
            }

            // Seleccionar según el tipo de cliente
            switch(tipoCliente)
            {
                case 1:
                    Console.WriteLine("No se aplica descuento.");
                    Console.WriteLine("El monto final a pagar es: $" + montoTotal);
                    break;

                case 2:
                    if (montoTotal > 100)
                    {
                        descuento = montoTotal * 0.15;//calculo del descuento
                        montoFinal = montoTotal - descuento; //calculo del monto final
                        //mensaje de descuento aplicado
                        Console.WriteLine("Se aplicó un descuento del 15%.");
                        Console.WriteLine("El monto final a pagar es: $" + montoFinal);
                    }
                    else
                    {
                        Console.WriteLine("No se aplica descuento.");
                        Console.WriteLine("El monto final a pagar es: $" + montoTotal);
                    }
                    break;

                case 3:
                    if (montoTotal > 100)
                    {
                        descuento = montoTotal * 0.15;//calculo del descuento
                        montoFinal = montoTotal - descuento;//calculo del monto final
                        //mensaje de descuento aplicado
                        Console.WriteLine("Se aplicó un descuento del 15%.");
                        Console.WriteLine("El monto final a pagar es: $" + montoFinal);
                    }
                    else
                    {
                        Console.WriteLine("No se aplica descuento.");
                        Console.WriteLine("El monto final a pagar es: $" + montoTotal);
                    }
                    break;

                default:
                    Console.WriteLine("El tipo de cliente debe ser 1, 2 o 3");
                    break;
                }
            }
    }
}
