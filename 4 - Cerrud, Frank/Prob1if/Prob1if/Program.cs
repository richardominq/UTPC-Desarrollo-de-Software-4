Console.WriteLine("Bienvenido a la tienda.");

Console.WriteLine("Ingrese el monto de su compra.");
string entradamonto = Console.ReadLine();
float monto = float.Parse(entradamonto);

Console.WriteLine("¿Qué tipo de usuario es?\n" +
    "1. Regular\n" +
    "2. Frecuente\n" +
    "3. VIP");
string entradatipo = Console.ReadLine();
float tipo = float.Parse(entradatipo);

double descuento = 0.15;
double montofinal;

if (tipo == 1)
{
    Console.WriteLine("No recibe descuento. El monto original que deberá pagar es: $" + monto);
}
else if (tipo == 2 || tipo == 3)
{
    if (monto > 100)
    {
        montofinal = monto - (monto * descuento);
        Console.WriteLine("Descuento Aplicado. El monto final es: $" + montofinal);
    }
    else
    {
        Console.WriteLine("No recibe descuento (monto menor o igual a $100). Monto Final: $" + monto);
    }
}
else
{
    Console.WriteLine("Opcion invalida");
}

Console.WriteLine("Gracias por usar la tienda"); 