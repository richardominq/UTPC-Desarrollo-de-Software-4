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

        switch (tipoEntrada)
        {
            case 1:
                if (edad >= 18 && boletos >= 1)
                {
                    Console.WriteLine("Entrada autorizada");
                    Console.WriteLine("Tipo de entrada: General");
                }
                else
                {
                    Console.WriteLine("Entrada rechazada");
                    Console.WriteLine("No cumple con las condiciones establecidas.");
                }
                break;

            case 2:
                if (edad >= 18 && boletos >= 1)
                {
                    Console.WriteLine("Entrada autorizada");
                    Console.WriteLine("Tipo de entrada: VIP");
                }
                else
                {
                    Console.WriteLine("Entrada rechazada");
                    Console.WriteLine("No cumple con las condiciones establecidas.");
                }
                break;

            case 3:
                if (edad >= 18 && boletos >= 1)
                {
                    Console.WriteLine("Entrada autorizada");
                    Console.WriteLine("Tipo de entrada: Invitado");
                }
                else
                {
                    Console.WriteLine("Entrada rechazada");
                    Console.WriteLine("No cumple con las condiciones establecidas.");
                }
                break;

            default:
                Console.WriteLine("Entrada rechazada");
                Console.WriteLine("Tipo de entrada no válido.");
                break;
        }
    }
}