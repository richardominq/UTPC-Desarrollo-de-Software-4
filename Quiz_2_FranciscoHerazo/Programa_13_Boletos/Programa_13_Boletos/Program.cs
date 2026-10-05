
Console.Write("Ingresa la cantidad de boletos: ");
int cantidad = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingresa el precio individual: ");
double precio = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingresa la categoria \n 1 | General\n 2 | Preferencial\n 3 | VIP): ");
int categoria = Convert.ToInt32(Console.ReadLine());

double porcentaje = categoria switch
{
    1 => 0.0,
    2 => 0.10,
    3 => 0.25,
    _ => 0.0
};

double subtotal = cantidad * precio;
double ajuste = subtotal * porcentaje;
double total = subtotal + ajuste;

Console.WriteLine("Subtotal: " + subtotal);
Console.WriteLine("Ajuste aplicado: " + ajuste);
Console.WriteLine("Total: " + total);