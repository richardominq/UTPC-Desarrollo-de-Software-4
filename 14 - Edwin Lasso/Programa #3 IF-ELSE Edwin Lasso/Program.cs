
// See https://aka.ms/new-console-template for more informatio// See https://aka.ms/new-console-template for more information

Console.WriteLine("Bienvenidos al evento [Placeholder].\n\n");
Console.WriteLine("Ingrese su edad.");
int edad = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Ingrese la cantidad de boletos que posee.");
int cantidadboletos = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Seleccione el tipo de boleto:");
Console.WriteLine(" 1- General\n 2- VIP \n 3-Invitado");
int tipoboletos = Convert.ToInt32(Console.ReadLine());

if (edad >= 18 && cantidadboletos >= 1 && (tipoboletos == 1 || tipoboletos == 2 || tipoboletos == 3)) // Condicional que cumple con los requeisitos minimos para poder ingresar al evento
{
    IngresoEvento(edad, cantidadboletos, tipoboletos);

}
else if (edad < 18 && cantidadboletos >= 1 && (tipoboletos == 1 || tipoboletos == 2 || tipoboletos == 3)) //Condicional que define si la edad es menor a 18 años
{
    Console.WriteLine($"Entrada Rechazada \n" +
                      $"No se cumplen con la minima edad requerida");


}
else if (cantidadboletos <= 0) // Condicional que define si la cantidad de boletos es válida
{
    Console.WriteLine($"Cantidad de boletos no válida");

}
else if (tipoboletos > 3 || tipoboletos < 1) // Condicional que define si el tipo de boleto es válido
{
    Console.WriteLine($"Tipo de boleto no válido");

}
else // Else que define si los datos ingresados son válidos, en caso de que no lo sean, se mostrará un mensaje de error
{
    Console.WriteLine($"Hubo un error en los datos");

}

static void IngresoEvento(int edad, int cantidadboletos, int tipoboletos) // Método que define el ingreso al evento
{
    if (tipoboletos == 1) // Condicional que define el tipo de boleto
    {
        Console.WriteLine($"Entrada Aprobada \n" +
                   $"Bienvenido al evento [Placeholder] \n" +
                   $"Edad: {edad} \n" +
                   $"Cantidad de boletos: {cantidadboletos} \n" +
                   $"Tipo de boleto: General");
    }
    else if (tipoboletos == 2)
    {
        Console.WriteLine($"Entrada Aprobada \n" +
                  $"Bienvenido al evento [Placeholder] \n" +
                  $"Edad: {edad} \n" +
                  $"Cantidad de boletos: {cantidadboletos} \n" +
                  $"Tipo de boleto: VIP");
    }
    else if (tipoboletos == 3)
    {
        Console.WriteLine($"Entrada Aprobada \n" +
                  $"Bienvenido al evento [Placeholder] \n" +
                  $"Edad: {edad} \n" +
                  $"Cantidad de boletos: {cantidadboletos} \n" +
                  $"Tipo de boleto: Invitado");
    }
}