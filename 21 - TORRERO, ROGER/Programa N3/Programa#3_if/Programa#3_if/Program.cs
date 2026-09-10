using System;

class Program
{
    static void Main()
    {
        int edad, boletos, tipoEntrada;

        Console.Write("Ingrese la edad: ");
        edad = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese la cantidad de boletos disponibles: ");
        boletos = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Tipo de entrada:");
        Console.WriteLine("1. General");
        Console.WriteLine("2. VIP");
        Console.WriteLine("3. Invitado");
        Console.Write("Seleccione una opción: ");
        tipoEntrada = Convert.ToInt32(Console.ReadLine());

        if (edad >= 18 && boletos >= 1 &&
            (tipoEntrada == 1 || tipoEntrada == 2 || tipoEntrada == 3))
        {
            Console.WriteLine("Entrada autorizada");

            if (tipoEntrada == 1)
            {
                Console.WriteLine("Tipo de entrada: General");
            }

            if (tipoEntrada == 2)
            {
                Console.WriteLine("Tipo de entrada: VIP");
            }

            if (tipoEntrada == 3)
            {
                Console.WriteLine("Tipo de entrada: Invitado");
            }
        }
        else
        {
            Console.WriteLine("Entrada rechazada");
            Console.WriteLine("No cumple con las condiciones establecidas.");
        }
    }
}