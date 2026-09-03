// Programa 2: Aprobación de estudiante
// Evaluar si un estudiante aprueba un curso con base en su calificación, su porcentaje de asistencia y su categoría.

using System;

namespace StudentApprovalIf
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the student's final grade.
            Console.Write("Ingrese la nota final: ");
            double finalGrade = double.Parse(Console.ReadLine());

            // Prompt the user to enter the attendance percentage.
            Console.Write("Ingrese el porcentaje de asistencia (0-100): ");
            double attendancePercentage = double.Parse(Console.ReadLine());

            // Read the student type to include in the evaluation.
            Console.WriteLine("Tipos de estudiante: 1 = Regular, 2 = Becado, 3 = Intercambio");
            Console.Write("Ingrese el tipo de estudiante: ");
            int studentType = int.Parse(Console.ReadLine());

            // Check if the grade, attendance, and student type meet the passing criteria.
            if (finalGrade >= 71 && attendancePercentage >= 80 && (studentType == 1 || studentType == 2 || studentType == 3))
            {
                // Display a success message if all academic conditions are satisfied.
                Console.WriteLine("Resultado: Aprobado");
            }
            else
            {
                // Display a failure message if any of the mandatory conditions is not met.
                Console.WriteLine("Resultado: No aprobado");
            }
        }
    }
}
