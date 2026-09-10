using System;
using System.IO;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaración de variables
            string nombreComprador;
            int cantidadBoletos;
            int Categoria;

            // Solicita el nombre del comprador
            Console.Write("Ingrese el nombre del comprador: ");
            nombreComprador = Console.ReadLine();

            // Solicita la cantidad de boletos
            Console.Write("Ingrese la cantidad de boletos: ");
            cantidadBoletos = int.Parse(Console.ReadLine());

            // Categoría
            Console.WriteLine("Categoria");
            Console.WriteLine("1= General");
            Console.WriteLine("2= Preferencial");
            Console.WriteLine("3= VIP");

            Console.Write("Ingrese la categoria seleccionada: ");
            Categoria = Convert.ToInt32(Console.ReadLine());

            // Validación de la cantidad de boletos
            if (cantidadBoletos < 1 || cantidadBoletos > 10)
            {
                Console.WriteLine("La cantidad de boletos debe estar entre 1 y 10");
                return;
            }
            else
            {
                double precioUnitario = 0;
                string CategoriaTexto = "";

                // Determina el precio según la categoría
                switch (Categoria)
                {
                    case 1:
                        precioUnitario = 15.00;
                        CategoriaTexto = "General";
                        break;

                    case 2:
                        precioUnitario = 30.00;
                        CategoriaTexto = "Preferencial";
                        break;

                    case 3:
                        precioUnitario = 50.00;
                        CategoriaTexto = "VIP";
                        break;

                    default:
                        Console.WriteLine("Opcion invalida");
                        return;
                }

                // Operación 1: calcular subtotal
                double subtotal = cantidadBoletos * precioUnitario;

                // Operación 2: calcular descuento
                double descuento = 0;

                if (cantidadBoletos >= 5)
                {
                    descuento = subtotal * 0.12;
                }

                // Total final
                double totalFinal = subtotal - descuento;

                // Fecha y hora
                DateTime fechahora = DateTime.Now;

                // Crear reporte
                string reporte =
                "Reporte de Venta de Boletos \n" +
                "Nombre del comprador: " + nombreComprador + "\n" +
                "Categoria: " + CategoriaTexto + "\n" +
                "Cantidad de boletos: " + cantidadBoletos + "\n" +
                "Precio unitario: $" + precioUnitario.ToString("F2") + "\n" +
                "Subtotal: $" + subtotal.ToString("F2") + "\n" +
                "Descuento: $" + descuento.ToString("F2") + "\n" +
                "Total final a pagar: $" + totalFinal.ToString("F2") + "\n" +
                "Fecha y hora: " + fechahora.ToString("dd/MM/yy HH:mm:ss") + "\n";

                // Guardar reporte
                File.WriteAllText("reporte_boletos.txt", reporte);

                // Mostrar las dos salidas solicitadas
                Console.WriteLine("Subtotal: $" + subtotal.ToString("F2"));
                Console.WriteLine("Total final a pagar: $" + totalFinal.ToString("F2"));

                Console.WriteLine("El reporte se guardo correctamente.");

                // Abrir automáticamente el archivo
                System.Diagnostics.Process.Start("notepad.exe", "reporte_boletos.txt");

            }
        }
    }
}