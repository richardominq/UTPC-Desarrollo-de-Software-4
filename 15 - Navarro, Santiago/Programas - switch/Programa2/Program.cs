
/*
 * Programa 2: Aprobación de estudiante: Desarrolle un programa que permita determinar si un estudiante
 * aprueba una asignatura según su rendimiento y asistencia. Solicite la nota final, el porcentaje de
 * asistencia y el tipo de estudiante (1 = Regular, 2 = Becado, 3 = Intercambio). Si la nota es mayor o
 * igual a 71 y la asistencia es mayor o igual al 80 % y el estudiante seleccionó la opción 1, 2 o 3,
 * muestre el mensaje “Aprobado” junto con la nota obtenida. De lo contrario, muestre el mensaje “No aprobado”
 * y su nota final.
 */

using System;
using System.Text;

namespace Programa2
{
    class Program
    {
        static void Main(string[] args)
        {
            int tipoEstudiante = 0;
            double notaFinal = 0, porcentaje_Asist = 0;

            // Solicitar la nota final
            Console.Write("Ingrese su nota final: ");

            if (!double.TryParse(Console.ReadLine(), out notaFinal))//validar la opcion ingresada
            {
                Console.WriteLine("Error: debe ingresar un número válido");
                return;
            }
            if (notaFinal < 0 || notaFinal > 100)
            {
                Console.WriteLine("Error: la nota debe estar entre 0 y 100");
                return;
            }

            // Solicitar el porcentaje de asistencia
            Console.Write("Ingrese el porcentaje de asistencia: ");

            if (!double.TryParse(Console.ReadLine(), out porcentaje_Asist))//validar la opcion ingresada
            {
                Console.WriteLine("Error: debe ingresar un número válido");
                return;
            }
            if (porcentaje_Asist < 0 || porcentaje_Asist > 100)
            {
                Console.WriteLine("Error: el porcentaje de asistencia debe estar entre 0 y 100");
                return;
            }

            // Seleccionar el tipo de estudiante
            Console.WriteLine("Seleccione el tipo de estudiante: ");
            Console.WriteLine("1 = Regular");
            Console.WriteLine("2 = Becado");
            Console.WriteLine("3 = Intercambio");
            Console.Write("Opción seleccionada: ");

            if (!int.TryParse(Console.ReadLine(), out tipoEstudiante))//validar la opcion ingresada
            {
                Console.WriteLine("Error: debe ingresar un número");
                return;
            }

            switch (tipoEstudiante)
            {
                case 1:
                    Console.WriteLine("Estudiante regular");
                    if (notaFinal >= 71 && porcentaje_Asist >= 80)
                    {
                        Console.WriteLine("Aprobado");
                        Console.WriteLine("Su nota final es: " + notaFinal);
                    }
                    else
                    {
                        Console.WriteLine("No aprobado");
                        Console.WriteLine("Su nota final es: " + notaFinal);
                    }
                    break;

                case 2:
                    Console.WriteLine("Estudiante becado");

                    if (notaFinal >= 71 && porcentaje_Asist >= 80)
                    {
                        Console.WriteLine("Aprobado");
                        Console.WriteLine("Su nota final es: " + notaFinal);
                    }
                    else
                    {
                        Console.WriteLine("No aprobado");
                        Console.WriteLine("Su nota final es: " + notaFinal);
                    }
                    break;

                case 3:
                    Console.WriteLine("Estudiante de intercambio");

                    if (notaFinal >= 71 && porcentaje_Asist >= 80)
                    {
                        Console.WriteLine("Aprobado");
                        Console.WriteLine("Su nota final es: " + notaFinal);
                    }
                    else
                    {
                        Console.WriteLine("No aprobado");
                        Console.WriteLine("Su nota final es: " + notaFinal);
                    }
                    break;

                default:
                    Console.WriteLine("Opción incorrecta, debe seleccionar 1, 2 o 3");
                    break;
            }
        }
    }
}