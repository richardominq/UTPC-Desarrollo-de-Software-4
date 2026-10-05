/*25. Reserva de hotel
Solicite la cantidad de noches, la cantidad de personas, el tipo de habitación (1 = Individual, 2 = Doble, 3 = Familiar)
y la temporada (1 = Baja, 2 = Alta). Utilice switch para establecer el precio de la habitación.
Si reserva 5 noches o más y es temporada baja, aplique descuento. Muestre el subtotal, el descuento y el total.

Entradas: 4. Salidas: 3.
Utilizar: if, &&, switch.
*/

Console.WriteLine("Bienvenido al sistema de reserva de hotel");

Console.WriteLine("Ingrese la cantidad de noches:");
int noches = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la cantidad de personas:");
int personas = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el tipo de habitación (1 = Individual, 2 = Doble, 3 = Familiar):");
int tipoHabitacion = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la temporada (1 = Baja, 2 = Alta):");
int temporada = int.Parse(Console.ReadLine());

double precioPorNoche = 0;
switch (tipoHabitacion)
{
    case 1:
        precioPorNoche = 50.0;
        break;
    case 2:
        precioPorNoche = 80.0;
        break;
    case 3:
        precioPorNoche = 120.0;
        break;
    default:
        precioPorNoche = 50.0;
        break;
}

double subtotal = noches * precioPorNoche;

double descuento = 0;
if (noches >= 5 && temporada == 1)
{
    descuento = subtotal * 0.15; 
}

double total = subtotal - descuento;

Console.WriteLine("--- Resultados de la Reserva ---");
Console.WriteLine("Subtotal: $" + subtotal);
Console.WriteLine("Descuento aplicado: $" + descuento);
Console.WriteLine("Total a pagar: $" + total);