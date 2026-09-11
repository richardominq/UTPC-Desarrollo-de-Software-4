using System;
using System.IO;



Console.WriteLine("Bienvenido al sistema de factura eléctrica.");

Console.WriteLine("Ingrese el nombre del cliente:");
string nombrecliente;
nombrecliente = Console.ReadLine();

Console.WriteLine("Ingrese cantidad de kilovatios (kwh) consumidos por el cliente:");
double cantidadkhw;
cantidadkhw = float.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el tipo de cliente: \n" +
    "1 = Residencial, 2 = Comercial, 3 = Industrial");
int tipocliente;
tipocliente = int.Parse(Console.ReadLine());

if (cantidadkhw <= 0)
{
    Console.WriteLine("Ingrese cantidad mayor a 0, no se pueden realizar los cálculos.");
    return;
}

double subtotal = 0;
double recargo = 0.07;
double totalapagar = 0;

String nombretipocliente = "";
switch (tipocliente)
{
    case 1:
        {
            subtotal = cantidadkhw * 0.15;
            nombretipocliente = "Residencial";
            break;
        }

    case 2:
        {
            subtotal = cantidadkhw * 0.22;
            nombretipocliente = "Comercial";
            break;
        }
    case 3:
        {
            subtotal = cantidadkhw * 0.30;
            nombretipocliente = "Indstrial";
            break;
        }
    default:
        {
            Console.WriteLine("Error: No ingreso un tipo de cliente valido.");
            return;
        }
}

double recargototal = subtotal * recargo;
totalapagar = subtotal + (subtotal * recargo);
Console.WriteLine("Subtotal: $" + subtotal);
Console.WriteLine("Regargo de 7%: " + recargototal);
Console.WriteLine("Total a pagar: $" + totalapagar);

File.WriteAllText("factura_electrica.txt", "REPORTE DE FACTURA ELÉCTRICA\n" +
    "Fecha y hora de emisión: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "\n\n" +
    "Nombre del cliente: " + nombrecliente +
    "\nConsumo del cliente: " + cantidadkhw +
    "\nTipo de cliente: " + nombretipocliente +
    "\nSubtotal: " + subtotal +
    "\nRecargo del 7% aplicado: " + recargototal +
    "\nTotal a pagar: " + totalapagar);