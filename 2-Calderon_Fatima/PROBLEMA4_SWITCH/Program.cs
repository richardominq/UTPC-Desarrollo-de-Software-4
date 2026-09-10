using System;
namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaración de variables
            double numero1;
            double numero2;
            double numero3;
            double numero4;

            // Solicitar los cuatro números
            Console.Write("Ingrese el número 1: ");
            numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el número 2: ");
            numero2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el número 3: ");
            numero3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el número 4: ");
            numero4 = Convert.ToDouble(Console.ReadLine());

            // Determinar cuál número es el mayor
            switch (numero1, numero2, numero3, numero4)
            {
                case (double n1, double n2, double n3, double n4)
                    when n1 > n2 && n1 > n3 && n1 > n4:

                    Console.WriteLine("El número mayor es: " + numero1);
                    Console.WriteLine("El número mayor corresponde al número 1 ingresado.");
                    break;

                case (double n1, double n2, double n3, double n4)
                    when n2 > n1 && n2 > n3 && n2 > n4:

                    Console.WriteLine("El número mayor es: " + numero2);
                    Console.WriteLine("El número mayor corresponde al número 2 ingresado.");
                    break;

                case (double n1, double n2, double n3, double n4)
                    when n3 > n1 && n3 > n2 && n3 > n4:

                    Console.WriteLine("El número mayor es: " + numero3);
                    Console.WriteLine("El número mayor corresponde al número 3 ingresado.");
                    break;

                case (double n1, double n2, double n3, double n4)
                    when n4 > n1 && n4 > n2 && n4 > n3:

                    Console.WriteLine("El número mayor es: " + numero4);
                    Console.WriteLine("El número mayor corresponde al número 4 ingresado.");
                    break;
            }
        }
    }
}