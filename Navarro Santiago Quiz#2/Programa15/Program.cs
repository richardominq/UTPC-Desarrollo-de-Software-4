/*15. Evaluación de computadora
 * Solicite la cantidad de RAM, el espacio libre en disco, el tipo de procesador (1 = Básico, 2 = Intermedio,
 * 3 = Alto rendimiento) y el uso principal (1 = Oficina, 2 = Programación, 3 = Diseño). Determine si el 
 * equipo es adecuado cuando posee al menos 8 GB de RAM y 100 GB libres, o cuando el procesador es de 
 * alto rendimiento. Muestre el tipo de procesador, el uso seleccionado y si el equipo es adecuado.
 * 
 * Entradas: 4. Salidas: 3. Utilizar: if, &&, ||, switch.
 */

using System;
using System.Text;
namespace Programa15

{ // An open brace indicates the start of a block.
    class Program
    {
        static void Main(string[] args)
        {
            int tipoProcesador, tipoUso;
            double cantidadRam, espacioDisco;

            Console.WriteLine("------Evaluación de Computadora------");

            //solicitar la cantidad de ram
            Console.Write("Ingrese la cantidad de (GB) RAM: ");
            cantidadRam = double.Parse(Console.ReadLine());

            //solicitar la cantidad de almacenamiento disponible en el disco
            Console.Write("Ingrese de almacenamiento (GB) disponible: ");
            espacioDisco = double.Parse(Console.ReadLine());
            //solicitar el tipo de procesador 
            Console.WriteLine("Seleccione el tipo de procesador que tiene: ");
            Console.WriteLine("1 - Básico");
            Console.WriteLine("2 - Intermedio");
            Console.WriteLine("3 - Alto rendimiento");
            Console.Write("Opción seleccionada: ");
            tipoProcesador = int.Parse(Console.ReadLine());
            //solicitar el tipo de uso
            Console.WriteLine("Seleccione el tipo de uso: ");
            Console.WriteLine("1 - Oficina");
            Console.WriteLine("2 - Programación");
            Console.WriteLine("3 - Diseño");
            Console.Write("Opción seleccionada: ");
            tipoUso = int.Parse(Console.ReadLine());

            string nombreProcesador = "";
            string nombreUso = "";
            string equipoAdecuado = "";

            switch (tipoUso)// switch para imprimir segun el tipo de uso
            {
                case 1:
                    nombreUso = "oficina";
                    break;
                case 2:
                    nombreUso = "programación";
                    break;
                case 3:
                    nombreUso = "diseño";
                    break;
                default:
                    nombreUso = "desconocido";
                    break;
            }

            // switch para deterninar si el equipo es adecuado segun el tipo de procesador
            switch (tipoProcesador)
            {
                case 1:
                    nombreProcesador = "básico";
                    // procesador básico es adecuado solo si la RAM y disco tienen buena capacidad 
                    if (cantidadRam >= 8 && espacioDisco >= 100)
                    {
                        equipoAdecuado = "El equipo si es adecuado";
                    }
                    else
                    {
                        equipoAdecuado = "El equipo no es adecuado";
                    }
                    break;

                case 2:
                    nombreProcesador = "intermedio";
                    // procesador intermedio es adecuado solo si la RAM y disco tienen buena capacidad
                    if (cantidadRam >= 8 && espacioDisco >= 100)
                    {
                        equipoAdecuado = "El equipo si es adecuado";
                    }
                    else
                    {
                        equipoAdecuado = "El equipo no es adecuado";
                    }
                    break;

                case 3:
                    nombreProcesador = "alto rendimiento";
                    //si el procesador es de alto rendimiento, el equipo debe cumplir con las condiciones de RAM y disco
                    if (cantidadRam >= 8 && espacioDisco >= 100 || tipoProcesador == 3)
                    {
                        equipoAdecuado = "El equipo si es adecuado";
                    }
                    else
                    {
                        equipoAdecuado = "El equipo no es adecuado";
                    }
                    break;

                default:
                    nombreProcesador = "Desconocido";
                    equipoAdecuado = "No se puede evaluar";
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("----- RESULTADO -----");
            Console.WriteLine("Tipo de procesador: " + nombreProcesador);
            Console.WriteLine("Uso seleccionado: " + nombreUso);
            Console.WriteLine(equipoAdecuado);
        }
    }
}
