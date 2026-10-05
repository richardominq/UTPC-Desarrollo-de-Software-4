
// See https://aka.ms/new-console-template for more informatio// See https://aka.ms/new-console-template for more information

Console.WriteLine("Por favpr, ingrese el nombre del Estudiante.");
string nombre = Console.ReadLine();

Console.WriteLine($"Por favpr, ingrese el la nota final del estudiante {nombre}");
int nota = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Por favpr, la asistencia del estudiante {nombre}");
int asistencia = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"El tipo de estudiante que es {nombre}");
Console.WriteLine(" 1- Regular\n 2- Becado \n 3-Intercambio");
int estudtipo = Convert.ToInt32(Console.ReadLine());




if (nota > 71 && nota > 0 && asistencia > 80 && (estudtipo == 1 || estudtipo == 2 || estudtipo == 3)) // Condicional que define si el estudiante ha sido aprobado
{
    Console.WriteLine($"El estudiante de Nombre {nombre} \n" +
                      $"Asistencia del {asistencia}\n" +
                      $"Nota: {nota}\n" +
                      $"Ha sido APROBADO");

}
else if (nota < 71 && nota > 0 && asistencia > 80 && (estudtipo == 1 || estudtipo == 2 || estudtipo == 3)) //Condicional que define si el estudiante ha sido desaprobado por nota
{
    Console.WriteLine($"El estudiante de Nombre {nombre} \n" +
                  $"Asistencia del {asistencia}\n" +
                  $"Nota: {nota}\n" +
                  $"Ha sido DESAPROBADO");


}
else if ((nota > 71 || nota < 71 && nota > 0) && asistencia < 80 && (estudtipo == 1 || estudtipo == 2 || estudtipo == 3)) // Condicional que define si el estudiante ha sido desaprobado por inasistencia
{
    Console.WriteLine($"El estudiante de Nombre {nombre} \n" +
                  $"Asistencia del {asistencia}\n" +
                  $"Nota: {nota}\n" +
                  $"Ha sido DESAPROBADO por inasistencia");

}
else if (estudtipo > 3 || estudtipo < 1) // Condicional que define si el tipo de estudiante es válido
{
    Console.WriteLine($"Tipo de estudiante no válido");

}
else // Else que define si los datos ingresados son válidos, en caso de que no lo sean, se mostrará un mensaje de error
{
    Console.WriteLine($"Hubo un error en los datos");

}

