// Programa 4: Mayor de cuatro números
// Identificar el número mayor de un grupo de cuatro números distintos, utilizando lógica explícita.

using System;

namespace MaxOfFourIf
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

            // Compare the first number against all others to check if it is the greatest.
            if (number1 > number2 && number1 > number3 && number1 > number4)
            {
                Console.WriteLine($"El número mayor es: {number1}");
                Console.WriteLine("El número mayor corresponde al número 1 ingresado.");
            }
            // Compare the second number against all others to check if it is the greatest.
            else if (number2 > number1 && number2 > number3 && number2 > number4)
            {
                Console.WriteLine($"El número mayor es: {number2}");
                Console.WriteLine("El número mayor corresponde al número 2 ingresado.");
            }
            // Compare the third number against all others to check if it is the greatest.
            else if (number3 > number1 && number3 > number2 && number3 > number4)
            {
                Console.WriteLine($"El número mayor es: {number3}");
                Console.WriteLine("El número mayor corresponde al número 3 ingresado.");
            }
            // If none of the above are the greatest, the fourth number must be the greatest.
            else if (number4 > number1 && number4 > number2 && number4 > number3)
            {
                Console.WriteLine($"El número mayor es: {number4}");
                Console.WriteLine("El número mayor corresponde al número 4 ingresado.");
            }
            else 
            {
                // Handle edge cases in case the user violates the 'different numbers' rule.
                Console.WriteLine("No se pudo determinar un único número mayor.");
            }
        }
    }
}
