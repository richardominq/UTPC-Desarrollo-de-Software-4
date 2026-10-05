namespace PROGRAMA_ADALBERTO3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pedimos la edad de la persona
            Console.WriteLine("Ingrese la edad:");
            int edad = Convert.ToInt32(Console.ReadLine());

            // Pedimos la cantidad de boletos disponibles
            Console.WriteLine("Ingrese la cantidad de boletos disponibles:");
            int boletos = Convert.ToInt32(Console.ReadLine());

            // Pedimos el tipo de entrada
            Console.WriteLine("Ingrese el tipo de entrada:");
            Console.WriteLine("(1) General");
            Console.WriteLine("(2) VIP");
            Console.WriteLine("(3) Invitado");
            int tipoentrada = Convert.ToInt32(Console.ReadLine());

            // Verificamos las condiciones para entrar
            switch (edad >= 18 && boletos >= 1)
            {
                case true:

                    // Verificamos el tipo de entrada
                    switch (tipoentrada)
                    {
                        case 1:
                            Console.WriteLine("Entrada autorizada.");
                            Console.WriteLine("Tipo de entrada: General");
                            break;

                        case 2:
                            Console.WriteLine("Entrada autorizada.");
                            Console.WriteLine("Tipo de entrada: VIP");
                            break;

                        case 3:
                            Console.WriteLine("Entrada autorizada.");
                            Console.WriteLine("Tipo de entrada: Invitado");
                            break;

                        default:
                            Console.WriteLine("Entrada rechazada.");
                            Console.WriteLine("El tipo de entrada no es válido.");
                            break;
                    }

                    break;

                case false:
                    // No cumple con la edad o no tiene boletos
                    Console.WriteLine("Entrada rechazada.");
                    Console.WriteLine("No cumple con las condiciones establecidas.");
                    break;
            }

            // Evita que la consola se cierre
            Console.WriteLine("\nPresiona ENTER para salir...");
            Console.ReadLine();
        }
    }
}
