using System;
namespace Basics
{

    class Program
    {
        static void Main()
        {
            // Declaración de variables
            double monto;
            int tipoCliente;
            double descuento = 0;
            double montoFinal;

            // Solicitar el monto de la compra
            Console.Write("Ingrese el monto total de la compra: ");
            monto = double.Parse(Console.ReadLine());

            // Solicitar el tipo de cliente
            Console.WriteLine("1 = Regular");
            Console.WriteLine("2 = Frecuente");
            Console.WriteLine("3 = VIP");
            Console.Write("Ingrese el tipo de cliente: ");
            tipoCliente = int.Parse(Console.ReadLine());

            // Evaluar el tipo de cliente seleccionado
            switch (tipoCliente)
            {
                case 1:

                    // El cliente regular no recibe descuento
                    Console.WriteLine("Compra total: $" + monto);
                    Console.WriteLine("No recibe descuento.");
                    Console.WriteLine("Monto a pagar: $" + monto);

                    break;

                case 2:

                    // Verificar si la compra supera los $100
                    if (monto > 100)
                    {
                        // Calcular el descuento
                        descuento = monto * 0.15;
                    }
                    else
                    {
                        // No se aplica descuento
                        descuento = 0;
                    }

                    // Calcular el monto final
                    montoFinal = monto - descuento;

                    // Mostrar los resultados
                    Console.WriteLine("Compra total: $" + monto);
                    Console.WriteLine("Descuento: $" + descuento);
                    Console.WriteLine("Monto final: $" + montoFinal);

                    break;

                case 3:

                    // Verificar si la compra supera los $100
                    if (monto > 100)
                    {
                        // Calcular el descuento
                        descuento = monto * 0.15;
                    }
                    else
                    {
                        // No se aplica descuento
                        descuento = 0;
                    }

                    // Calcular el monto final
                    montoFinal = monto - descuento;

                    // Mostrar los resultados
                    Console.WriteLine("Compra total: $" + monto);
                    Console.WriteLine("Descuento: $" + descuento);
                    Console.WriteLine("Monto final: $" + montoFinal);

                    break;

                default:

                    // Mostrar mensaje si el tipo de cliente no es válido
                    Console.WriteLine("Tipo de cliente no válido.");

                    break;
            }
        }
    }
}
