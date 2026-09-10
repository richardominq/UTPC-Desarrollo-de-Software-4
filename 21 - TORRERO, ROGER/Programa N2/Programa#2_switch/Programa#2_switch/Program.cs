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

        switch (tipoEstudiante)
        {
            case 1:
            case 2:
            case 3:

                if (notaFinal >= 71 && asistencia >= 80)
                {
                    Console.WriteLine("Aprobado");
                    Console.WriteLine("Nota obtenida: " + notaFinal);
                }
                else
                {
                    Console.WriteLine("No aprobado");
                    Console.WriteLine("Nota final: " + notaFinal);
                }

                break;

            default:
                Console.WriteLine("Tipo de estudiante no válido.");
                break;
        }
    }
}