
double subtotal = 0, total_pagar = 0, descuento = 0;
int cantidad_boletos, categoria;
string nombre, categoriaTexto;


Console.WriteLine($"Ingrese el nombre del comprador: ");
nombre = Console.ReadLine();

Console.WriteLine($"Ingrese la cantidad de boletos: ");
cantidad_boletos=int.Parse(Console.ReadLine());

if(cantidad_boletos<1 || cantidad_boletos > 10)
{
    Console.WriteLine($"Ingrese una cantidad de voletos valida (1-10).");
    return;
}
else
{

}

Console.WriteLine($"Seleccione su categoria: ");
Console.WriteLine($"1= General");
Console.WriteLine($"2= Preferencial");
Console.WriteLine($"3= VIP");
categoria=int.Parse(Console.ReadLine());

switch (categoria)
{
    case 1:
        categoriaTexto = "General";
        subtotal = cantidad_boletos * 15.00;
        break;

    case 2:
        categoriaTexto = "Preferencial";
        subtotal = cantidad_boletos * 30.00;
        break;
    case 3:
        categoriaTexto = "VIP";
        subtotal = cantidad_boletos * 50.00;
        break;

    default:
        Console.WriteLine($"Ingrese una opción valida!");
        return;

}
if (cantidad_boletos >= 5)
{
    Console.WriteLine("Usted recibe un descuento del 12%");
    descuento = subtotal * 0.12;
    total_pagar = subtotal - descuento;
}else
{
    Console.WriteLine($"No recibe descuento: ");
    total_pagar= subtotal;
   
}

Console.WriteLine($"Subtotal: {subtotal:F2}");
Console.WriteLine($"Total a pagar: {total_pagar:F2}");

DateTime fechaHora = DateTime.Now;

string datos =
    "Reporte\n" +
    "Fecha y hora: " + fechaHora + "\n\n" +
    "Nombre: " + nombre + "\n" +
    "Categoria: " + categoriaTexto+ "\n" +
    "Cantidad de boletos: " + cantidad_boletos + "\n" +
    "Subtotal :" + subtotal.ToString("F2")+ "\n" +
    "Total a pagar: " + total_pagar.ToString("F2") + "\n";

File.WriteAllText("reporte_boletos.txt", datos);



