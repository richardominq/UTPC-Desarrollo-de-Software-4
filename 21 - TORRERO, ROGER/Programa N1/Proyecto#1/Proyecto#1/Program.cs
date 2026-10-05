using System;

namespace Proyecto1
{
    class Program
    {
        static void Main()
        {

            double monto, montoFinal;
            int tipoCliente;

            Console.Write("Ingrese el monto total de la compra: $");
            monto = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("1. Regular ");
            Console.WriteLine("2. Frecuente ");
            Console.WriteLine("3. VIP ");
            Console.WriteLine("Ingrese el tipo de cliente ");
            tipoCliente = Convert.ToInt32(Console.ReadLine());

            if (monto > 100 && (tipoCliente == 2 || tipoCliente == 3))
            {
                montoFinal = monto - (monto * 0.15);

                Console.WriteLine("Recibe descuendo del 15%");
                Console.WriteLine("Monto final: $" + montoFinal);
            }
            else
            {
                Console.WriteLine("No recibe descuento");
                Console.WriteLine("Monto a pagar : $" + monto);
            }
        }
    }
}