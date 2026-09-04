
/*36. Autorización bancaria
 * Solicite el monto de la transacción, el saldo disponible, el tipo de operación (1 = Retiro, 2 = Transferencia,
 * 3 = Pago) y el nivel de seguridad (1 = Normal, 2 = Verificado). Autorice la operación si existe saldo suficiente
 * y el monto es menor o igual a $1,000, o si la operación posee nivel de seguridad verificado. Utilice 
 * switch para identificar la operación. Muestre la operación, el monto y si fue autorizada o rechazada.
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
            int tipoOperacion;
            double monto, saldo;

            Console.WriteLine("------ Autorización Bancaria ------");

            // solicitar el monto de la transacción
            Console.Write("Ingrese el monto de la transacción $: ");
            monto = double.Parse(Console.ReadLine());

            // solicitar el saldo disponible
            Console.Write("Ingrese el saldo disponible $: ");
            saldo = double.Parse(Console.ReadLine());

            // solicitar el tipo de operación
            Console.WriteLine("Seleccione el tipo de operación: ");
            Console.WriteLine("1 - Retiro");
            Console.WriteLine("2 - Transferencia");
            Console.WriteLine("3 - Pago");
            Console.Write("Opción seleccionada: ");
            tipoOperacion = int.Parse(Console.ReadLine());

            // solicitar el nivel de seguridad
            Console.WriteLine("Seleccione el nivel de seguridad: ");
            Console.WriteLine("1 - Normal");
            Console.WriteLine("2 - Verificado");
            Console.Write("Opción seleccionada: ");
            int nivelSeguridad = int.Parse(Console.ReadLine());

            string nombreOperacion = "";

            // switch para identificar la operación
            switch (tipoOperacion)
            {
                case 1:
                    nombreOperacion = "retiro";
                    break;
                case 2:
                    nombreOperacion = "transferencia";
                    break;
                case 3:
                    nombreOperacion = "pago";
                    break;
                default:
                    nombreOperacion = "desconocida";
                    break;
            } 
            //imprimir el resultado
            Console.WriteLine("\n----- Resultado -----");
            Console.WriteLine("Operación: " + nombreOperacion);
            Console.WriteLine("Monto: $" + monto);

            // realizar la autorización de la operación
            if (saldo >= monto && monto <= 1000 || nivelSeguridad == 2)
            {
                Console.WriteLine("La operación fue autorizada");
            } 
            else
            {
                Console.WriteLine("La operación fue rechazada");
            }
        }
    }
}
