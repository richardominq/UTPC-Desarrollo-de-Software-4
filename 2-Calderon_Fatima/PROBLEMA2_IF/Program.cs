using System;
namespace Basics
{

    class Program
    {
        static void Main(string[] args)
        {
            // Declaración de variables
            double notaFinal;
            double porcentajeAsistencia;
            int tipoEstudiante;

            // Solicitar la nota final
            Console.Write("Ingrese la nota final: ");
            notaFinal = double.Parse(Console.ReadLine());

            // Solicitar el porcentaje de asistencia
            Console.Write("Ingrese el porcentaje de asistencia: ");
            porcentajeAsistencia = double.Parse(Console.ReadLine());

            // Mostrar las opciones de estudiante
            Console.WriteLine("1 = Regular");
            Console.WriteLine("2 = Becado");
            Console.WriteLine("3 = Intercambio");

            // Solicitar el tipo de estudiante
            Console.Write("Ingrese el tipo de estudiante: ");
            tipoEstudiante = int.Parse(Console.ReadLine());

            // Verificar que la nota sea mayor o igual a 71
            if (notaFinal >= 71)
            {
                // Verificar la asistencia o si la nota es mayor o igual 90
                if (porcentajeAsistencia >= 80 || notaFinal >=90)
                {
                    // Verificar que el tipo de estudiante sea válido
                    if (tipoEstudiante == 1 || tipoEstudiante == 2 || tipoEstudiante == 3)
                    {
                        // Mostrar que el estudiante aprobó
                        Console.WriteLine("Aprobado");
                        Console.WriteLine("Nota obtenida: " + notaFinal);
                    }
                    else
                    {
                        // El tipo de estudiante no es válido
                        Console.WriteLine("No aprobado");
                        Console.WriteLine("Nota final: " + notaFinal);
                    }
                }
                else
                {
                    // La asistencia no cumple y la nota no es mayor a 90
                    Console.WriteLine("No aprobado");
                    Console.WriteLine("Nota final: " + notaFinal);
                }
            }
            else
            {
                // La nota no cumple el mínimo requerido
                Console.WriteLine("No aprobado");
                Console.WriteLine("Nota final: " + notaFinal);
            }
        }
    }
}