/*
 Desarrolle un programa en C# que solicite tres datos: placa del vehículo, cantidad de horas estacionado y 
tipo de vehículo (1 = Moto, 2 = Auto, 3 = Camioneta).
Utilice if-else para comprobar que las horas estén entre 1 y 24. Emplee switch para definir la tarifa por hora:

Moto: $0.75 por hora
Auto: $1.50 por hora
Camioneta: $2.25 por hora

El programa debe realizar dos operaciones: calcular el costo base según las horas y aplicar un descuento del 10% si 
el vehículo permaneció más de 8 horas. 
Debe mostrar dos salidas: costo base y total a pagar después del posible descuento.
Guarde todos los datos y resultados en un archivo llamado reporte_estacionamiento.txt, incluyendo la fecha y hora en
que se generó cada reporte.
 */

using System;
using System.IO;
class program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese la placa del vehiculo: ");
        String placaVeh = Console.ReadLine();
        Console.Write("Ingrese las horas estacionado: ");
        double horasEsta = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el tipo de vehiculo: \n" +
           "1. Moto\n" +
           "2. Auto \n" +
           "3. Camioneta");
        int tipoVehiculo = Convert.ToInt32(Console.ReadLine());

        double tarifaHora = 0;
        double CalculoCos = 0;
        double totalPagar = 0;
        string fechaHora = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        switch (tipoVehiculo)
        {
            case 1:
                if (horasEsta >= 1 && horasEsta <= 24)
                {
                    tarifaHora = 0.75;
                    CalculoCos = horasEsta * tarifaHora;
                    totalPagar = CalculoCos;
                }else if(horasEsta > 8)
                {
                    totalPagar = CalculoCos - 0.10;
                }
                break;
            case 2:
                if (horasEsta >= 1 && horasEsta <= 24)
                {
                    tarifaHora = 1.50;
                    CalculoCos = horasEsta * tarifaHora;
                    totalPagar = CalculoCos;
                }
                else if (horasEsta > 8)
                {
                    totalPagar = CalculoCos - 0.10;
                }
                break;
            case 3:
                if (horasEsta >= 1 && horasEsta <= 24)
                {
                    tarifaHora = 2.25;
                    CalculoCos = horasEsta * tarifaHora;
                    totalPagar = CalculoCos;
                }
                else if (horasEsta > 8)
                {
                    totalPagar = CalculoCos - 0.10;
                }
                break;
            default:
                Console.WriteLine("ERROR. ");
                break;
        }
        String tipoVehiculoStr = tipoVehiculo switch
        {
            1 => "Moto",
            2 => "Auto",
            3 => "Camioneta",
            _ => "Desconocido"
        };
        string Contenido =
        "******** FACTURA ELÉCTRICA ********\n" +
        $"Placa del vehiculo: {placaVeh} \n" +
        $"la fecha Y hora es: {fechaHora} \n" +
         $"Tipo de vehiculo: {tipoVehiculo}\n" +
        $"Horas estacionado/a: {horasEsta}\n" +
        $"Total a Pagar; $ {totalPagar}";

        // Guardar en archivo de texto
        File.WriteAllText("reporte_estacionamiento.txt", Contenido);

        Console.WriteLine("Factura generada y guardada como 'factura_electrica.txt'.");

    }
}
