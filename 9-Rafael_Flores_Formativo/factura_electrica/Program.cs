using System;
using System.IO;

class Program
{
    static void Main()
    {
        string nombre;
        double consumo;
        int tipoCliente;
        double tarifa = 0;
        string tipoTexto = "";

        Console.Write("Ingrese el nombre del cliente: ");
        nombre = Console.ReadLine();

        Console.Write("Ingrese la cantidad de kWh consumidos: ");
        consumo = Convert.ToDouble(Console.ReadLine());

        // Validar que el consumo sea mayor que cero
        if (consumo <= 0)
        {
            Console.WriteLine("El consumo debe ser mayor que cero.");
            return;
        }
        else
        {
            Console.WriteLine("Consumo válido.");
        }

        Console.WriteLine("\nTipos de cliente:");
        Console.WriteLine("1 = Residencial");
        Console.WriteLine("2 = Comercial");
        Console.WriteLine("3 = Industrial");
        Console.Write("Seleccione el tipo de cliente: ");
        tipoCliente = Convert.ToInt32(Console.ReadLine());

        // Aplicar tarifa según el tipo de cliente
        switch (tipoCliente)
        {
            case 1:
                tarifa = 0.15;
                tipoTexto = "Residencial";
                break;

            case 2:
                tarifa = 0.22;
                tipoTexto = "Comercial";
                break;

            case 3:
                tarifa = 0.30;
                tipoTexto = "Industrial";
                break;

            default:
                Console.WriteLine("Tipo de cliente no válido.");
                return;
        }

        // Calcular subtotal
        double subtotal = consumo * tarifa;

        // Calcular recargo del 7%
        double recargo = subtotal * 0.07;

        // Calcular total
        double total = subtotal + recargo;

        // Mostrar resultados
        Console.WriteLine("\n--- FACTURA ELÉCTRICA ---");
        Console.WriteLine("Cliente: " + nombre);
        Console.WriteLine("Consumo: " + consumo + " kWh");
        Console.WriteLine("Tipo de cliente: " + tipoTexto);
        Console.WriteLine("Subtotal: $" + subtotal.ToString("F2"));
        Console.WriteLine("Total a pagar con recargo: $" + total.ToString("F2"));


        // Crear contenido del archivo
        string factura =
            "--- FACTURA ELÉCTRICA ---\n" +
            "Nombre del cliente: " + nombre + "\n" +
            "Consumo: " + consumo + " kWh\n" +
            "Tipo de cliente: " + tipoTexto + "\n" +
            "Tarifa: $" + tarifa.ToString("F2") + " por kWh\n" +
            "Subtotal: $" + subtotal.ToString("F2") + "\n" +
            "Recargo (7%): $" + recargo.ToString("F2") + "\n" +
            "Total a pagar: $" + total.ToString("F2") + "\n";


        // Guardar la factura en un archivo de texto
        File.WriteAllText("factura_electrica.txt", factura);

        Console.WriteLine("\nLa factura se guardó como ---> factura_electrica.txt");
    }
}
