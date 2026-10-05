/*
 *Descuento en una tienda: Una tienda desea implementar un pequeño programa para determinar si un cliente puede recibir
 *un descuento especial. Solicite el monto total de la compra y el tipo de cliente (1 = Regular, 2 = Frecuente, 3 = VIP).
 *Si la compra es mayor de $100 y el cliente pertenece al tipo 2 o al tipo 3, calcule y muestre el monto final aplicando un 15 % de descuento.
 *De lo contrario, informe que no recibe descuento y muestre el monto original que deberá pagar.
 */

namespace Praticas;

public class DescuentoTiendaSW
{
    private static void Main(string[] args)
    {
        double monto;
        double descuento = 0.15;
        int cliente;

        Console.Write("Ingrese el tipo de cliente: ");
        cliente = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Ingrese el monto total de la compra:");
        monto = double.Parse(Console.ReadLine());

       

        switch (cliente)
        {
            case 1:
                Console.WriteLine("Cliente regular, no recibe descuento.");
                Console.WriteLine($"Total a pagar: ${monto}");
                break;

            case 2:
            case 3:
                if (monto > 100)
                {
                    descuento = monto * descuento;
                    monto = monto - descuento;

                    Console.WriteLine($"Descuento: ${descuento}");
                    Console.WriteLine($"Total a pagar: ${monto}");
                }
                else
                {
                    Console.WriteLine("No recibe descuento.");
                    Console.WriteLine($"Total a pagar: ${monto}");
                }
                break;

            default:
                Console.WriteLine("Tipo de cliente incorrecto.");
                break;
        }
    }
    
}