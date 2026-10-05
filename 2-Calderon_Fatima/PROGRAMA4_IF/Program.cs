using System;
namespace Basics
{
    class Program
    {
        static void Main()
        {
            // Declaración de variables
            double numero1;
            double numero2;
            double numero3;
            double numero4;
            double numeroMayor = 0;

            // Solicitar el primer número
            Console.Write("Ingrese el primer número: ");
            numero1 = double.Parse(Console.ReadLine());

            // Solicitar el segundo número
            Console.Write("Ingrese el segundo número: ");
            numero2 = double.Parse(Console.ReadLine());

            // Solicitar el tercer número
            Console.Write("Ingrese el tercer número: ");
            numero3 = double.Parse(Console.ReadLine());

            // Solicitar el cuarto número
            Console.Write("Ingrese el cuarto número: ");
            numero4 = double.Parse(Console.ReadLine());

            // Verificar si el primer número es mayor que los otros tres
            if (numero1 > numero2 & numero1 > numero3 & numero1 > numero4)
            {
                // Guardar el primer número como número mayor
                numeroMayor = numero1;
            }

            // Verificar si el segundo número es mayor que los otros tres
            if (numero2 > numero1 & numero2 > numero3 & numero2 > numero4)
            {
                // Guardar el segundo número como número mayor
                numeroMayor = numero2;
            }

            // Verificar si el tercer número es mayor que los otros tres
            if (numero3 > numero1 & numero3 > numero2 & numero3 > numero4)
            {
                // Guardar el tercer número como número mayor
                numeroMayor = numero3;
            }

            // Verificar si el cuarto número es mayor que los otros tres
            if (numero4 > numero1 & numero4 > numero2 & numero4 > numero3)
            {
                // Guardar el cuarto número como número mayor
                numeroMayor = numero4;
            }

            // Mostrar el resultado
            Console.WriteLine();
            Console.WriteLine("El número mayor es: " + numeroMayor);
        }
    }
}
