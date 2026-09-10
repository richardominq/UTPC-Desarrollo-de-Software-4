using System;

class DescuentoDeUnaTienda
{
    static void Main(string[] args)
    {
        double montoCompra;
        double descuento;
        double montoFinal;
        int tipoCliente;

        Console.Write("-----CAJA #1-----\n");
        Console.Write("Monto Total: $");
        montoCompra = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nTipo de cliente:");
        Console.WriteLine("1 = Regular");
        Console.WriteLine("2 = Frecuente");
        Console.WriteLine("3 = VIP");

        Console.Write("Seleccione el tipo de cliente: ");
        tipoCliente = Convert.ToInt32(Console.ReadLine());

     
        Console.WriteLine("\nTotal sin descuento: $" + montoCompra);

       
        if (montoCompra > 100 && (tipoCliente == 2 || tipoCliente == 3))
        {
            descuento = montoCompra*0.15;
            montoFinal = montoCompra - descuento;

            Console.WriteLine("Descuento aplicado: $" + descuento);
            Console.WriteLine("Total a Pagar: $" + montoFinal);
        }
        else
        {
            Console.WriteLine("No recibe descuento");
            Console.WriteLine("Total a pagar: $" + montoCompra);
        }
    }
}


