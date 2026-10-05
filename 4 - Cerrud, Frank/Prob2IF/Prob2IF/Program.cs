Console.WriteLine("Bienvenido al Sistema de Aprobacion");

Console.WriteLine("Ingrese la nota final del estudiante (0 - 100):");
string entradanota = Console.ReadLine();
byte nota = byte.Parse(entradanota);

Console.WriteLine("Ingrese el porcentaje de asistencia del estudiante (0 - 100):");
string entradaasistencia = Console.ReadLine();
byte asistencia = byte.Parse(entradaasistencia);

Console.WriteLine("Ingrese el tipo de estudiante:\n" +
    "1. Regular\n" +
    "2. Becado\n" +
    "3. Intercambio");
string entradatipo = Console.ReadLine();
byte tipo = byte.Parse(entradatipo);

if ((tipo == 1 || tipo == 2 || tipo == 3) && nota >= 71 && asistencia >= 80)
{
    Console.WriteLine("Aprobado. Nota obtenida: " + nota);
}
else
{
    Console.WriteLine("No aprobado. Su nota final es: " + nota);
}

Console.WriteLine("Gracias por usar el sistema");