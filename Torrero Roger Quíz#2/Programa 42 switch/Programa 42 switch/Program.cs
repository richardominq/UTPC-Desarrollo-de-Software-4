using System;

class Program
{
    static void Main()
    {
        int creditos, promedio, anioCarrera, tipoEstudiante;
        string tipo;

        Console.Write("Ingrese la cantidad de créditos: ");
        creditos = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el promedio académico: ");
        promedio = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el año de la carrera: ");
        anioCarrera = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el tipo de estudiante (1 = Regular, 2 = Becado, 3 = Intercambio): ");
        tipoEstudiante = int.Parse(Console.ReadLine());

        tipo = tipoEstudiante switch
        {
            1 => "Regular",
            2 => "Becado",
            3 => "Intercambio",
            _ => "Tipo no válido"
        };

        Console.WriteLine("Tipo de estudiante: " + tipo);
        Console.WriteLine("Créditos solicitados: " + creditos);

        if ((promedio >= 71 && creditos <= 18)
            || (tipoEstudiante == 2 && promedio >= 80))
        {
            Console.WriteLine("Matrícula autorizada");
        }
        else
        {
            Console.WriteLine("Matrícula requiere revisión");
        }
    }
}