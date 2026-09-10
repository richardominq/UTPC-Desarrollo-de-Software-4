using System;

class Program
{
    static void Main(string[] args)
    {
        int edad;
        int boletos;
        int tipoEntrada;
        string tipo = "";

        Console.Write("Ingrese la edad: ");
        edad = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese la cantidad de boletos disponibles: ");
        boletos = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nTipo de entrada:");
        Console.WriteLine("1 = General");
        Console.WriteLine("2 = VIP");
        Console.WriteLine("3 = Invitado");

        Console.Write("Seleccione una opción: ");
        tipoEntrada = Convert.ToInt32(Console.ReadLine());

        // Identificar el tipo utilizando IF
        if (tipoEntrada == 1)
        {
            tipo = "General";
        }
        else if (tipoEntrada == 2)
        {
            tipo = "VIP";
        }
        else if (tipoEntrada == 3)
        {
            tipo = "Invitado";
        }
        else
        {
            tipo = "Inválido";
        }

        // Validar entrada
        if (edad >= 18 &&
            boletos >= 1 &&
            (tipoEntrada == 1 || tipoEntrada == 2 || tipoEntrada == 3))
        {
            Console.WriteLine("\nEntrada autorizada");
            Console.WriteLine("Tipo de entrada: " + tipo);
        }
        else
        {
            Console.WriteLine("\nEntrada rechazada");
            Console.WriteLine("La persona no cumple con las condiciones establecidas.");
        }
    }
}