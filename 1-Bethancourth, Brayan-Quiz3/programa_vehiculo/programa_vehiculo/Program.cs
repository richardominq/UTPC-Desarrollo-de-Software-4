class Programa1
{
    static void Main()
    {
        string placa;
        int horas, tipo_vehiculo;
        double tarifa_hora = 0, costo_base = 0, descuento = 0, total_pagar = 0;
        string tipoVehiculo = "";

        Console.WriteLine($"Ingrese la placa del vehiculo: ");
        placa = Console.ReadLine();

        Console.WriteLine($"Ingrese la cantidad de horas estacionado: ");
        horas = int.Parse(Console.ReadLine());

        if (horas < 1 || horas > 24)
        {
            Console.WriteLine($"Ingrese un valor valido entre 1 y 24");
            return;
        }

        Console.WriteLine($"Ingrese el tipo de vehiculo: ");
        Console.WriteLine($"1 = Moto");
        Console.WriteLine($"2 = Auto");
        Console.WriteLine($"3 = Camioneta");
        tipo_vehiculo = int.Parse(Console.ReadLine());

        switch (tipo_vehiculo)
        {
            case 1:
                tipoVehiculo = "Moto";
                tarifa_hora = 0.75;
                break;

            case 2:
                tipoVehiculo = "Auto";
                tarifa_hora = 1.50;
                break;

            case 3:
                tipoVehiculo = "Camioneta";
                tarifa_hora = 2.25;
                break;

            default:
                Console.WriteLine($"Opción invalida!");
                return;
        }

        costo_base = horas * tarifa_hora;

        if (horas > 8)
        {
            descuento = costo_base * 0.10;
            total_pagar = costo_base - descuento;
        }
        else
        {
            total_pagar = costo_base;
        }

        Console.WriteLine($"Costo base: ${costo_base:F2}");
        Console.WriteLine($"Total a pagar: ${total_pagar:F2}");

        DateTime fechaHora = DateTime.Now;

        string datos =
            "Reporte de Estacionamiento\n" +
            "Fecha y hora: " + fechaHora + "\n\n" +
            "Placa: " + placa + "\n" +
            "Tipo de vehiculo: " + tipoVehiculo + "\n" +
            "Horas estacionado: " + horas + "\n" +
            "Costo base: $" + costo_base.ToString("F2") + "\n" +
            "Total a pagar: $" + total_pagar.ToString("F2") + "\n";

        File.WriteAllText("reporte_estacionamiento.txt", datos);
    }
}