using System;
class Programa1
{
    static void Main()
    {
        //Variables a utilizar
        double compra, descuento, monto_final, impuesto;
        int tipo_cliente;

        //solicitar el monto de la compra
        Console.WriteLine($"Ingresa el monto de la compra: ");
        compra = double.Parse(Console.ReadLine());

        //ver el tipo de cliente
        Console.WriteLine($"\nTipo de cliente:");
        Console.WriteLine($"1= Regular");
        Console.WriteLine($"2= Frecuente");
        Console.WriteLine($"3= VIP");


        //Solicitar el tipo de cliente
        Console.WriteLine($"Seleccione el tipo de cliente: ");
        tipo_cliente= int.Parse(Console.ReadLine());

        //descuento inicialzado en 0
        descuento = 0;

        /*verificar las condiciones para aplicar el descuento
         compra debe ser mayor a 100 y el cliente Frecuente o VIP*/
        if(compra>100 &&(tipo_cliente==2 || tipo_cliente == 3))
        {
            //calculo de el 15% de descuento
            descuento = compra * 0.15;
        }

        //se resta el descuento al monto final
        monto_final = compra - descuento;
        //sumamos el impuesto
        impuesto = monto_final * 0.07;
        //costo final
        monto_final = monto_final + impuesto;

        //identificamos el tipo de cliente
        if (tipo_cliente == 1)
        {
            Console.WriteLine($"Tipo de cliente: Regular");
        }
        else if (tipo_cliente == 2)
        {
            Console.WriteLine($"Tipo de cliente: Frecuente");
        }
        else if (tipo_cliente == 3)
        {
            Console.WriteLine($"Tipo de cliente: VIP");
        }

        //Mostramos los resultados
        Console.WriteLine($"Descuento aplicado: ${descuento:F2}");
        Console.WriteLine($"Total a pagar: ${monto_final:F2}");
    }

}