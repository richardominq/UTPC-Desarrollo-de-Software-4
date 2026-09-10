/*
 * Solicite el peso del paquete y el tipo de envío (1 = Normal, 2 = Express, 3 = Internacional).
 * Utilice switch expression para determinar la tarifa base.
 * Si el paquete supera 10 kg, agregue un recargo por peso. Muestre la tarifa base, el recargo y el costo total.
   Entradas: 2. Salidas: 3.
   Utilizar: if, switch expression.
 */

using System;

class EstructurasSelectivas
{
    static void Main(string[] args)
    {
        
        double peso;
        int tipoDeEnvio;
        double tarifaBase;
        double recargo = 0;
        double costoTotal;

        inicio:
        Console.WriteLine("Ingrese el peso en (kg) del paquete:");
        peso = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Ingrese el tipo de envio:\n" +
                          "1-Normal\n" +
                          "2-Express\n" +
                          "3-Internacional\n" +
                          ":");
        tipoDeEnvio = Convert.ToInt32(Console.ReadLine());
        if (tipoDeEnvio < 1 || tipoDeEnvio > 3)
        {
            Console.WriteLine("Tipo de envio no valido.");
            goto inicio;
        }

        tarifaBase = tipoDeEnvio switch
        {
            1=> 2.50,
            2=> 8.50,
            3=> 13.50,
            _=> 0
        };
        if (peso > 10)
        {
            recargo = 3.50;
        }

        costoTotal = tarifaBase + recargo;
        
        Console.WriteLine($"La tarifa base es : {tarifaBase}");
        Console.WriteLine($"El recargo es de : {recargo}");
        Console.WriteLine($"El costo es de : {costoTotal}");
    }
}
 