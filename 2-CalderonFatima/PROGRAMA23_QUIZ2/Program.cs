//Solicite la velocidad del vehículo, el límite de velocidad y
//las condiciones climáticas (1 = Normal, 2 = Lluvia, 3 = Neblina).
//Si la velocidad supera el límite o conduce con lluvia o neblina a más de 80 km/h,
//indique “Riesgo elevado”. Muestre el estado de riesgo y la diferencia respecto al límite.
using System;
namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se declaran las variables que se utilizarán en el programa.
            double velocidad;
            double limite;
            int clima;
            double diferencia;
            string estadoRiesgo;

            // Se solicita al usuario la velocidad a la que conduce.
            Console.Write("Ingrese la velocidad del vehículo (km/h): ");
            velocidad = Convert.ToDouble(Console.ReadLine());

            // Se solicita el límite de velocidad establecido.
            Console.Write("Ingrese el límite de velocidad (km/h): ");
            limite = Convert.ToDouble(Console.ReadLine());

            // Se solicita el estado del clima.
            Console.Write("Ingrese las condiciones climáticas (1=Normal, 2=Lluvia, 3=Neblina): ");
            clima = Convert.ToInt32(Console.ReadLine());

            // Se calcula la diferencia entre la velocidad del vehículo y el límite de velocidad.
            diferencia = velocidad - limite;

            // Se verifica si existe un riesgo elevado.
            // Hay riesgo si la velocidad supera el límite, o si está lloviendo o hay neblina y la velocidad es mayor a 80 km/h.
            if (velocidad > limite || ((clima == 2 || clima == 3) && velocidad > 80))
            {
                estadoRiesgo = "Riesgo elevado";
            }
            else
            {
                // Si ninguna de las condiciones anteriores se cumple, el riesgo se considera normal.
                estadoRiesgo = "Riesgo normal";
            }

            // Se muestran los resultados obtenidos.
            Console.WriteLine("\nEstado de riesgo: " + estadoRiesgo);
            Console.WriteLine("Diferencia respecto al límite: " + diferencia + " km/h");
        }
    }
}
