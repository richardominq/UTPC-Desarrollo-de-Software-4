using System;
namespace Basics
{ 
 class Program
 {
    static void Main(string[] args)
    {
        // Declaración de variables
        double monto;
        int tipoCliente;
        double descuento = 0;
        double montoFinal;

        // Solicitar el monto de la compra
        Console.Write("Ingrese el monto total de la compra: ");
        monto = double.Parse(Console.ReadLine());

        // Solicitar el tipo de cliente
        Console.WriteLine("1 = Regular");
        Console.WriteLine("2 = Frecuente");
        Console.WriteLine("3 = VIP");
        Console.Write("Ingrese el tipo de cliente: ");
        tipoCliente = int.Parse(Console.ReadLine());

        // Verificar si la compra es mayor a $100
        if (monto > 100)

            // Verificar si el cliente es frecuente o VIP
            if (tipoCliente == 2 | tipoCliente == 3)
            {
                // Calcular el 15% de descuento
                descuento = monto * 0.15;

                // Calcular el monto final
                montoFinal = monto - descuento;

                // Mostrar los resultados
                Console.WriteLine("Compra total: $" + monto);
                Console.WriteLine("Descuento: $" + descuento);
                Console.WriteLine("Monto final: $" + montoFinal);
            }
            else
            {
                // El cliente no recibe descuento
                Console.WriteLine("Compra total: $" + monto);
                Console.WriteLine("No recibe descuento.");
                Console.WriteLine("Monto a pagar: $" + monto);
            }
        else
        {
            // La compra no supera los $100
            Console.WriteLine("Compra total: $" + monto);
            Console.WriteLine("No recibe descuento.");
            Console.WriteLine("Monto a pagar: $" + monto);
        }
    }
 }
}
