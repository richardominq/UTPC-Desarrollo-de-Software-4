using System;

class NotaEstudianteConIF
{
    static void Main(string[] args)
    {
        double notaFinal;
        double asistencia;
        int tipoEstudiante;
        string tipo = "";

        Console.Write("Ingrese la nota final: ");
        notaFinal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el porcentaje de asistencia: ");
        asistencia = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nTipo de estudiante:");
        Console.WriteLine("1 = Regular");
        Console.WriteLine("2 = Becado");
        Console.WriteLine("3 = Intercambio");

        Console.Write("Seleccione una opción: ");
        tipoEstudiante = Convert.ToInt32(Console.ReadLine());

        // Identificar el tipo utilizando IF
        if (tipoEstudiante == 1)
        {
            tipo = "Regular";
        }
        else if (tipoEstudiante == 2)
        {
            tipo = "Becado";
        }
        else if (tipoEstudiante == 3)
        {
            tipo = "Intercambio";
        }
        else
        {
            tipo = "Inválido";
        }

        // Validar aprobación
        if (notaFinal >= 71 &&
            asistencia >= 80 &&
            (tipoEstudiante == 1 || tipoEstudiante == 2 || tipoEstudiante == 3))
        {
            Console.WriteLine("\nAprobado");
            Console.WriteLine("Nota obtenida: " + notaFinal);
            Console.WriteLine("Tipo de estudiante: " + tipo);
        }
        else
        {
            Console.WriteLine("\nNo aprobado");
            Console.WriteLine("Nota final: " + notaFinal);
        }
    }
}