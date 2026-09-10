// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Drawing;



Console.WriteLine("Por favpr, ingrese el monto a pagar."); //Linea Que muestra el mensaje y el usuario debe añadir el monto de pago.
int pago = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Por favpr, ingrese el tipo de cliente.");
Console.WriteLine(" 1- Regular\n 2- Frecuente \n 3-VIP");//Linea Que muestra el mensaje y el usuario debe añadir el monto de pago.
int cliente = Convert.ToInt32(Console.ReadLine());




if (cliente == 1) //Cliente regular
{
    pagar(pago, cliente); //Se renvian los datos a un método 

}
else if (cliente == 2) //Cliente FRECUENTE
{
    pagar(pago, cliente);

}
else if (cliente == 3) // cliente VIP
{
    pagar(pago, cliente);
}
else
{
    Console.WriteLine("Por favor, ingrese el tipo de cliente que es.");

}
static void pagar(int pago, int cliente)
{
    double totalpagar = 0;
    if (pago > 100 && (cliente == 2 || cliente == 3)) //En dado caso que el pago sea MAYOR O IGUAL que 100 Y se trate del CLIENTE 2 O EL CLIENTE 3 se ejecuta el IF
    {
        totalpagar = pago - (pago * 0.15);
        Console.WriteLine($"Monto a Pagar {pago}");
        Console.WriteLine($"Descuento DEL 15% Aplicado {(pago * 0.15)}");
        Console.WriteLine($"El total a pagar es de {totalpagar}");
    }
    else if (pago > 0 && cliente == 1) //Si el precio es mayor o menor que 100, Y el tipo cliente es el 1, se ejecuta. 
    {
        totalpagar = pago;
        Console.WriteLine($"Monto a Pagar {pago}");
        Console.WriteLine("No aplica ningún descuento.");
        Console.WriteLine($"El total a pagar es de {totalpagar}");

    }
    else if (pago <= 100 && pago > 0 && (cliente == 2 || cliente == 3))
    {
        totalpagar = pago;
        Console.WriteLine($"Monto a Pagar {pago}");
        Console.WriteLine("No aplica ningún descuento.");
        Console.WriteLine($"El total a pagar es de {totalpagar}");

    }
    else
    {
        Console.WriteLine("Un dato ingresado es invalido.");
    }

}