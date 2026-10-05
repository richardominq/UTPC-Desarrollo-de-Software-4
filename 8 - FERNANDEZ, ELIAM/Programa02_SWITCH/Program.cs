// Programa 2: Aprobación de estudiante
// Evaluar si un estudiante aprueba un curso con base en su calificación, su porcentaje de asistencia y su categoría.

using System;

namespace StudentApprovalSwitch
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

            // Evaluate the condition using pattern matching within the switch statement.
            switch (finalGrade, attendancePercentage, studentType)
            {
                case (>= 71, >= 80, 1 or 2 or 3):
                    // Display a success message if the student passes all requirements.
                    Console.WriteLine("Resultado: Aprobado");
                    break;

                default:
                    // Display a failure message if the student fails any requirement.
                    Console.WriteLine("Resultado: No aprobado");
                    break;
            }
        }
    }
}
