using System;

class AprobaciónEstudianteConSwitch

{
    static void Main(string[] args)
    {
        double notaFinal;
        double asistencia;
        int tipoEstudiante;
        string tipo;

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

        // Identificar el tipo utilizando SWITCH
        switch (tipoEstudiante)
        {
            case 1:
                tipo = "Regular";
                break;

            case 2:
                tipo = "Becado";
                break;

            case 3:
                tipo = "Intercambio";
                break;

            default:
                tipo = "Inválido";
                break;
        }

        // Validación utilizando SWITCH con pattern matching
        switch (notaFinal, asistencia, tipoEstudiante)
        {
            case ( >= 71, >= 80, 1 or 2 or 3):
                Console.WriteLine("\nAprobado");
                Console.WriteLine("Nota obtenida: " + notaFinal);
                Console.WriteLine("Tipo de estudiante: " + tipo);
                break;

            default:
                Console.WriteLine("\nNo aprobado");
                Console.WriteLine("Nota final: " + notaFinal);
                break;
        }
    }
}