using System;

class Program
{
    static void Main()
    {
        double num1, num2, num3, num4;

        Console.Write("Ingrese el primer número: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el tercer número: ");
        num3 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el cuarto número: ");
        num4 = Convert.ToDouble(Console.ReadLine());

        if (num1 > num2 && num1 > num3 && num1 > num4)
        {
            Console.WriteLine("El número mayor es: " + num1);
        }

        if (num2 > num1 && num2 > num3 && num2 > num4)
        {
            Console.WriteLine("El número mayor es: " + num2);
        }

        if (num3 > num1 && num3 > num2 && num3 > num4)
        {
            Console.WriteLine("El número mayor es: " + num3);
        }

        if (num4 > num1 && num4 > num2 && num4 > num3)
        {
            Console.WriteLine("El número mayor es: " + num4);
        }
    }
}