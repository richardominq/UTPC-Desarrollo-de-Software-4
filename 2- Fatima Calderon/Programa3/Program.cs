using System;
namespace Basics
{

    class Program
    {
        static void Main()
        {
            // Solicitar datos al usuario
            Console.Write("Ingrese el nombre del comprador: ");
            string nombre = Console.ReadLine();
            // Solicitar cantidad de boletos
            Console.Write("Ingrese la cantidad de boletos: ");
            int boletos = Convert.ToInt32(Console.ReadLine());
            // Solicitar categoría
            Console.WriteLine("Categoría:");
            Console.WriteLine("1 = General");
            Console.WriteLine("2 = Preferencial");
            Console.WriteLine("3 = VIP");
            Console.Write("Seleccione la categoría: ");
            int categoria = Convert.ToInt32(Console.ReadLine());

            // Validar cantidad de boletos
            if (boletos < 1 || boletos > 10)
            {
                Console.WriteLine("La cantidad de boletos debe estar entre 1 y 10.");
                return;
            }
            else
            {
                double precio = 0;
                string categoriaTexto = "";

                // Determinar precio según la categoría
                switch (categoria)
                {
                    case 1:
                        precio = 15.00;
                        categoriaTexto = "General";
                        break;

                    case 2:
                        precio = 30.00;
                        categoriaTexto = "Preferencial";
                        break;

                    case 3:
                        precio = 50.00;
                        categoriaTexto = "VIP";
                        break;

                    default:
                        Console.WriteLine("Categoría no válida.");
                        return;
                }

                // Calcular subtotal
                double subtotal = boletos * precio;

                // Calcular descuento
                double descuento = 0;
                double total = subtotal;

                if (boletos >= 5)
                {
                    descuento = subtotal * 0.12;
                    total = subtotal - descuento;
                }

                // Fecha y hora
                DateTime fechaHora = DateTime.Now;

                // Crear reporte
                string reporte =
                    "===== REPORTE DE BOLETOS =====\n" +
                    "Nombre del comprador: " + nombre + "\n" +
                    "Categoría: " + categoriaTexto + "\n" +
                    "Cantidad de boletos: " + boletos + "\n" +
                    "Precio unitario: $" + precio.ToString("F2") + "\n" +
                    "Subtotal: $" + subtotal.ToString("F2") + "\n" +
                    "Descuento (12%): $" + descuento.ToString("F2") + "\n" +
                    "Total final a pagar: $" + total.ToString("F2") + "\n" +
                    "Fecha y hora: " + fechaHora.ToString("dd/MM/yyyy HH:mm:ss");

                // Guardar archivo
                File.WriteAllText("reporte_boletos.txt", reporte);

                Console.WriteLine("\nEl reporte se guardó correctamente.");

                System.Diagnostics.Process.Start("notepad.exe", "reporte_boletos.txt");
            }
        }
    }
}
