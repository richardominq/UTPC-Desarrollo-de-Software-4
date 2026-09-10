namespace PROGRAMAS_ADALBERTO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pedimos el monto de la compra
            Console.WriteLine("Ingresa el monto de la compra:");

            double amount = Convert.ToDouble(Console.ReadLine());

            // Validamos que el monto sea mayor que 0
            if (amount <= 0)
            {
                Console.WriteLine("Error: el monto debe ser mayor que 0.");
            }
            else
            {
                // Pedimos el tipo de cliente
                Console.WriteLine("Ingrese el tipo de cliente:");
                Console.WriteLine("1 - Cliente normal");
                Console.WriteLine("2 - Cliente frecuente");
                Console.WriteLine("3 - Cliente VIP");

                // Guardamos lo que escribe el usuario como texto
                string clienttype = Console.ReadLine();

                // Cliente tipo 1
                if (clienttype == "1")
                {
                    // El cliente normal no tiene descuento
                    Console.WriteLine($"El monto de la compra es: {amount:F2}");
                }

                // Cliente tipo 2
                else if (clienttype == "2")
                {
                    // Si compra más de 100, obtiene 15% de descuento
                    if (amount > 100)
                    {
                        double montoDescuento = amount * 0.15;
                        double montoFinal = amount - montoDescuento;

                        Console.WriteLine($"Monto de la compra: {amount:F2}");
                        Console.WriteLine($"Descuento: {montoDescuento:F2}");
                        Console.WriteLine($"Total a pagar: {montoFinal:F2}");
                    }
                    else
                    {
                        Console.WriteLine($"Monto de la compra: {amount:F2}");
                        Console.WriteLine("No aplica descuento.");
                    }
                }

                // Cliente tipo 3
                else if (clienttype == "3")
                {
                    // Si compra más de 100, obtiene 15% de descuento
                    if (amount > 100)
                    {
                        double montoDescuento = amount * 0.15;
                        double montoFinal = amount - montoDescuento;

                        Console.WriteLine($"Monto de la compra: {amount:F2}");
                        Console.WriteLine($"Descuento: {montoDescuento:F2}");
                        Console.WriteLine($"Total a pagar: {montoFinal:F2}");
                    }
                    else
                    {
                        Console.WriteLine($"Monto de la compra: {amount:F2}");
                        Console.WriteLine("No aplica descuento.");
                    }
                }

                // Si escribe cualquier otra cosa
                else
                {
                    Console.WriteLine("Error: debes ingresar solamente 1, 2 o 3.");
                }
            }

            // Evita que la consola se cierre inmediatamente
            Console.WriteLine("\nPresiona ENTER para salir...");
            Console.ReadLine();
        }
    }
}
