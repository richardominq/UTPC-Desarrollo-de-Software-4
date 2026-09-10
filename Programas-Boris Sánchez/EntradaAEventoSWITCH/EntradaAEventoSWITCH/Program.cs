using System;

class Program
{
    static void Main(string[] args)
    {
        int edad;
        int boletos;
        int tipoEntrada;
        string tipo;

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

        // Identificar el tipo utilizando SWITCH
        switch (tipoEntrada)
        {
            case 1:
                tipo = "General";
                break;

            case 2:
                tipo = "VIP";
                break;

            case 3:
                tipo = "Invitado";
                break;

            default:
                tipo = "Inválido";
                break;
        }

        // Validar condiciones utilizando SWITCH
        switch (edad, boletos, tipoEntrada)
        {
            case ( >= 18, >= 1, 1 or 2 or 3):
                Console.WriteLine("\nEntrada autorizada");
                Console.WriteLine("Tipo de entrada: " + tipo);
                break;

            default:
                Console.WriteLine("\nEntrada rechazada");
                Console.WriteLine("La persona no cumple con las condiciones establecidas.");
                break;
        }
    }
}