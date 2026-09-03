using System;

class Program
{
    public static void Main(string[] args)
    {
        double nota;
        double asistencia;
        int tipo;

        Console.Write("Ingrese la nota final: ");
        nota = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el porcentaje de asistencia: ");
        asistencia = Convert.ToDouble(Console.ReadLine());

        Console.Write("Tipo de estudiante (1 Regular, 2 Becado, 3 Intercambio): ");
        tipo = Convert.ToInt32(Console.ReadLine());

        switch ((nota, asistencia, tipo))
        {
            case (>= 71, >= 80, 1):
            case (>= 71, >= 80, 2):
            case (>= 71, >= 80, 3):
                Console.WriteLine("Estudiante aprobado");
                Console.WriteLine("Nota final: " + nota);
                break;

            default:
                Console.WriteLine("Estudiante no aprobado");
                Console.WriteLine("Nota final: " + nota);
                break;
        }

        Console.ReadKey();
    }
}