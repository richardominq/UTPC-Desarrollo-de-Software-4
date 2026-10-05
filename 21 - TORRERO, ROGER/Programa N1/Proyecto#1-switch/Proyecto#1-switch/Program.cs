using System;

class Program
{
    static void Main()
    {
        double monto, montoFinal;
        int tipoCliente;

        Console.Write("Ingrese el monto total de la compra: ");
        monto = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("1. Regular");
        Console.WriteLine("2. Frecuente");
        Console.WriteLine("3. VIP");
        Console.Write("Ingrese el tipo de cliente: ");
        tipoCliente = Convert.ToInt32(Console.ReadLine());

        switch (tipoCliente)
        {
            case 2 when monto > 100:
            case 3 when monto > 100:
                montoFinal = monto - (monto * 0.15);

                Console.WriteLine("Recibe descuento del 15%");
                Console.WriteLine("Monto final: $" + montoFinal);
                break;

            default:
                Console.WriteLine("No recibe descuento");
                Console.WriteLine("Monto a pagar: $" + monto);
                break;
        }
    }
}