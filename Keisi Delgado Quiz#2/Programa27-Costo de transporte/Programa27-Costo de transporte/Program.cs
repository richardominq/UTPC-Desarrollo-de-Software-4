// Nombre: Keisi Delgado
namespace Programa_Transporte
{
    class Program_SwitchExpression27
    {
        static void Main(string[] args)
        {
            // Pedimos los datos al usuario
            Console.Write("Ingrese la distancia en kilómetros: ");
            double distancia = Convert.ToDouble(
                Console.ReadLine().Replace(",", "."),
                System.Globalization.CultureInfo.InvariantCulture);

            Console.Write("Ingrese el tipo de transporte (1 = Taxi, 2 = Bus, 3 = Transporte privado): ");
            int tipoTransporte = Convert.ToInt32(Console.ReadLine());

            // Usamos switch expression para determinar el transporte y costo
            string transporte = tipoTransporte switch
            {
                1 => "Taxi",
                2 => "Bus",
                3 => "Transporte privado",
                _ => "Tipo de transporte no válido"
            };

            double costoPorKm = tipoTransporte switch
            {
                1 => 2.00,
                2 => 0.50,
                3 => 1.50,
                _ => 0
            };

            // Calculamos el costo total
            double costoTotal = distancia * costoPorKm;

            // Mostramos las salidas
            Console.WriteLine($"\nEl tipo de transporte es: {transporte}");

            switch (tipoTransporte)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine($"La distancia ingresada es: {distancia} km");
                    Console.WriteLine($"El costo por kilómetro es: ${costoPorKm}");
                    Console.WriteLine($"Se realizó el siguiente cálculo: {distancia} × ${costoPorKm} = ${costoTotal}");
                    Console.WriteLine($"El costo total del recorrido es: ${costoTotal}");
                    break;

                default:
                    Console.WriteLine("Debe seleccionar una opción entre 1 y 3.");
                    break;
            }

            Console.WriteLine("\nPresione cualquier tecla para salir");
            Console.ReadKey();
        }
    }
}

