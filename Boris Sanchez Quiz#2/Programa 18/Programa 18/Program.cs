using System;

class Beca
{
    static void Main(string[] args)
    {
        double promedio;
        double ingresoFamiliar;
        int semestre;
        int tipoBeca;

        string beca;
        string elegibilidad;

        // Solicitar promedio académico
        Console.Write("Ingrese el promedio académico: ");
        promedio = Convert.ToDouble(Console.ReadLine());

        // Validación del promedio 
        if (promedio < 0 || promedio > 100)
        {
            Console.WriteLine("Error: El promedio debe estar entre 0 y 100.");
        }
        else
        {
            // Solicitar ingreso familiar
            Console.Write("Ingrese el ingreso familiar: $");
            ingresoFamiliar = Convert.ToDouble(Console.ReadLine());

            // Solicitar semestre
            Console.Write("Ingrese el semestre que cursa: ");
            semestre = Convert.ToInt32(Console.ReadLine());

            // Solicitar tipo de beca
            Console.WriteLine("\nTipo de beca:");
            Console.WriteLine("1 = Académica");
            Console.WriteLine("2 = Socioeconómica");
            Console.WriteLine("3 = Deportiva");

            Console.Write("Seleccione el tipo de beca: ");
            tipoBeca = Convert.ToInt32(Console.ReadLine());

            // Tipo de beca 
            switch (tipoBeca)
            {
                case 1:
                    beca = "Académica";
                    break;

                case 2:
                    beca = "Socioeconómica";
                    break;

                case 3:
                    beca = "Deportiva";
                    break;

                default:
                    beca = "Tipo de beca no válido";
                    break;
            }

            // Determinar si es elegibible
            if (promedio >= 85 && semestre >= 2 && ingresoFamiliar < 800)
            {
                elegibilidad = "Elegible";
            }
            else
            {
                elegibilidad = "No elegible";
            }

            // Resultados 
            Console.WriteLine("\n--- RESULTADOS ---");
            Console.WriteLine("Beca solicitada: " + beca);
            Console.WriteLine("Estado: " + elegibilidad);
        }
    }
}