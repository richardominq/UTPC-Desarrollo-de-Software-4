/*14.Diagnóstico básico de batería
Solicite el porcentaje de batería y el estado del cargador (1 = Conectado, 2 = Desconectado). 
Si la batería está por debajo del 20 % y el cargador está desconectado, muestre “Conecte el cargador”. 
Si está por encima del 80 %, muestre “Nivel de batería adecuado”. Muestre además el porcentaje actual.

Entradas: 2.Salidas: 2.
Utilizar: if, &&. */


Console.WriteLine("Por favor, ingrese el porcentaje de batería (0-100):");
string bateriaInput = Console.ReadLine();
int bateria = int.Parse(bateriaInput);

Console.WriteLine("Por favor, ingrese el estado del cargador (1 = Conectado, 2 = Desconectado):");
string cargadorInput = Console.ReadLine();
int cargador = int.Parse(cargadorInput);

//Validaci[on de entradas usando SOLO if y && (AND)
if (bateria < 20 && bateria >= 0 && cargador == 2)
{
    Console.WriteLine($"Conecte el cargador. \n Porcentaje de batería: {bateria}%"); // Muestra el porcentaje actual de batería
}
else if (bateria > 80 && bateria <= 100)
{
    Console.WriteLine($"Nivel de batería adecuado. \n Porcentaje de batería: {bateria}%"); // Muestra el porcentaje actual de batería
} 
else if (bateria > 100) // If else para informar el ingreso de valores invalidos.
{
    Console.WriteLine($"Porcentaje de batería: Invalido");
}
else if (bateria < 0)
{
    Console.WriteLine($"Porcentaje de batería: Invalido");
}
else if (cargador < 0)
{
    Console.WriteLine($"Estado de cargador Invalido");
}
else if (cargador > 2)
{
    Console.WriteLine($"Estado de cargador Invalido");
}
else // If else para mostrar el porcentaje de batería en caso de que no se cumpla ninguna de las condiciones anteriores.
{
    Console.WriteLine($"Porcentaje de batería: {bateria}%");
}