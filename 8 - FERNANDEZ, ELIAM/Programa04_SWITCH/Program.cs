// Programa 4: Mayor de cuatro números
// Identificar el número mayor de un grupo de cuatro números distintos, utilizando lógica explícita.

using System;

namespace MaxOfFourSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter four distinctly different numbers.
            Console.WriteLine("Ingrese cuatro números diferentes:");
            Console.Write("Número 1: ");
            double number1 = double.Parse(Console.ReadLine());

            Console.Write("Número 2: ");
            double number2 = double.Parse(Console.ReadLine());

            Console.Write("Número 3: ");
            double number3 = double.Parse(Console.ReadLine());

            Console.Write("Número 4: ");
            double number4 = double.Parse(Console.ReadLine());

            // Use a switch statement with pattern matching to find the greatest number explicitly.
            switch (number1, number2, number3, number4)
            {
                // Match the specific case where the first number is strictly greater than the rest.
                case _ when number1 > number2 && number1 > number3 && number1 > number4:
                    Console.WriteLine($"El número mayor es: {number1}");
                    Console.WriteLine("El número mayor corresponde al número 1 ingresado.");
                    break;

                // Match the specific case where the second number is strictly greater than the rest.
                case _ when number2 > number1 && number2 > number3 && number2 > number4:
                    Console.WriteLine($"El número mayor es: {number2}");
                    Console.WriteLine("El número mayor corresponde al número 2 ingresado.");
                    break;

                // Match the specific case where the third number is strictly greater than the rest.
                case _ when number3 > number1 && number3 > number2 && number3 > number4:
                    Console.WriteLine($"El número mayor es: {number3}");
                    Console.WriteLine("El número mayor corresponde al número 3 ingresado.");
                    break;

                // Match the specific case where the fourth number is strictly greater than the rest.
                case _ when number4 > number1 && number4 > number2 && number4 > number3:
                    Console.WriteLine($"El número mayor es: {number4}");
                    Console.WriteLine("El número mayor corresponde al número 4 ingresado.");
                    break;

                // Provide a default fallback if none of the pattern matching conditions are successfully met.
                default:
                    Console.WriteLine("No se pudo determinar un único número mayor.");
                    break;
            }
        }
    }
}
