using System;

class Program
{
    static void Main(string[] args)
    {
        double montoCompra;
        double descuento;
        double montoFinal;
        int tipoCliente;

        Console.Write("Ingrese el monto total de la compra: $");
        montoCompra = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\n1 = Regular");
        Console.WriteLine("2 = Frecuente");
        Console.WriteLine("3 = VIP");

        Console.Write("Seleccione el tipo de cliente: ");
        tipoCliente = Convert.ToInt32(Console.ReadLine());

        switch (tipoCliente)
        {
            case 1:
                Console.WriteLine("\nCliente Regular");
                Console.WriteLine("No recibe descuento.");
                Console.WriteLine("Monto original: $" + montoCompra);
                break;

            case 2 when montoCompra > 100:
            case 3 when montoCompra > 100:

                descuento = montoCompra * 0.15;
                montoFinal = montoCompra - descuento;

                Console.WriteLine("\nRecibe un 15% de descuento.");
                Console.WriteLine("Monto original: $" + montoCompra);
                Console.WriteLine("Monto del descuento: $" + descuento);
                Console.WriteLine("Monto final: $" + montoFinal);
                break;

            case 2:
            case 3:
                Console.WriteLine("\nNo recibe descuento.");
                Console.WriteLine("Monto original: $" + montoCompra);
                break;

            default:
                Console.WriteLine("Tipo de cliente no válido.");
                break;
        }
    }
}