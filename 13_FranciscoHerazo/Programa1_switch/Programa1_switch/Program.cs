Console.WriteLine("--- Programa Tienda ---");

Console.WriteLine("\nIngrese el tipo de cliente");
Console.WriteLine("1 | Regular");
Console.WriteLine("2 | Frecuente");
Console.WriteLine("3 | VIP");
int tipoCliente = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nIngrese el monto total de la compra");
double montoTotal = Convert.ToDouble(Console.ReadLine());

switch (tipoCliente)
{
    case 1:
        Console.WriteLine("\nTipo de cliente: Regular");
        break;
    case 2:
        Console.WriteLine("\nTipo de cliente: Frecuente");
        break;
    case 3:
        Console.WriteLine("\nTipo de cliente: VIP");
        break;
    default:
        Console.WriteLine("\nTipo de cliente no valido");
        break;
}

if (montoTotal > 100 && (tipoCliente == 2 || tipoCliente == 3))
{
    double descuento = montoTotal * 0.15;
    double montoFinal = montoTotal - descuento;
    Console.WriteLine("\nEl descuento es del 15%");
    Console.WriteLine("Monto final a pagar: " + montoFinal);
}
else
{
    Console.WriteLine("\nEl cliente no recibe descuento");
    Console.WriteLine("Monto a pagar: " + montoTotal);
}