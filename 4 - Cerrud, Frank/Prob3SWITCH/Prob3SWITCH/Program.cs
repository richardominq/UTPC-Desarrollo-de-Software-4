Console.WriteLine("Bienvenido al Sistema de Entrada para Evento");

Console.WriteLine("Ingrese la edad de la persona");
string entradaedad = Console.ReadLine();
byte edad = byte.Parse(entradaedad);

Console.WriteLine("Ingrese la cantidad de boletos");
string entradacantidad = Console.ReadLine();
int cantidad = int.Parse(entradacantidad);

Console.WriteLine("Ingrese el tipo de entrada\n" +
    "1. General\n" +
    "2. VIP\n" +
    "3. Invitado");
string entradatipo = Console.ReadLine();
int tipo = int.Parse(entradatipo);

if (edad >= 18 && cantidad > 0 && (tipo == 1 || tipo == 2 || tipo == 3))
{
    string nombreTipo = "";

    switch (tipo)
    {
        case 1:
            nombreTipo = "General";
            break;
        case 2:
            nombreTipo = "VIP";
            break;
        case 3:
            nombreTipo = "Invitado";
            break;
    }

    Console.WriteLine("Entrada autorizada\n" +
        "Tipo de entrada: " + nombreTipo);
}
else
{
    Console.WriteLine("Entrada rechazada. No cumple con las condiciones establecidas.");
}