using System;

class Program
{
    static void Main()
    {
        int carrera, semestre, autorizacion;
        double hora;

        Console.Write("Ingrese el código de carrera: ");
        carrera = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el semestre: ");
        semestre = int.Parse(Console.ReadLine());

        Console.Write("Ingrese la hora de entrada: ");
        hora = double.Parse(Console.ReadLine());

        Console.Write("¿Posee autorización? (1 = Sí, 2 = No): ");
        autorizacion = int.Parse(Console.ReadLine());

        if (((carrera == 1 || carrera == 2 || carrera == 3) && semestre >= 3)
            || autorizacion == 1)
        {
            Console.WriteLine("Acceso permitido");
        }
        else
        {
            Console.WriteLine("Acceso denegado");
        }
    }
}