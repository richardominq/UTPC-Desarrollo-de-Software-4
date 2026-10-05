Console.WriteLine("Sistema para un evento");

//variables a utilizar
int edad;
int boletos;
int tipoentrada;
string nombreEntrada;

//solicitar edad
Console.WriteLine($"Ingrese su edad: ");
edad = int.Parse( Console.ReadLine() );

//solicitar boletos
Console.WriteLine($"Ingrese la cantidad de boletos disponibles: ");
boletos= int.Parse( Console.ReadLine() );

//mostrar las opciones de entrada
Console.WriteLine($"Seleccione el tipo de entrada: ");
Console.WriteLine($"1: General");
Console.WriteLine($"2: VIP");
Console.WriteLine($"3: Invitado");

tipoentrada = int.Parse( Console.ReadLine() );

//escogerl el tipo de entrada

switch (tipoentrada)
{
    case 1:
        nombreEntrada = "General";
        break;
    case 2:
        nombreEntrada = "VIP";
        break;
    case 3:
        nombreEntrada = "Invitado";
        break;

    default:
        Console.WriteLine($"Tipo de entrada no valida");
        return;
}

//validación de edad y cantidad de boletos

switch(edad>=18 && boletos >=1)
{
    case true:
        Console.WriteLine($"Entrada autorizada");
        Console.WriteLine($"Tipo de entrada: {nombreEntrada}");
        break;

    case false:
        Console.WriteLine($"Entrada rechazada");
        Console.WriteLine($"No cumple con las condiciones establecidas");
        break;
}
