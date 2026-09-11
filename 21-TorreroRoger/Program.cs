using System;
namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaración de variables
            string nombrecliente;
            int consumo;
            int TipoCliente;

            // Solicita el nombre el cliente
            Console.Write("Ingrese el nombre del cliente: ");
            nombrecliente = Console.ReadLine();
            // Solicita el consumo
            Console.Write("Ingrese la cantidad de kilovatios consumidos: ");
            consumo = int.Parse(Console.ReadLine());

            //Tipo de cliente
            Console.WriteLine("Tipo de cliente");
            Console.WriteLine("1= Residencial");
            Console.WriteLine("2= Comercial");
            Console.WriteLine("3= Industrial");

            Console.Write("Ingrese el tipo de cliente: ");
            TipoCliente = Convert.ToInt32(Console.ReadLine());

            if (consumo <= 0)
            {
                Console.WriteLine("El consumo no puede ser menor a 0");
                return;
            }
            else
            {
                double tarifa = 0;
                string TipoTexto = "";

                switch (TipoCliente)
                {
                    case 1:
                        tarifa = 0.15;
                        TipoTexto = "Residencial";
                        break;

                    case 2:
                        tarifa = 0.22;
                        TipoTexto = "Comercial";
                        break;

                    case 3:
                        tarifa = 0.30;
                        TipoTexto = "Industrial";
                        break;


                    default:
                        Console.Write("Opcion invalida");

                        return;
                }

                double subtotal = consumo * tarifa;
                double recargo = subtotal * 0.07;
                double total = subtotal + recargo;

                DateTime fechahora = DateTime.Now;

                string reporte =
                "Factura Electrica \n" +
                "Nombre del cliente: " + nombrecliente + "\n" +
                "Consumo: " + consumo.ToString("F2") + " kW/h" + "\n" +
                "Tipo de cliente: " + TipoTexto + "\n" +
                "Tarifa: $" + tarifa.ToString("F2") + " " + "por kW/h \n" +
                "Subtotal: $ " + subtotal.ToString("F2") + "\n" +
                "Recargo de 7%: $" + recargo.ToString("F2") + "\n" +
                "Total: $" + total.ToString("F2") + "\n" +
                "Fecha y hora: " + fechahora.ToString("dd/mm/yy HH:mm:ss") + "\n";

                File.WriteAllText("factura_electrica.txt", reporte);

                Console.WriteLine("El reporte se guardó correctamente.");

                System.Diagnostics.Process.Start("notepad.exe", "factura_electrica.txt");

            }

        }
    }
}

