// See https://aka.ms/new-console-template for more informatio// See https://aka.ms/new-console-template for more information
string tipoboletosNombre;

Console.WriteLine("Bienvenidos al evento [Placeholder].\n\n");
Console.WriteLine("Ingrese su edad.");
int edad = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Ingrese la cantidad de boletos que posee.");
int cantidadboletos = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Seleccione el tipo de boleto:");
Console.WriteLine(" 1- General\n 2- VIP \n 3-Invitado");
int tipoboletos = Convert.ToInt32(Console.ReadLine());

switch (tipoboletos) // Switch que define el tipo de boleto
{
    case 1:
        Console.WriteLine($"Tipo de boleto seleccionado: {tipoboletosNombre}");
        IngresoEvento(edad, cantidadboletos, tipoboletosNombre);
        break;
    case 2:
        Console.WriteLine($"Tipo de boleto seleccionado: {tipoboletosNombre}");
        IngresoEvento(edad, cantidadboletos, tipoboletosNombre);
        break;
    case 3:        
        Console.WriteLine($"Tipo de boleto seleccionado: {tipoboletosNombre}");
        IngresoEvento(edad, cantidadboletos, tipoboletosNombre);
        break;
    default:
        Console.WriteLine($"Tipo de boleto no válido");
        break;
}
static void IngresoEvento(int edad, int cantidadboletos, String tipoboletosNombre) // Método que define el ingreso al evento
{
    if (edad >= 18 && cantidadboletos >= 1) // Condicional que define el tipo de boleto
    {
        Console.WriteLine($"Entrada Aprobada \n" +
                   $"Bienvenido al evento [Placeholder] \n" +
                   $"Edad: {edad} \n" +
                   $"Cantidad de boletos: {cantidadboletos} \n" +
                   $"Tipo de boleto: {tipoboletosNombre}");
    }
    else if (cantidadboletos <= 0)
    {
        Console.WriteLine($"Entrada Rechazada \n" +
                  $"Cantidad de boletos no válida");
    }
    else if (edad < 18)
    {
        Console.WriteLine($"Entrada Rechazada \n" +
                  $"Edad no válida");
    }
    else { Console.WriteLine("datos no válidos"); }
}

