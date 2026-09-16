using System;
using System.IO;

Console.WriteLine("Sistema de venta de boletos para evento");

Console.WriteLine("Ingrese el nombre del comprador:");
string nombrecomprador;
nombrecomprador = Console.ReadLine();

Console.WriteLine("Ingrese la cantidad de boletos (1 - 10):");
int cantidadboletos;
cantidadboletos = int.Parse(Console.ReadLine());

if (cantidadboletos < 1 || cantidadboletos > 10)
{
    Console.WriteLine("Error: La cantidad de boletos debe estar entre 1 y 10.");
    return;
}

Console.WriteLine("Categoría seleccionada: \n" +
    "1 = General, 2 = Preferencial, 3 = VIP");
int categoriaseleccionada;
categoriaseleccionada = int.Parse(Console.ReadLine());

double preciounitario = 0;
double subtotal = 0;
double descuento = 0.12;
String nombrecategoria = "";

switch (categoriaseleccionada)
{
    case 1:
        {
            nombrecategoria = "General";
            preciounitario = 15.00;
            break;
        }
    case 2:
        {
            nombrecategoria = "Preferencial";
            preciounitario = 30.00;
            break;
        }
    case 3:
        {
            nombrecategoria = "VIP";
            preciounitario = 50.00;
            break;
        }
    default:
        {
            Console.WriteLine("Error: No ingresó una categoría válida.");
            return;
        }
}

subtotal = preciounitario * cantidadboletos;
double descuentoaplicado = 0;
double totalapagar = subtotal;

if (cantidadboletos >= 5)
{
    descuentoaplicado = subtotal * descuento;
    totalapagar = subtotal - descuentoaplicado;
}

Console.WriteLine("Subtotal: $" + subtotal);
Console.WriteLine("Descuento aplicado: $" + descuentoaplicado);
Console.WriteLine("Total a pagar: $" + totalapagar);

File.WriteAllText("reporte_boletos.txt", "REPORTE DE VENTA DE BOLETOS\n" +
    "Fecha y hora de emisión: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "\n\n" +
    "Nombre del comprador: " + nombrecomprador +
    "\nCantidad de boletos: " + cantidadboletos +
    "\nCategoría seleccionada: " + nombrecategoria +
    "\nSubtotal: " + subtotal +
    "\nDescuento aplicado: " + descuentoaplicado +
    "\nTotal a pagar: " + totalapagar);