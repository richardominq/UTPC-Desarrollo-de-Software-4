namespace PROGRAMAS_ADALBERTO2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario que ingrese el monto de la compra
            Console.WriteLine("Ingresa el monto de la compra:");

            double amount;

            // Validamos que el monto sea un número válido
            if (!double.TryParse(Console.ReadLine(), out amount))
            {
                Console.WriteLine("Error: debes ingresar un número válido.");
            }
            else
            {
                // Validamos que el monto sea mayor que 0
                if (amount <= 0)
                {
                    Console.WriteLine("Error: el monto debe ser mayor que 0.");
                }
                else
                {
                    // Solicitar al usuario que ingrese el tipo de cliente
                    Console.WriteLine("Ingrese el tipo de cliente:");
                    Console.WriteLine("1 - Cliente normal");
                    Console.WriteLine("2 - Cliente frecuente");
                    Console.WriteLine("3 - Cliente VIP");

                    int clienttype;

                    // Validamos que el tipo de cliente sea un número
                    if (!int.TryParse(Console.ReadLine(), out clienttype))
                    {
                        Console.WriteLine("Error: debes ingresar un número.");
                    }
                    else
                    {
                        // Aplicar el descuento según el tipo de cliente
                        switch (clienttype)
                        {
                            case 1:
                                // No se aplica ningún descuento
                                Console.WriteLine($"El monto de la compra es: {amount:F2}");
                                break;

                            case 2:
                                // Aplicar un descuento del 15% si el monto es mayor a 100
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
                                    // No hay descuento porque la compra no supera los 100
                                    Console.WriteLine($"El monto de la compra es: {amount:F2}");
                                    Console.WriteLine("No aplica descuento.");
                                }
                                break;

                            case 3:
                                // Aplicar un descuento del 15% si el monto es mayor a 100
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
                                    // No hay descuento porque la compra no supera los 100
                                    Console.WriteLine($"El monto de la compra es: {amount:F2}");
                                    Console.WriteLine("No aplica descuento.");
                                }
                                break;

                            default:
                                // Si el usuario ingresa un tipo de cliente diferente
                                Console.WriteLine("Tipo de cliente no válido.");
                                break;
                        }
                    }
                }
            }

            // Evita que la consola se cierre inmediatamente
            Console.WriteLine("\nPresiona ENTER para salir...");
            Console.ReadLine();
        }
    }
}
