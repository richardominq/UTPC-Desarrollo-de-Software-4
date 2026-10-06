using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Solicitar datos
        Console.Write("Ingrese el nombre del comprador: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese la cantidad de boletos (1-10): ");
        int boletos = int.Parse(Console.ReadLine());

        Console.WriteLine("Categoría:");
        Console.WriteLine("1 = General");
        Console.WriteLine("2 = Preferencial");
        Console.WriteLine("3 = VIP");
        Console.Write("Seleccione la categoría: ");
        int categoria = int.Parse(Console.ReadLine());

        // Validar cantidad de boletos usando if-else
        if (boletos < 1 || boletos > 10)
        {
            Console.WriteLine("Error: la cantidad de boletos debe estar entre 1 y 10.");
            return;
        }

        // Determinar precio usando switch
        double precioUnitario = 0;
        string nombreCategoria = "";

        switch (categoria)
        {
            case 1:
                precioUnitario = 15.00;
                nombreCategoria = "General";
                break;

            case 2:
                precioUnitario = 30.00;
                nombreCategoria = "Preferencial";
                break;

            case 3:
                precioUnitario = 50.00;
                nombreCategoria = "VIP";
                break;

            default:
                Console.WriteLine("Error: categoría no válida.");
                return;
        }

        // Calcular subtotal
        double subtotal = boletos * precioUnitario;

        // Calcular descuento del 12% si compra 5 o más boletos
        double descuento = 0;

        if (boletos >= 5)
        {
            descuento = subtotal * 0.12;
        }

        // Calcular total final
        double totalFinal = subtotal - descuento;

        // Obtener fecha y hora
        DateTime fechaHora = DateTime.Now;

        // Mostrar resultados
        Console.WriteLine("\n--- REPORTE DE VENTA DE BOLETOS ---");
        Console.WriteLine("Comprador: " + nombre);
        Console.WriteLine("Categoría: " + nombreCategoria);
        Console.WriteLine("Cantidad de boletos: " + boletos);
        Console.WriteLine("Precio unitario: $" + precioUnitario.ToString("0.00"));
        Console.WriteLine("Subtotal: $" + subtotal.ToString("0.00"));
        Console.WriteLine("Descuento: $" + descuento.ToString("0.00"));
        Console.WriteLine("Total final a pagar: $" + totalFinal.ToString("0.00"));
        Console.WriteLine("Fecha y hora: " + fechaHora.ToString("dd/MM/yyyy HH:mm:ss"));

        // Crear reporte para guardar en archivo
        string reporte =
            "----------------------------------------\n" +
            "REPORTE DE VENTA DE BOLETOS\n" +
            "Fecha y hora: " + fechaHora.ToString("dd/MM/yyyy HH:mm:ss") + "\n" +
            "Nombre del comprador: " + nombre + "\n" +
            "Categoría: " + nombreCategoria + "\n" +
            "Cantidad de boletos: " + boletos + "\n" +
            "Precio unitario: $" + precioUnitario.ToString("0.00") + "\n" +
            "Subtotal: $" + subtotal.ToString("0.00") + "\n" +
            "Descuento: $" + descuento.ToString("0.00") + "\n" +
            "Total final a pagar: $" + totalFinal.ToString("0.00") + "\n" +
            "----------------------------------------\n\n";

        // Guardar el reporte en el archivo
        File.AppendAllText("reporte_boletos.txt", reporte);

        Console.WriteLine("\nEl reporte fue guardado en reporte_boletos.txt");
    }
}
