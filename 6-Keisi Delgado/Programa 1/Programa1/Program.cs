using System;
using System.IO;
//autor: Keisi Delgado
namespace Programa1
{
    class Programa_FacturaElectrica
    {
        static void Main(String[] args)
        {
            //Creamos e inicializamos las variables
            String nombre;
            double consumo;
            int tipoCliente;
            double tarifa = 0;
            string tipo = "";

            //Pedimos los datos al usuario 
            Console.Write("Ingrese su nombre, porfavor: ");
            nombre = Console.ReadLine();

            //Consumo
            Console.Write("Ingrese la cantidad de kwh consumido: ");
            if (double.TryParse(Console.ReadLine(), out consumo))
            {
                if (consumo <= 0)
                {
                    Console.WriteLine("El consumo no debe ser igual o menor a 0");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Debe ingresar un número válido");
                return;
            }

            //Opciones a seleccionar
            Console.WriteLine("\nSeleccione una opción");
            Console.WriteLine("1. Residencial");
            Console.WriteLine("2. Comercial");
            Console.WriteLine("3. Industrial");
            Console.Write("\ntipoCliente: ");

            //validación de las opciones
            if (int.TryParse(Console.ReadLine(), out tipoCliente))
            {
                if (tipoCliente < 1 || tipoCliente > 3)
                {
                    Console.WriteLine("El tipo de cliente seleccionado no es válido");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Debe ingresar un número válido");
                return;
            }

            //Aplicamos la tarifa
            switch (tipoCliente)
            {
                case 1:
                    tarifa = 0.15;
                    tipo = "Residencial";
                    break;
                case 2:
                    tarifa = 0.22;
                    tipo = "Comercial";
                    break;
                case 3:
                    tarifa = 0.30;
                    tipo = "Industrial";
                    break;
                default:
                    Console.WriteLine("Tipo de cliente no válido");
                    return;
            }

            //Cálculos
            double subtotal = consumo * tarifa;
            double recargo = subtotal * 0.07;
            double total = subtotal + recargo;

            //Mostramos resultados
            Console.WriteLine("\nResultados: ");
            Console.WriteLine("Cliente:" + nombre);
            Console.WriteLine("El tipo de cliente seleccionado es:" + tipo);
            Console.WriteLine("El consumo ingresado es de:" + consumo + "kwh");
            Console.WriteLine("El subtotal es de: $" + subtotal.ToString("F2"));
            Console.WriteLine("El total a pagar con recargo es de: $" + total.ToString("F2"));

            //Guardamos la respuesta en un txt
            DateTime fechahora = DateTime.Now;

            string factura =
                "\n======== Factura eléctrica ========\n" +
                "Nombre del cliente: " + nombre + "\n" +
                "Consumo: " + consumo + " kWh\n" +
                "Tipo de cliente: " + tipo + "\n" +
                "Tarifa: $" + tarifa.ToString("F2") + " por kWh\n" +
                "Subtotal: $" + subtotal.ToString("F2") + "\n" +
                "Recargo (7%): $" + recargo.ToString("F2") + "\n" +
                "Total a pagar: $" + total.ToString("F2") + "\n" +
                "Fecha y hora: " + fechahora.ToString("dd/MM/yyyy HH:mm:ss") + "\n" +
                "===================================";

            File.WriteAllText("factura_electrica.txt", factura);

            Console.WriteLine("\nLa factura fue guardada correctamente en: factura_electrica.txt");
        }
    }
}