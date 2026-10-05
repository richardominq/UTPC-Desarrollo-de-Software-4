using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el primer numero: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo numero: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el tercer numero: ");
        double num3 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el cuarto numero: ");
        double num4 = Convert.ToDouble(Console.ReadLine());

        if (num1 == num2 || num1 == num3 || num1 == num4 || num2 == num3 || num2 == num4 || num3 == num4)
        {
            Console.WriteLine("Los cuatro numeros deben ser diferentes.");
            return;
        }

        double mayor = 0;

        if (num1 > num2 && num1 > num3 && num1 > num4)
        {
            mayor = num1;
        }

        if (num2 > num1 && num2 > num3 && num2 > num4)
        {
            mayor = num2;
        }

        if (num3 > num1 && num3 > num2 && num3 > num4)
        {
            mayor = num3;
        }

        if (num4 > num1 && num4 > num2 && num4 > num3)
        {
            mayor = num4;
        }

        Console.WriteLine("El numero mayor es: " + mayor);
    }
}
