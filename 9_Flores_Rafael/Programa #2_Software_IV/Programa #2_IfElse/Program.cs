using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la nota final: ");
        double nota = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el porcentaje de asistencia: ");
        double asistencia = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el tipo de estudiante (1 = Regular, 2 = Becado, 3 = Intercambio): ");
        int tipoEstudiante = Convert.ToInt32(Console.ReadLine());

        if (nota < 0 || nota > 100)
        {
            Console.WriteLine("La nota debe estar entre 0 y 100.");
            return;
        }

        if (asistencia < 0 || asistencia > 100)
        {
            Console.WriteLine("La asistencia debe estar entre 0 y 100.");
            return;
        }

        if (tipoEstudiante < 1 || tipoEstudiante > 3)
        {
            Console.WriteLine("Tipo de estudiante invalido. Debe ser 1, 2 o 3.");
            return;
        }

        string descripcionTipo;

        if (tipoEstudiante == 1)
        {
            descripcionTipo = "Regular";
        }
        else if (tipoEstudiante == 2)
        {
            descripcionTipo = "Becado";
        }
        else
        {
            descripcionTipo = "Intercambio";
        }

        Console.WriteLine("Tipo de estudiante: " + descripcionTipo);

        if (nota >= 71 && asistencia >= 80 && (tipoEstudiante == 1 || tipoEstudiante == 2 || tipoEstudiante == 3))
        {
            Console.WriteLine("Aprobado");
            Console.WriteLine("Nota final: " + nota);
            Console.WriteLine("Tipo de estudiante: " + descripcionTipo);
        }
        else
        {
            Console.WriteLine("No aprobado");
            Console.WriteLine("Nota final: " + nota);
        }
    }
}
