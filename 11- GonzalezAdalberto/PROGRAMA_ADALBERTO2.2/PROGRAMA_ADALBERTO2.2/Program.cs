namespace PROGRAMA_ADALBERTO2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pedimos la nota del estudiante
            Console.WriteLine("Ingrese la nota del estudiante (0-100):");
            int notafinal = Convert.ToInt32(Console.ReadLine());

            // Pedimos el porcentaje de asistencia
            Console.WriteLine("Ingrese el porcentaje de asistencia (0%-100%):");
            int asistencia = Convert.ToInt32(Console.ReadLine());

            // Pedimos el tipo de estudiante
            Console.WriteLine("Ingrese el tipo de estudiante:");
            Console.WriteLine("(1) Regular");
            Console.WriteLine("(2) Becado");
            Console.WriteLine("(3) Intercambio");
            int tipoestudiante = Convert.ToInt32(Console.ReadLine());

            // Guardamos la nota original
            int notaOriginal = notafinal;

            // Verificamos la asistencia utilizando SWITCH
            switch (asistencia < 80)
            {
                case true:

                    // Si tiene menos del 80% de asistencia,
                    // se le descuentan 10 puntos
                    notafinal = notafinal - 10;

                    Console.WriteLine($"Nota original: {notaOriginal}");
                    Console.WriteLine($"Nota después de la reducción: {notafinal}");
                    Console.WriteLine("Se le redujeron 10 puntos por tener menos del 80% de asistencia.");

                    // Verificamos si aprobó después de la reducción
                    switch (notafinal >= 71)
                    {
                        case true:
                            Console.WriteLine("El estudiante aprobó, pero se le bajó la nota por su asistencia.");
                            break;

                        case false:
                            Console.WriteLine("El estudiante reprobó porque su nota quedó por debajo de 71.");
                            break;
                    }

                    break;

                case false:

                    // Si tiene 80% o más, conserva su nota
                    Console.WriteLine($"Nota final: {notafinal}");
                    Console.WriteLine("El estudiante no tuvo reducción por asistencia.");

                    // Verificamos si aprobó
                    switch (notafinal >= 71)
                    {
                        case true:
                            Console.WriteLine("El estudiante ha aprobado.");
                            break;

                        case false:
                            Console.WriteLine("El estudiante ha reprobado.");
                            break;
                    }

                    break;
            }

            // Mostramos el tipo de estudiante
            Console.WriteLine($"Tipo de estudiante: {tipoestudiante}");

            // Evita que la consola se cierre
            Console.WriteLine("\nPresiona ENTER para salir...");
            Console.ReadLine();
        }
    }
}
