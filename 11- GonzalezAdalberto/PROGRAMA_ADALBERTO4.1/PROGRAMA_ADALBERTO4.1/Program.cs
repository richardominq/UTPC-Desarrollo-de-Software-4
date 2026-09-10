namespace PROGRAMA_ADALBERTO4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pedimos los cuatro números
            Console.WriteLine("Ingrese el primer número:");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número:");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer número:");
            int numero3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el cuarto número:");
            int numero4 = Convert.ToInt32(Console.ReadLine());

            // Comparamos el primer número con los otros tres
            if (numero1 > numero2 && numero1 > numero3 && numero1 > numero4)
            {
                Console.WriteLine($"El número mayor es: {numero1}");
            }

            // Comparamos el segundo número con los otros tres
            if (numero2 > numero1 && numero2 > numero3 && numero2 > numero4)
            {
                Console.WriteLine($"El número mayor es: {numero2}");
            }

            // Comparamos el tercer número con los otros tres
            if (numero3 > numero1 && numero3 > numero2 && numero3 > numero4)
            {
                Console.WriteLine($"El número mayor es: {numero3}");
            }

            // Comparamos el cuarto número con los otros tres
            if (numero4 > numero1 && numero4 > numero2 && numero4 > numero3)
            {
                Console.WriteLine($"El número mayor es: {numero4}");
            }

            // Evita que la consola se cierre
            Console.WriteLine("\nPresiona ENTER para salir...");
            Console.ReadLine();
        }
    }
}
