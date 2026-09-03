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

            // Evaluar el tipo de estudiante
            switch (tipoEstudiante)
            {
                case 1:
                    // Estudiante regular
                    if (notaFinal >= 71 && (porcentajeAsistencia >= 80 || notaFinal >= 90))
                    {
                        Console.WriteLine("Aprobado");
                        Console.WriteLine("Nota obtenida: " + notaFinal);
                    }
                    else
                    {
                        Console.WriteLine("No aprobado");
                        Console.WriteLine("Nota final: " + notaFinal);
                    }
                    break;

                case 2:
                    // Estudiante becado
                    if (notaFinal >= 71 && (porcentajeAsistencia >= 80 || notaFinal >= 90))
                    {
                        Console.WriteLine("Aprobado");
                        Console.WriteLine("Nota obtenida: " + notaFinal);
                    }
                    else
                    {
                        Console.WriteLine("No aprobado");
                        Console.WriteLine("Nota final: " + notaFinal);
                    }
                    break;

                case 3:
                    // Estudiante de intercambio
                    if (notaFinal >= 71 && (porcentajeAsistencia >= 80 || notaFinal >= 90))
                    {
                        Console.WriteLine("Aprobado");
                        Console.WriteLine("Nota obtenida: " + notaFinal);
                    }
                    else
                    {
                        Console.WriteLine("No aprobado");
                        Console.WriteLine("Nota final: " + notaFinal);
                    }
                    break;

                default:
                    // Tipo de estudiante no válido
                    Console.WriteLine("Tipo de estudiante no válido.");
                    break;
                 }
            }
        }
    }

