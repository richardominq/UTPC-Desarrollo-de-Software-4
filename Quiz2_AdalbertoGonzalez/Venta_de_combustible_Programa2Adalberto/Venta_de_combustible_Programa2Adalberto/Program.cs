namespace Venta_de_combustible_Programa2Adalberto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Ingrese la cantidad de litros a comprar:");
            double litros = Convert.ToDouble(Console.ReadLine());
            //valido que la cantidad de liitro sea mayor a 0 si es asi pido el tipo de combustible y calculo el total de la cuenta 
            // si no es asi muestro un mensaje de error
            if (litros > 0)
            {
                // pido al usario que ingrese el tipo de combustible y lo guardo en una variable de tipo int
                Console.WriteLine($"Ingrese el tipo de combustible: \n 1 = Gasolina 91 \n 2 = Gasolina 95 \n 3 = Diésel");
                int tipoCombustible = Convert.ToInt32(Console.ReadLine());

                // creo la variable precio y uso un switch expression para asignar el precio por litro segun el combustible 
                double precio = tipoCombustible switch
                {
                    // Asigna el precio por litro segun el tipo de combustible 
                    1 => 0.91,
                    2 => 0.95,
                    3 => 0.90,
                    _ => 0
                };
                // Calcula el total de la compra 
                double total = litros * precio;
                // Muestra el precio por litro y el total de la compra 
                Console.WriteLine($"Precio por litro: ${precio:F2}");
                Console.WriteLine($"Total de la compra: ${total:F2}");
            }
            else
            {
                Console.WriteLine($"La cantidad de litros debe ser mayor a 0.");
            }
        }
    }
}
