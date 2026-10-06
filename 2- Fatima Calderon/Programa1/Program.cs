using System;
namespace Basics
{
    class Program
    {
        static void Main()
        {
            // Solicitar datos al usuario
            Console.Write("Ingrese el nombre del cliente: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese la cantidad de kilovatios consumidos: ");
            double consumo = Convert.ToDouble(Console.ReadLine());

            // Solicitar tipo de cliente
            Console.WriteLine("Tipo de cliente:");
            Console.WriteLine("1 = Residencial");
            Console.WriteLine("2 = Comercial");
            Console.WriteLine("3 = Industrial");
            Console.Write("Seleccione el tipo de cliente: ");
            int tipoCliente = Convert.ToInt32(Console.ReadLine());

            // Validar que el consumo sea mayor que cero
            if (consumo <= 0)
            {
                Console.WriteLine("El consumo debe ser mayor que cero.");
                return;
            }
            else
            {
                double tarifa = 0;
                string tipoTexto = "";

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

                // Calcular total a pagar
                double total = subtotal + recargo;

                // Fecha y hora de generación
                DateTime fechaHora = DateTime.Now;

                // Crear contenido del archivo
                string reporte =
                    "===== FACTURA ELÉCTRICA =====\n" +
                    "Nombre del cliente: " + nombre + "\n" +
                    "Consumo: " + consumo.ToString("F2") + " kWh\n" +
                    "Tipo de cliente: " + tipoTexto + "\n" +
                    "Tarifa: $" + tarifa.ToString("F2") + " por kWh\n" +
                    "Subtotal: $" + subtotal.ToString("F2") + "\n" +
                    "Recargo (7%): $" + recargo.ToString("F2") + "\n" +
                    "Total a pagar: $" + total.ToString("F2") + "\n" +
                    "Fecha y hora de generación: " + fechaHora.ToString("dd/MM/yyyy HH:mm:ss") + "\n";

                // Guardar el reporte en un archivo de texto
                File.WriteAllText("factura_electrica.txt", reporte);

                Console.WriteLine("\nEl reporte se guardó correctamente en factura_electrica.txt");

                System.Diagnostics.Process.Start("notepad.exe", "factura_electrica.txt");
            }
        }
    }
}
