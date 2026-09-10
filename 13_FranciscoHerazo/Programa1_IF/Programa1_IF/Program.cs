Console.WriteLine("--- Programa tienda ---");

Console.WriteLine("\nIngresa el tipo de cliente");
Console.WriteLine("1 | Regular");
Console.WriteLine("2 | Frecuente");
Console.WriteLine("3 | VIP");
int tipoCliente = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nIngresa el monto total de la compra");
double montoTotal = Convert.ToDouble(Console.ReadLine());

if (tipoCliente == 1)
{
    Console.WriteLine("\nTipo de cliente: Regular");
}
else if (tipoCliente == 2)
{
    Console.WriteLine("\nTipo de cliente: Frecuente");
}
else if (tipoCliente == 3)
{
    Console.WriteLine("\nTipo de cliente: VIP");
}
else
{
    Console.WriteLine("\nTipo de cliente no valido");
}

if (montoTotal > 100 && (tipoCliente == 2 || tipoCliente == 3))
{
    double descuento = montoTotal * 0.15;
    double montoFinal = montoTotal - descuento;
    Console.WriteLine("\nEl descuento es de 15%");
    Console.WriteLine("Monto final a pagar: " + montoFinal);
}
else
{
    Console.WriteLine("\nEl cliente no recibe descuento");
    Console.WriteLine("Monto a pagar: " + montoTotal);
}