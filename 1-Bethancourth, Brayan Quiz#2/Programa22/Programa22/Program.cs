using System;
class Programa22
{
    static void Main()
    {
        //variables a utilizar
        int tipo_menu, cantidad_personas;
        double subtotal, total;
        double precio = 0;
        double descuento = 0;

        //muestra el tipo de Menu
        Console.WriteLine($"Tipo de menu");
        Console.WriteLine($"1 = Desayuno");
        Console.WriteLine($"2 = Almuerzo");
        Console.WriteLine($"3 = Cena");

        //Solicitar que tipo de menu desea
        Console.WriteLine($"Ingrese el tipo de menu: ");
        tipo_menu = int.Parse(Console.ReadLine());

        //cantidad de personas
        Console.WriteLine($"Ingrese la cantidad de personas: ");
        cantidad_personas = int.Parse(Console.ReadLine());

        //precios del menu
        switch (tipo_menu)
        {
            case 1:
                precio = 8.00;
                break;

            case 2:
                precio = 12.00;
                break;

            case 3:
                precio = 15.00;
                break;

            default:
                Console.WriteLine($"Tipo de menu invalido!");
                return;
        }
        //calcua el subtotal
        subtotal = precio * cantidad_personas;

        /*validacion de las condiciones para obtener un 10% de descuento,
         deben ser mas de 5 personas para que el descuento se haga efectivo*/
        if (cantidad_personas >= 5)
        {
            descuento = subtotal * 0.10;
        }
        total = subtotal - descuento;

        //resultados 
        Console.WriteLine($"Subtoal: ${subtotal:F2}");
        Console.WriteLine($"Total a pagar: ${total:F2}");       
    }
}