Console.WriteLine("Bienvenido a la tienda.");

Console.WriteLine("Ingrese el monto de su compra.");
string entradamonto = Console.ReadLine();
float monto = float.Parse(entradamonto);

Console.WriteLine("¿Qué tipo de usuario es?\n" +
    "1. Regular\n" +
    "2. Frecuente\n" +
    "3. VIP");
string entradatipo = Console.ReadLine();
int tipo = int.Parse(entradatipo); // Usamos int para que el switch funcione perfecto

double descuento = 0.15;
double montofinal;

switch (tipo)
{
    case 1:
        Console.WriteLine("No recibe descuento. El monto original que deberá pagar es: $" + monto);
        break;

    case 2:
        if (monto > 100)
        {
            montofinal = monto - (monto * descuento);
            Console.WriteLine("Descuento Aplicado. El monto final es: $" + montofinal);
        }
        else
        {
            Console.WriteLine("No recibe descuento (monto menor o igual a $100). Monto Final: $" + monto);
        }
        break;
    case 3:
        if (monto > 100)
        {
            montofinal = monto - (monto * descuento);
            Console.WriteLine("Descuento Aplicado. El monto final es: $" + montofinal);
        }
        else
        {
            Console.WriteLine("No recibe descuento (monto menor o igual a $100). Monto Final: $" + monto);
        }
        break;

    default:
        Console.WriteLine("Opcion invalida");
        break;
}

Console.WriteLine("Gracias por usar la tienda");