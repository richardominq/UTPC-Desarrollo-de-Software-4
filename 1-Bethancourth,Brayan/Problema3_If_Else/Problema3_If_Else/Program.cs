Console.WriteLine($"Sistema de entrada a un evento");

// variables a utilizar
int edad;
int boletos;
int tipoentrada;
string nombreEntrada;

// Solicitar la edad
Console.WriteLine($"Ingrese su edad:");
edad = int.Parse(Console.ReadLine());

// Solicitar cantidad de boletos
Console.WriteLine($"Ingrese la cantidad de boletos disponibles:");
boletos = int.Parse(Console.ReadLine());

// Mostrar las opciones
Console.WriteLine($"Seleccione el tipo de entrada:");
Console.WriteLine($"1: General");
Console.WriteLine($"2: VIP");
Console.WriteLine($"3: Invitado");
tipoentrada= int.Parse(Console.ReadLine());

//validar la entrada
if (tipoentrada == 1)
{
    nombreEntrada = "General";
} else if (tipoentrada == 2)
{
    nombreEntrada = "VIP";
}else  if (tipoentrada == 3)
{
    nombreEntrada = "Invitado";
}
else
{
    Console.WriteLine($"Tipo de entrada no valida");
    return;
}

//validar las condiciones establecidas

if(edad >=18 && boletos >= 1)
{
    Console.WriteLine($"Entrada autorizada");
    Console.WriteLine($"Tipo de entrada: {nombreEntrada}");
}
else
{
    Console.WriteLine($"Entrada rechazada");
    Console.WriteLine($"No cumple con las condiciones establecidas)");
}