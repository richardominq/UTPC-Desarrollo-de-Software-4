// See https://aka.ms/new-console-template for more informatio// See https://aka.ms/new-console-template for more information

using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Por favpr, ingrese el nombre del Estudiante."); // Se solicita el nombre del estudiante al usuario
string nombre = Console.ReadLine();
Console.WriteLine($"Por favpr, ingrese el la nota final del estudiante {nombre}"); // Se solicita la nota final del estudiante al usuario
int nota = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Por favpr, la asistencia del estudiante {nombre}"); // Se solicita la asistencia del estudiante al usuario
int asistencia = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine($"El tipo de estudiante que es {nombre}"); // Se solicita el tipo de estudiante al usuario
Console.WriteLine(" 1- Regular\n 2- Becado \n 3-Intercambio"); 
int estudtipo = Convert.ToInt32(Console.ReadLine());

switch (estudtipo) // Switch para determinar el tipo de estudiante y llamar a la función ASISTENCIAS enviando los parametros
{
    case 1:
        ASISTENCIAS(nombre, nota, asistencia);
        break;
    case 2:
        ASISTENCIAS(nombre, nota, asistencia);
        break;
    case 3:
        ASISTENCIAS(nombre, nota, asistencia);
        break;
    default: // en caso de que el tipo de estudiante no sea 1, 2 o 3, se muestra un mensaje de error
        Console.WriteLine("El tipo de estudiante es incorrecto");
        break;
}
static void ASISTENCIAS(string nombre, int nota, int asistencia) // metodo para determinar si el estudiante aprueba o desaprueba por asistencia
{
    switch (asistencia) //Switch para determinar si el estudiante aprueba o desaprueba por asistencia
    {
        case < 0: //Caso en el que la asistencia es menor a 0, se muestra un mensaje de error
            Console.WriteLine("Dato de Asistencia INVALIDO");
            break;
        case >= 80: //caso en el que la asistencia es mayor o igual a 80
            RESULTADOS(nombre, nota, asistencia);
            break;
        case < 80: //caso en el que la asistencia es menor a 80, el estudiante desaprueba por inasistencia
            Console.WriteLine($"El estudiante de Nombre {nombre} \n" +
                  $"Asistencia del {asistencia}\n" +
                  $"Nota: {nota}\n" +
                  $"Ha sido DESAPROBADO por inasistencia");
            break;
        default: // caso en el que la asistencia no es un numero valido, se muestra un mensaje de error
            Console.WriteLine("Dato de Asistencia INVALIDO");
            break;
    }
}

static void RESULTADOS(string nombre, int nota, int asistencia) // metodo para determinar si el estudiante aprueba o desaprueba por nota
{
    switch (nota)
    {
        case < 0: //Caso en el que la nota es menor a 0, se muestra un mensaje de error
            Console.WriteLine("Dato de nota INVALIDO");
            break;
        case <= 71: //caso en el que la nota es menor o igual a 71, el estudiante aprueba
            Console.WriteLine($"El estudiante de Nombre {nombre} \n" +
              $"Asistencia del {asistencia}\n" +
              $"Nota: {nota}\n" +
              $"Ha sido APROBADO");
            break;
        case > 71: //caso en el que la nota es mayor a 71, el estudiante desaprueba
            Console.WriteLine($"El estudiante de Nombre {nombre} \n" +
                  $"Asistencia del {asistencia}\n" +
                  $"Nota: {nota}\n" +
                  $"Ha sido DESAPROBADO");
            break;
        default: // caso en el que la nota no es un numero valido, se muestra un mensaje de error
            Console.WriteLine("Dato de nota INVALIDO");
            break;

    }

}

