Console.WriteLine($"Programa de Aprobación estudiantil");
int notafinal;
int asistencia;
int tipoestudidante;
string nombretipo;

Console.WriteLine($"Ingrese su nota final: ");
notafinal= int.Parse( Console.ReadLine() );

Console.WriteLine($"Ingrese su porcentaje de asistencia: ");
asistencia = int.Parse(Console.ReadLine());

Console.WriteLine($"Seleccione el tipo de estudiante: \n1: Regular. \n2: Becado. \n3: Intercambio.");
tipoestudidante= int.Parse( Console.ReadLine());

switch (tipoestudidante)
{
    case 1:
        nombretipo = "Regular";
    break;

    case 2:
        nombretipo = "Becado";
    break;

    case 3:
        nombretipo = "Intercambio";
    break;

    default:
        Console.WriteLine($"Tipo de estudiante invalido.");
    return;
}

switch(notafinal>=71 && asistencia >= 80)
{
    case true:
        Console.WriteLine($"Usted ha aprovado");
    break;
    case false:
        Console.WriteLine($"Usted no ha cumplido con las condiciones para aprobar.");
        Console.WriteLine($"Reprobado");
        break;
}

Console.WriteLine($"Nota Final: {notafinal}");
Console.WriteLine($"Porcentaje de asistencia: {asistencia}%");
Console.WriteLine($"Tipo de Estudiante: {nombretipo}");
