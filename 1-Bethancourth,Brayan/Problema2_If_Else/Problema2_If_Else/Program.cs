Console.WriteLine($"Programa de Aprobación Estudiantil");

//declaración de variables
int notafinal;
int asistencia;
int tipoestudiante;
string nombretipo;

Console.WriteLine($"Ingrese su nota final: ");
notafinal= int.Parse( Console.ReadLine() );

Console.WriteLine($"Ingrese su porcentaje de asistencia: ");
asistencia = int.Parse( Console.ReadLine() );
/* Console.ReadLine() recibe el dato ingresado por el usuario
int.Parse() convierte el dato recibido a un número entero*/

Console.WriteLine($"Seleccione el tipo de estudiante: ");
Console.WriteLine($"1: Regular");
Console.WriteLine($"2: Becado");
Console.WriteLine($"3: Intercambio");
tipoestudiante = int.Parse( Console.ReadLine() );

//validar el tipo de estudiante
if (tipoestudiante == 1)
{
    nombretipo = "Regular";
}else if (tipoestudiante==2)
{
    nombretipo = "Becado";
}else if(tipoestudiante == 3)
{
    nombretipo = "Intercambiio";
}
//si se ingresa alguna opción distinta a 1,2 o 3, la opcion s¿no es valida.
else
{
    Console.WriteLine($"Tipo de estudiante no valido");
    return;
}

//validar la aprobacion 
if(notafinal>=71 && asistencia >= 80)
{
    Console.WriteLine($"Usted ha aprovado");
}
else
{
    Console.WriteLine($"Usted no ha cumplido con las condiciones establecidas");
    Console.WriteLine($"Reprobado.");
}
//mostrar resultados
Console.WriteLine($"Nota final: {notafinal}");
Console.WriteLine($"Porcentaje de Asistencia: {asistencia}%");
Console.WriteLine($"Tipo de estudiante: {nombretipo}");