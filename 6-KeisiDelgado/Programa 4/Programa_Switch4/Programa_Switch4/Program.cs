// Nombre: Keisi Delgado
namespace Programa_Numeros
{
    class Program_Switch4
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
            switch (numero1 == numero2 || numero1 == numero3 || numero1 == numero4 ||
                    numero2 == numero3 || numero2 == numero4 || numero3 == numero4)
            {
                case true:
                    Console.WriteLine("Los números deben ser diferentes.");
                    break;

                case false:
                    // Usamos switch para encontrar el número mayor
                    switch (numero1 > numero2 && numero1 > numero3 && numero1 > numero4)
                    {
                        case true:
                            Console.WriteLine($"\nEl número mayor es: {numero1}");
                            Console.WriteLine("El número mayor corresponde al número 1 ingresado.");
                            break;

                        case false:
                            switch (numero2 > numero1 && numero2 > numero3 && numero2 > numero4)
                            {
                                case true:
                                    Console.WriteLine($"\nEl número mayor es: {numero2}");
                                    Console.WriteLine("El número mayor corresponde al número 2 ingresado.");
                                    break;

                                case false:
                                    switch (numero3 > numero1 && numero3 > numero2 && numero3 > numero4)
                                    {
                                        case true:
                                            Console.WriteLine($"\nEl número mayor es: {numero3}");
                                            Console.WriteLine("El número mayor corresponde al número 3 ingresado.");
                                            break;

                                        case false:
                                            Console.WriteLine($"\nEl número mayor es: {numero4}");
                                            Console.WriteLine("El número mayor corresponde al número 4 ingresado.");
                                            break;
                                    }
                                    break;
                            }
                            break;
                    }
                    break;
            }

            Console.WriteLine("\nPresione cualquier tecla para salir");
            Console.ReadKey();
        }
    }
}