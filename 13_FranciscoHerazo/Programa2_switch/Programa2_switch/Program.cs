Console.WriteLine("--- Aprobacion de estudiante ---");

Console.WriteLine("\nIngrese la nota final");
double notaFinal = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("\nIngrese el porcentaje de asistencia");
double asistencia = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("\nIngrese el tipo de estudiante");
Console.WriteLine("1 | Regular");
Console.WriteLine("2 | Becado");
Console.WriteLine("3 | Intercambio");
int tipoEstudiante = Convert.ToInt32(Console.ReadLine());

switch (tipoEstudiante)
{
    case 1:
        Console.WriteLine("\nTipo de estudiante: Regular");
        break;
    case 2:
        Console.WriteLine("\nTipo de estudiante: Becado");
        break;
    case 3:
        Console.WriteLine("\nTipo de estudiante: Intercambio");
        break;
    default:
        Console.WriteLine("\nTipo de estudiante no valido");
        break;
}

if (notaFinal >= 71 && asistencia >= 80 && (tipoEstudiante == 1 || tipoEstudiante == 2 || tipoEstudiante == 3))
{
    Console.WriteLine("\nAprobado");
    Console.WriteLine("Nota final: " + notaFinal);
    Console.WriteLine("Tipo de estudiante: " + tipoEstudiante);
}
else
{
    Console.WriteLine("\nNo aprobado");
    Console.WriteLine("Nota final: " + notaFinal);
}