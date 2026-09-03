using System;

// Nombre: Keisi Delgado
namespace Programa_Estudiante
{
    class Program_If2
    {
        static void Main(string[] args)
        {
            // Pedimos la nota final
            Console.Write("Ingrese su nota final: ");
            int notaFinal = Convert.ToInt32(Console.ReadLine());

            // Pedimos el porcentaje de asistencia
            Console.Write("Ingrese el porcentaje de su asistencia: ");
            int porcentajeAsistencia = Convert.ToInt32(Console.ReadLine());

            // Mostramos los tipos de estudiantes
            Console.WriteLine("\nTipos de estudiantes:");
            Console.WriteLine("1. Regular");
            Console.WriteLine("2. Becado");
            Console.WriteLine("3. Intercambio");
            Console.Write("Seleccione el tipo de estudiante (1, 2, 3): ");
            int tipoEstudiante = Convert.ToInt32(Console.ReadLine());

            // Verificamos los datos del estudiante
            switch (tipoEstudiante)
            {
                case 1:
                case 2:
                case 3:
                    switch (notaFinal >= 71 && porcentajeAsistencia >= 80)
                    {
                        case true:
                            Console.WriteLine("\nFelicidades, estás aprobado.");
                            Console.WriteLine($"Tu nota final es: {notaFinal}");
                            break;

                        case false:
                            Console.WriteLine("\nNo aprobaste.");
                            Console.WriteLine($"Calificación insuficiente o asistencia mínima.");
                            Console.WriteLine($"Tu nota final es: {notaFinal}");
                            break;
                    }

                    break;

                default:
                    Console.WriteLine("\n[Error]: Opción no válida. Solo se permiten las opciones 1, 2 o 3.");
                    break;
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}