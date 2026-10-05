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

        int posicionMayor = 0;

        if (num1 > num2 && num1 > num3 && num1 > num4)
        {
            posicionMayor = 1;
        }

        if (num2 > num1 && num2 > num3 && num2 > num4)
        {
            posicionMayor = 2;
        }

        if (num3 > num1 && num3 > num2 && num3 > num4)
        {
            posicionMayor = 3;
        }

        if (num4 > num1 && num4 > num2 && num4 > num3)
        {
            posicionMayor = 4;
        }

        double mayor = posicionMayor switch
        {
            1 => num1,
            2 => num2,
            3 => num3,
            4 => num4,
            _ => 0
        };

        string mensajePosicion = posicionMayor switch
        {
            1 => "El numero mayor corresponde al numero 1 ingresado.",
            2 => "El numero mayor corresponde al numero 2 ingresado.",
            3 => "El numero mayor corresponde al numero 3 ingresado.",
            4 => "El numero mayor corresponde al numero 4 ingresado.",
            _ => "No se pudo determinar la posicion del numero mayor."
        };

        Console.WriteLine("El numero mayor es: " + mayor);
        Console.WriteLine(mensajePosicion);
    }
}
