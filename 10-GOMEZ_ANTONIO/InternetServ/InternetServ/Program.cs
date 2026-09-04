/*
 * 31. Servicio de Internet
Solicite la velocidad contratada, la velocidad medida y el tipo de plan (1 = Hogar, 2 = Negocio, 3 = Empresarial).
Determine si el servicio es aceptable cuando la velocidad medida alcanza al menos el 80 % de la contratada.
Utilice switch para identificar el plan. Muestre el plan y el estado del servicio.

Entradas: 3. Salidas: 2.
Utilizar: if, switch.
*/

using System;

public class InternetService
{
    public static void Main()
    {
        // Solicita al usuario la velocidad contratada en Mbps
        Console.WriteLine("Ingrese la velocidad contratada (Mbps):");
        // Convierte la entrada (string) a tipo double
        double velociContratada = Convert.ToDouble(Console.ReadLine());

        // Solicita la velocidad realmente medida
        Console.WriteLine("Ingrese la velocidad medida (Mbps):");
        double velociMedida = Convert.ToDouble(Console.ReadLine());

        // Solicita el tipo de plan mediante un número entero
        Console.WriteLine("Ingrese el tipo de plan (1 = Hogar, 2 = Negocio, 3 = Empresarial):");
        int planType = Convert.ToInt32(Console.ReadLine());

        // Calcula si la velocidad medida es al menos el 80% de la contratada
        // El umbral fijo del 80% se aplica a todos los planes
        bool isAcceptable = velociMedida >= 0.8 * velociContratada;

        // Muestra el nombre del plan según el código ingresado
        switch (planType)
        {
            case 1:
                Console.WriteLine("Plan: Hogar");
                break;
            case 2:
                Console.WriteLine("Plan: Negocio");
                break;
            case 3:
                Console.WriteLine("Plan: Empresarial");
                break;
            default:
                // Si el código no es válido, se muestra un error y se termina la ejecución
                Console.WriteLine("Plan no válido");
                return; // Sale del método Main (finaliza el programa)
        }

        // Muestra el resultado final usando un operador ternario
        // Si isAcceptable es verdadero, imprime "aceptable"; si no, "no aceptable"
        Console.WriteLine($"Servicio {(isAcceptable ? "aceptable" : "no aceptable")}");
    }
}