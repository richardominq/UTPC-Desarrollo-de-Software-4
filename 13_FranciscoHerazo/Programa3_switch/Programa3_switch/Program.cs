Console.WriteLine("--- Entrada a un evento ---");

Console.WriteLine("\nIngresa tu edad");
int edad = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nIngresa la cantidad de boletos disponibles");
int boletosDisponibles = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nIngrese el tipo de entrada");
Console.WriteLine("1 | General");
Console.WriteLine("2 | VIP");
Console.WriteLine("3 | Invitado");
int tipoEntrada = Convert.ToInt32(Console.ReadLine());

switch (tipoEntrada)
{
    case 1:
        Console.WriteLine("\nTipo de entrada: General");
        break;
    case 2:
        Console.WriteLine("\nTipo de entrada: VIP");
        break;
    case 3:
        Console.WriteLine("\nTipo de entrada: Invitado");
        break;
    default:
        Console.WriteLine("\nTipo de entrada no valido");
        break;
}

if (edad >= 18 && boletosDisponibles >= 1 && (tipoEntrada == 1 || tipoEntrada == 2 || tipoEntrada == 3))
{
    Console.WriteLine("\nEntrada autorizada");
    Console.WriteLine("Tipo de entrada: " + tipoEntrada);
}
else
{
    Console.WriteLine("\nEntrada rechazada");
    Console.WriteLine("La persona no cumple con las condiciones establecidas");
}