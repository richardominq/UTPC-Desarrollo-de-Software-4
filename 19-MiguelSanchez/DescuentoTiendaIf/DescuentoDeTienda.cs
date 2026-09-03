/*
 *Descuento en una tienda: Una tienda desea implementar un pequeño programa para determinar si un cliente puede recibir
 *un descuento especial. Solicite el monto total de la compra y el tipo de cliente (1 = Regular, 2 = Frecuente, 3 = VIP).
 *Si la compra es mayor de $100 y el cliente pertenece al tipo 2 o al tipo 3, calcule y muestre el monto final aplicando un 15 % de descuento.
 *De lo contrario, informe que no recibe descuento y muestre el monto original que deberá pagar.
 */

using System;
class DescuentoDeTienda
{
    
    public static void Main (string[] args)
    {

        double monto;
        double descuento = 0.15;
        int cliente;
        
        Console.WriteLine("Ingrese el tipo de cliente (1 = Regular, 2 = Frecuente, 3 = VIP):");
        cliente = int.Parse(Console.ReadLine());
        
        Console.WriteLine ("Ingrese el monto total de la compra:");
        monto = double.Parse(Console.ReadLine());

        if (monto > 100 && (cliente == 2 || cliente == 3))
        {
            descuento = monto * descuento;
            double total = monto - descuento;
            Console.WriteLine($"si aplico para el descuento del 15%: {descuento}");
            Console.WriteLine($"total a pagar es : {total}");
        }
        else
        {
            Console.WriteLine($"No aplico para descuento, su total es {monto}");
        }
        
    }
}

