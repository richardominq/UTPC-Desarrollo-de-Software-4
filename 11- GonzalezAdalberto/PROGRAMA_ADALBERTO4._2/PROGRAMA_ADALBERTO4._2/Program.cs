namespace PROGRAMA_ADALBERTO4._2
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

            // Variable para guardar cuál número es el mayor
            int mayor = 0;

            // Comparamos los números y asignamos una posición
            if (numero1 > numero2 && numero1 > numero3 && numero1 > numero4)
            {
                mayor = 1;
            }
            else if (numero2 > numero1 && numero2 > numero3 && numero2 > numero4)
            {
                mayor = 2;
            }
            else if (numero3 > numero1 && numero3 > numero2 && numero3 > numero4)
            {
                mayor = 3;
            }
            else
            {
                mayor = 4;
            }

            // Utilizamos SWITCH para mostrar cuál es el número mayor
            switch (mayor)
            {
                case 1:
                    Console.WriteLine($"El número mayor es: {numero1}");
                    break;

                case 2:
                    Console.WriteLine($"El número mayor es: {numero2}");
                    break;

                case 3:
                    Console.WriteLine($"El número mayor es: {numero3}");
                    break;

                case 4:
                    Console.WriteLine($"El número mayor es: {numero4}");
                    break;
            }

            // Evita que la consola se cierre
            Console.WriteLine("\nPresiona ENTER para salir...");
            Console.ReadLine();
        }
    }
}
