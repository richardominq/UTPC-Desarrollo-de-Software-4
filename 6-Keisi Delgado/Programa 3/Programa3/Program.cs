using System;
using System.IO;

namespace ReporteBoletos
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int cantidad;
            int categoria;
            double precio = 0;
            string tipo = "";

            // Nombre del comprador
            Console.Write("Ingrese el nombre del comprador: ");
            nombre = Console.ReadLine();

            // Cantidad de boletos
            Console.Write("Ingrese la cantidad de boletos: ");

            if (int.TryParse(Console.ReadLine(), out cantidad))
            {
                if (cantidad < 1 || cantidad > 10)
                {
                    Console.WriteLine("La cantidad debe estar entre 1 y 10.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Debe ingresar un número válido.");
                return;
            }

            // Categoría
            Console.Write("Ingrese la categoría (1-General, 2-Preferencial, 3-VIP): ");

            if (int.TryParse(Console.ReadLine(), out categoria))
            {
                if (categoria < 1 || categoria > 3)
                {
                    Console.WriteLine("La categoría no es válida.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Debe ingresar un número.");
                return;
            }

            // Determinar precio
            switch (categoria)
            {
                case 1:
                    precio = 15.00;
                    tipo = "General";
                    break;

                case 2:
                    precio = 30.00;
                    tipo = "Preferencial";
                    break;

                case 3:
                    precio = 50.00;
                    tipo = "VIP";
                    break;

                default:
                    Console.WriteLine("Categoría no válida.");
                    return;
            }

            // Cálculos
            double subtotal = cantidad * precio;
            double descuento = 0;

            if (cantidad >= 5)
            {
                descuento = subtotal * 0.12;
            }

            double total = subtotal - descuento;

            // Mostrar resultados
            Console.WriteLine("\n--- REPORTE DE BOLETOS ---");
            Console.WriteLine("Comprador: " + nombre);
            Console.WriteLine("Categoría: " + tipo);
            Console.WriteLine("Cantidad de boletos: " + cantidad);
            Console.WriteLine("Subtotal: $" + subtotal.ToString("F2"));
            Console.WriteLine("Total final: $" + total.ToString("F2"));

            // Fecha y hora
            DateTime fechaHora = DateTime.Now;

            // Crear reporte
            string reporte =
                "========== REPORTE DE BOLETOS ==========\n" +
                "Nombre del comprador: " + nombre + "\n" +
                "Categoría: " + tipo + "\n" +
                "Cantidad de boletos: " + cantidad + "\n" +
                "Precio unitario: $" + precio.ToString("F2") + "\n" +
                "Subtotal: $" + subtotal.ToString("F2") + "\n" +
                "Descuento (12%): $" + descuento.ToString("F2") + "\n" +
                "Total final: $" + total.ToString("F2") + "\n" +
                "Fecha y hora: " + fechaHora.ToString("dd/MM/yyyy HH:mm:ss") + "\n" +
                "==========================================";

            // Guardar archivo
            File.WriteAllText("reporte_boletos.txt", reporte);

            Console.WriteLine("\nEl reporte fue guardado en reporte_boletos.txt");
        }
    }
}
