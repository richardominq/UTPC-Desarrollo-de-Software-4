/*
 Venta de boletos para un evento

Desarrolle un programa en C# que solicite tres datos: nombre del comprador, cantidad de boletos y categoría seleccionada (1 = General, 2 = Preferencial, 3 = VIP).
Utilice if-else para validar que la cantidad de boletos esté entre 1 y 10. Luego, use switch para determinar el precio unitario:

General: $15.00
Preferencial: $30.00
VIP: $50.00

El programa debe realizar dos operaciones: calcular el subtotal de la compra y calcular un descuento del 12% cuando se compren 5 o más boletos. 
Debe mostrar dos salidas: subtotal y total final a pagar.
El programa debe guardar los datos del comprador, categoría, boletos, resultados, fecha y hora de generación en un archivo de texto llamado reporte_boletos.txt.
 */

using System;
using System.IO;

class program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese el nombre del comprador: ");
        String nombreComp = Console.ReadLine();
        Console.Write("Ingrese las horas estacionado: ");
        double cantidadBol = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el tipo de vehiculo: \n" +
           "1. General\n" +
           "2. Preferencial\n" +
           "3. VIP");
        int tipoVehiculo = Convert.ToInt32(Console.ReadLine());
        
        double categoBole = 0;
        double Calculosub = 0;
        double totalPagar = 0;
        string fechaHora = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

        switch (tipoVehiculo)
        {
            case 1:
                if (cantidadBol >= 1 && cantidadBol <= 10)
                {
                    categoBole = 15.00;
                    Calculosub = cantidadBol * categoBole;
                    totalPagar = Calculosub;
                }
                else if (cantidadBol >= 5)
                {
                    totalPagar = Calculosub - 0.12;
                }
                break;
            case 2:
                if (cantidadBol >= 1 && cantidadBol <= 10)
                {
                    categoBole = 30.00;
                    Calculosub = cantidadBol * categoBole;
                    totalPagar = Calculosub;
                }
                else if (cantidadBol >= 5)
                {
                    totalPagar = Calculosub - 0.12;
                }
                break;
            case 3:
                if (cantidadBol >= 1 && cantidadBol <= 10)
                {
                    categoBole = 50.00;
                    Calculosub = cantidadBol * categoBole;
                    totalPagar = Calculosub;
                }
                else if (cantidadBol >= 5)
                {
                    totalPagar = Calculosub - 0.12;
                }
                break;
            default:
                Console.WriteLine("ERROR. ");
                break;
        }
        String tipoVehiculoStr = tipoVehiculo switch
        {
            1 => "General",
            2 => "Preferencial",
            3 => "VIP",
            _ => "Desconocido"
        };

        string Contenido =
     "******** FACTURA ELÉCTRICA ********\n" +
    $"Nombre del cliente: {nombreComp} \n" +
    $"fecha y hora: {fechaHora} \n" +
     $"Tipo de categoría: {tipoVehiculo}\n" +
    $"Cantidad de boletos: {cantidadBol}\n"+
    $"Total a Pagar; $ {totalPagar}";

        // Guardar en archivo de texto
        File.WriteAllText("reporte_boletos.txt", Contenido);

        Console.WriteLine("Factura generada y guardada como 'reporte_boletos.txt'.");
    }
}