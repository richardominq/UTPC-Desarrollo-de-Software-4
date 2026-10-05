// Nombre: Keisi Delgado
namespace Programa_Estacionamiento
{
    class Program6
    {
        static void Main(string[] args)
        {
            // Pedimos los datos al usuario
            Console.Write("Ingrese la cantidad de horas estacionadas: ");
            int horas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el tipo de vehículo (1 = Moto, 2 = Automóvil, 3 = Camioneta): ");
            int tipoVehiculo = Convert.ToInt32(Console.ReadLine());

            double tarifa = 0;
            string vehiculo = "";

            // Usamos switch para asignar la tarifa
            switch (tipoVehiculo)
            {
                case 1:
                    tarifa = 1;
                    vehiculo = "Moto";
                    break;

                case 2:
                    tarifa = 2;
                    vehiculo = "Automóvil";
                    break;

                case 3:
                    tarifa = 3;
                    vehiculo = "Camioneta";
                    break;
            }

            // Calculamos el total a pagar
            double total = horas * tarifa;

            // Mostramos el proceso y el resultado
            Console.WriteLine($"\nLas horas estacionadas son: {horas}");
            Console.WriteLine($"El tipo de vehículo ingresado es: {vehiculo}");
            Console.WriteLine($"La tarifa por hora es: ${tarifa}");
            Console.WriteLine($"Se realizó el siguiente cálculo: {horas} × ${tarifa} = ${total}");
            Console.WriteLine($"El total a pagar es: ${total}");

            Console.WriteLine("\nPresione cualquier tecla para salir");
            Console.ReadKey();
        }
    }
}