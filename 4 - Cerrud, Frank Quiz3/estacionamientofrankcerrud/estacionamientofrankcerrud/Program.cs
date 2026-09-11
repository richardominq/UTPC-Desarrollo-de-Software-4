using System;
using System.IO;

Console.WriteLine("Sistema de pago de estacionamiento");

Console.WriteLine("Ingrese la placa del vehiculo:");
string placavehiculo;
placavehiculo = Console.ReadLine();

Console.WriteLine("Ingrese la cantidad de horas estacionado del vehiculo (1 - 24):");
int cantidadhoras;
cantidadhoras = int.Parse(Console.ReadLine());

if (cantidadhoras < 1 || cantidadhoras > 24)
{
    Console.WriteLine("Error: no ingresó una cantidad de horas entre 1 y 24.");
    return;
}

Console.WriteLine("Tipo de vehiculo: \n" +
    "1 = Moto, 2 = Auto, 3 = Camioneta");
int tipovehiculo;
tipovehiculo = int.Parse(Console.ReadLine());

double tarifa = 0;
double subtotal = 0;
double descuento = 0.10;
String nombretipovehiculo = "";

switch (tipovehiculo)
{
    case 1:
        {
            nombretipovehiculo = "Moto";
            tarifa = 0.75;
            break;
        }
    case 2:
        {
            nombretipovehiculo = "Auto";
            tarifa = 1.50;
            break;
        }
    case 3:
        {
            nombretipovehiculo = "Camioneta";
            tarifa = 2.25;
            break;
        }
    default:
        {
            Console.WriteLine("Error: No ingresó un tipo de vehículo válido.");
            return;
        }
}

subtotal = tarifa * cantidadhoras;
double descuentoaplicado = 0;
double totalapagar = subtotal;

if (cantidadhoras > 8)
{
    descuentoaplicado = subtotal * descuento;
    totalapagar = subtotal - descuentoaplicado;
}

Console.WriteLine("Costo base: $" + subtotal);
Console.WriteLine("Descuento de 10%: $" + descuentoaplicado);
Console.WriteLine("Total a pagar: $" + totalapagar);

File.WriteAllText("reporte_estacionamiento.txt", "REPORTE DE ESTACIONAMIENTO\n" +
    "Fecha y hora de emisión: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "\n\n" +
    "Placa del vehículo: " + placavehiculo +
    "\nTipo de vehículo: " + nombretipovehiculo +
    "\nCantidad de horas: " + cantidadhoras +
    "\nCosto base: " + subtotal +
    "\nDescuento aplicado: " + descuentoaplicado +
    "\nTotal a pagar: " + totalapagar);