using System;

class Mayorde4NúmerosSWITCH
{
    static void Main(string[] args)
    {
        double numero1;
        double numero2;
        double numero3;
        double numero4;

        Console.Write("Ingrese el número 1: ");
        numero1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el número 2: ");
        numero2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el número 3: ");
        numero3 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el número 4: ");
        numero4 = Convert.ToDouble(Console.ReadLine());

        switch (numero1, numero2, numero3, numero4)
        {
            case (var n1, var n2, var n3, var n4)
                when n1 > n2 && n1 > n3 && n1 > n4:

                Console.WriteLine("\nEl número mayor es: " + numero1);
                Console.WriteLine("El número mayor corresponde al número 1 ingresado.");
                break;


            case (var n1, var n2, var n3, var n4)
                when n2 > n1 && n2 > n3 && n2 > n4:

                Console.WriteLine("\nEl número mayor es: " + numero2);
                Console.WriteLine("El número mayor corresponde al número 2 ingresado.");
                break;


            case (var n1, var n2, var n3, var n4)
                when n3 > n1 && n3 > n2 && n3 > n4:

                Console.WriteLine("\nEl número mayor es: " + numero3);
                Console.WriteLine("El número mayor corresponde al número 3 ingresado.");
                break;


            case (var n1, var n2, var n3, var n4)
                when n4 > n1 && n4 > n2 && n4 > n3:

                Console.WriteLine("\nEl número mayor es: " + numero4);
                Console.WriteLine("El número mayor corresponde al número 4 ingresado.");
                break;


            default:
                Console.WriteLine("\nLos números deben ser diferentes.");
                break;
        }
    }
}