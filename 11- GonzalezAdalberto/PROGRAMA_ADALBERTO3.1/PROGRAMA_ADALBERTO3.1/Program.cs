namespace PROGRAMA_ADALBERTO3._1
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

            // Verificamos si cumple con todas las condiciones
            if (edad >= 18 && boletos >= 1 && tipoentrada >= 1 && tipoentrada <= 3)
            {
                // Si cumple todas las condiciones, se autoriza la entrada
                if (tipoentrada == 1)
                {
                    Console.WriteLine("Entrada autorizada.");
                    Console.WriteLine("Tipo de entrada: General");
                }
                else if (tipoentrada == 2)
                {
                    Console.WriteLine("Entrada autorizada.");
                    Console.WriteLine("Tipo de entrada: VIP");
                }
                else if (tipoentrada == 3)
                {
                    Console.WriteLine("Entrada autorizada.");
                    Console.WriteLine("Tipo de entrada: Invitado");
                }
            }
            else
            {
                // Si no cumple alguna condición, se rechaza la entrada
                Console.WriteLine("Entrada rechazada.");
                Console.WriteLine("No cumple con las condiciones establecidas.");
            }

            // Evita que la consola se cierre
            Console.WriteLine("\nPresiona ENTER para salir...");
            Console.ReadLine();
        }
    }
}
