// Solicite la nota final, el porcentaje de asistencia y el tipo de estudiante
// (1 = Regular, 2 = Becado, 3 = Intercambio). El estudiante aprueba si obtiene una nota mayor o igual a 71
// y una asistencia mayor o igual al 80 %. Utilice switch para mostrar el nombre correspondiente al tipo de estudiante.
// Muestre “Aprobado” o “Reprobado” y el tipo de estudiante.

using System;
namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se declaran las variables 
            double notaFinal;
            double asistencia;
            int tipoEstudiante;
            string nombreTipo = "";
            string estado;

            // Se solicita al usuario la nota final del estudiante.
            Console.Write("Ingrese la nota final: ");
            notaFinal = Convert.ToDouble(Console.ReadLine());

            // Se solicita el porcentaje de asistencia del estudiante.
            Console.Write("Ingrese el porcentaje de asistencia: ");
            asistencia = Convert.ToDouble(Console.ReadLine());

            // Se solicita el tipo de estudiante.
            Console.Write("Ingrese el tipo de estudiante (1=Regular, 2=Becado, 3=Intercambio): ");
            tipoEstudiante = Convert.ToInt32(Console.ReadLine());

            // Se utiliza switch para identificar el tipo de estudiante según el número que se ingrese.
            switch (tipoEstudiante)
            {
                case 1:
                    nombreTipo = "Regular";
                    break;

                case 2:
                    nombreTipo = "Becado";
                    break;

                case 3:
                    nombreTipo = "Intercambio";
                    break;

                default:
                    // Si el número ingresado no corresponde a ningún tipo de estudiante, se asigna un valor por defecto.
                    nombreTipo = "Tipo no válido";
                    break;
            }

            // Se verifica si el estudiante cumple con los requisitos necesarios para aprobar.
            // Debe tener una nota mayor o igual a 71 y una asistencia mayor o igual al 80%.
            if (notaFinal >= 71 && asistencia >= 80)
            {
                estado = "Aprobado";
            }
            else
            {
                // Si no cumple con alguno de los requisitos, el estudiante queda reprobado.
                estado = "Reprobado";
            }

            // Se muestra el estado del estudiante y el tipo de estudiante.
            Console.WriteLine("\nEstado: " + estado);
            Console.WriteLine("Tipo de estudiante: " + nombreTipo);
        }
    }
}