/*
Cálculo de factura eléctrica según tipo de cliente
Desarrolle un programa en C# que solicite tres datos: nombre del cliente, cantidad de kilovatios consumidos y 
tipo de cliente (1 = Residencial, 2 = Comercial, 3 = Industrial).
Utilice if-else para validar que el consumo sea mayor que cero. Luego, use switch para aplicar una tarifa según el tipo de cliente:

Residencial: $0.15 por kWh
Comercial: $0.22 por kWh
Industrial: $0.30 por kWh

El programa debe realizar dos operaciones: calcular el subtotal del consumo y calcular un recargo del 7% sobre dicho subtotal. 
Debe mostrar dos salidas: el subtotal y el total a pagar con recargo.
Finalmente, guarde la respuesta en un archivo de texto llamado factura_electrica.txt, 
incluyendo nombre del cliente, consumo, tipo de cliente, resultados, fecha y hora de generación del reporte.
 */

using System;
using System.IO;
class program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese su nombre: ");
        string nombreCliente = Console.ReadLine();
        Console.Write("Ingrese la cantidad de kilovatios consumidos: ");
        double cantidadKilov = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el tipo de cliente que es: \n" +
            "1. Residencial\n" +
            "2. Comercial \n" +
            "3. Industrial");
        int tipoCliente = Convert.ToInt32(Console.ReadLine());

        double tarifa = 0;
        double calculoSubtotal = 0;
        double totalRecargo = 0;
        string fechaHora = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

        switch (tipoCliente)
            {
                case 1:
                   if(cantidadKilov > 0)
                    {
                        tarifa = 0.15;
                    calculoSubtotal = cantidadKilov * tarifa;
                    totalRecargo = calculoSubtotal + 0.07;
                }
                    break;
                case 2:
                   if (cantidadKilov > 0)
                   {
                    tarifa = 0.22;
                    calculoSubtotal = cantidadKilov * tarifa;
                    totalRecargo = calculoSubtotal + 0.07;
                   }
                break;
                case 3:
                   if (cantidadKilov > 0)
                   {
                    tarifa = 0.30;
                    calculoSubtotal = cantidadKilov * tarifa;
                    totalRecargo = calculoSubtotal + 0.07;
                   }
                break;
                default:
                    Console.WriteLine("Error.");
                    break;
            }
        String tipoClienteStr = tipoCliente switch
        {
            1 => "Residencial",
            2 => "Comercial",
            3 => "Industrial",
            _ => "Desconocido"
        };

        string Contenido =
             "******** FACTURA ELÉCTRICA ********\n"+
            $"Nombre del cliente: {nombreCliente} \n" +
            $"la fecha es: {fechaHora} \n" +
            $"El consumo es: {cantidadKilov} kWh\n" +
            $"Tipo de cliente: {tipoClienteStr}\n" +
            $"Subtotal de la cuenta : $ {calculoSubtotal} \n" +
            $"Total a Pagar; $ {totalRecargo}";

       // Guardar en archivo de texto
        File.WriteAllText("factura_electrica.txt", Contenido);

        Console.WriteLine("Factura generada y guardada como 'factura_electrica.txt'.");
    }
}