using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el monto total de la compra: ");
        double monto = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el tipo de cliente (1 = Regular, 2 = Frecuente, 3 = VIP): ");
        int tipoCliente = Convert.ToInt32(Console.ReadLine());

        if (monto < 0)
        {
            Console.WriteLine("El monto no puede ser negativo.");
            return;
        }

        if (tipoCliente < 1 || tipoCliente > 3)
        {
            Console.WriteLine("Tipo de cliente invalido. Debe ser 1, 2 o 3.");
            return;
        }

        string descripcionTipo;

        if (tipoCliente == 1)
        {
            descripcionTipo = "Regular";
        }
        else if (tipoCliente == 2)
        {
            descripcionTipo = "Frecuente";
        }
        else
        {
            descripcionTipo = "VIP";
        }

        Console.WriteLine("Tipo de cliente: " + descripcionTipo);

        if (monto > 100 && (tipoCliente == 2 || tipoCliente == 3))
        {
            double montoFinal = monto - (monto * 0.15);
            Console.WriteLine("El cliente recibe un descuento del 15%.");
            Console.WriteLine("Monto final a pagar: " + montoFinal);
        }
        else
        {
            Console.WriteLine("El cliente no recibe descuento.");
            Console.WriteLine("Monto original a pagar: " + monto);
        }
    }
}
