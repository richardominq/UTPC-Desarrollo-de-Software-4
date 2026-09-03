using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese su edad: ");
        int edad = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese la cantidad de boletos disponibles: ");
        int boletos = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el tipo de entrada (1 = General, 2 = VIP, 3 = Invitado): ");
        int tipoEntrada = Convert.ToInt32(Console.ReadLine());

        if (edad < 0)
        {
            Console.WriteLine("La edad no puede ser negativa.");
            return;
        }

        if (boletos < 0)
        {
            Console.WriteLine("La cantidad de boletos no puede ser negativa.");
            return;
        }

        if (tipoEntrada < 1 || tipoEntrada > 3)
        {
            Console.WriteLine("Tipo de entrada invalido. Debe ser 1, 2 o 3.");
            return;
        }

        string descripcionTipo;

        if (tipoEntrada == 1)
        {
            descripcionTipo = "General";
        }
        else if (tipoEntrada == 2)
        {
            descripcionTipo = "VIP";
        }
        else
        {
            descripcionTipo = "Invitado";
        }

        Console.WriteLine("Tipo de entrada: " + descripcionTipo);

        if (edad >= 18 && boletos >= 1 && (tipoEntrada == 1 || tipoEntrada == 2 || tipoEntrada == 3))
        {
            Console.WriteLine("Entrada autorizada");
            Console.WriteLine("Tipo de entrada: " + descripcionTipo);
        }
        else
        {
            Console.WriteLine("Entrada rechazada");
        }
    }
}
