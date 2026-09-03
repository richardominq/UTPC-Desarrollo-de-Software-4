/*
 * Nombre: Keisi Delgado
 */
namespace Programa_Numeros
{
    class Program_if4
    {
        static void Main(string[] args)
        {
            // Pedimos los datos al usuario
            Console.Write("Ingrese el primer número, por favor: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el segundo número, por favor: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el tercer número, por favor: ");
            int numero3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el cuarto número, por favor: ");
            int numero4 = Convert.ToInt32(Console.ReadLine());

            // Verificamos que los números sean diferentes
            if (numero1 == numero2 || numero1 == numero3 || numero1 == numero4 ||
                numero2 == numero3 || numero2 == numero4 || numero3 == numero4)
            {
                Console.WriteLine("\nLos números deben ser diferentes.");
            }
            else
            {
                // Usamos la sentencia if para encontrar el número mayor
                if (numero1 > numero2 && numero1 > numero3 && numero1 > numero4)
                {
                    Console.WriteLine($"\nEl número mayor es: {numero1}");
                    Console.WriteLine("El número mayor corresponde al número 1 ingresado.");
                }

                if (numero2 > numero1 && numero2 > numero3 && numero2 > numero4)
                {
                    Console.WriteLine($"\nEl número mayor es: {numero2}");
                    Console.WriteLine("El número mayor corresponde al número 2 ingresado.");
                }

                if (numero3 > numero1 && numero3 > numero2 && numero3 > numero4)
                {
                    Console.WriteLine($"\nEl número mayor es: {numero3}");
                    Console.WriteLine("El número mayor corresponde al número 3 ingresado.");
                }

                if (numero4 > numero1 && numero4 > numero2 && numero4 > numero3)
                {
                    Console.WriteLine($"\nEl número mayor es: {numero4}");
                    Console.WriteLine("El número mayor corresponde al número 4 ingresado.");
                }
            }

            Console.WriteLine("\nPresione cualquier tecla para salir");
            Console.ReadKey();
        }
    }
}
