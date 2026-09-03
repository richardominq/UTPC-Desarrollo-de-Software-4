/*
 * Aprobación de estudiante: Desarrolle un programa que permita determinar si un estudiante aprueba una asignatura según su rendimiento y asistencia.
 * Solicite la nota final, el porcentaje de asistencia y el tipo de estudiante (1 = Regular, 2 = Becado, 3 = Intercambio).
 * Si la nota es mayor o igual a 71 y la asistencia es mayor o igual al 80 % y el estudiante seleccionó la opción 1, 2 o 3, muestre el mensaje “Aprobado” junto con la nota obtenida.
 * De lo contrario, muestre el mensaje “No aprobado” y su nota final.
 */
using System; 
class AprobacionDeEstudiante
{
    public static void Main(string[] args)
    {

        double notaFinal;
        double asistencia;
        int Estudiante;
        
        
        Console.Write("Ingrese el tipo de estudiante (1 = Regular, 2 = Becado, 3 = Intercambio): ");
        Estudiante= Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Ingrese la nota final : ");
        notaFinal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el porcentaje de asistencia: ");
        asistencia = Convert.ToDouble(Console.ReadLine());

        
        
        if (notaFinal >= 71 && asistencia >= 80 && (Estudiante == 1 || Estudiante == 2 || Estudiante == 3))
        {
            Console.WriteLine($"Aprobado. Nota obtenida: {notaFinal}");
        }
        else
        {
            Console.WriteLine($"No aprobado. Nota final: {notaFinal}");
        }
        
        
        
    }
}






