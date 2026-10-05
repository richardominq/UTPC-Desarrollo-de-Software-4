using System;

class Program
{
    static void Main()
    {
        double notaFinal, asistencia;
        int tipoEstudiante;

        Console.Write("Ingrese la nota final: ");
        notaFinal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el porcentaje de asistencia: ");
        asistencia = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Tipo de estudiante:");
        Console.WriteLine("1. Regular");
        Console.WriteLine("2. Becado");
        Console.WriteLine("3. Intercambio");
        Console.Write("Seleccione una opción: ");
        tipoEstudiante = Convert.ToInt32(Console.ReadLine());

        if (notaFinal >= 71 && asistencia >= 80 &&
            (tipoEstudiante == 1 || tipoEstudiante == 2 || tipoEstudiante == 3))
        {
            Console.WriteLine("Aprobado");
            Console.WriteLine("Nota obtenida: " + notaFinal);
        }
        else
        {
            Console.WriteLine("No aprobado");
            Console.WriteLine("Nota final: " + notaFinal);
        }
    }
}