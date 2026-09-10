Console.WriteLine($"Sistema de cobro para una tienda");
double compra;
int cliente;
Console.WriteLine($"Ingrese el monto de la compra realizada");
compra = double.Parse(Console.ReadLine());//Instrucción "Console.ReadLine" para recibir datos del usuario.
Console.WriteLine($"Ingrese el tipo de cliente: \n 1:Cliente Regular. \n 2:Cliente Frecuente. \n 3:Cliente VIP.");
cliente = int.Parse(Console.ReadLine());//Instrucción "Console.Readline" para recibir datos del usuario.
//Calculos
double impuesto = compra * 0.07;
double descuento = compra * 0.15;
double total1 = compra + impuesto;
double total;

//cliente regular  
if (cliente == 1)
{
    Console.WriteLine($"Cliente Regular, no obtiene descuento");
    Console.WriteLine($"Total a pagar: {total1:F2}");
}
//cliente frecuente
else if (cliente == 2)
{
    if (compra > 100)
    {
        descuento = compra * 0.15;
        total = compra + impuesto - descuento;
        Console.WriteLine($"Cliente frecuente. \nSu descuento es del 15%");
        Console.WriteLine($"Monto total: {total1:F2}\nDescuento:{descuento:F2}\nTotal a Pagar: {total:F2}");
    }
    else
    {
        Console.WriteLine($"Cliente Frecuente.");
        Console.WriteLine($"Monto insuficiente para recibir descuento.");
        Console.WriteLine($"Total a pagar: {total1:F2}");
    }
}
//Cliente VIP
else if (cliente == 3)
{
    if (compra > 100)
    {
        descuento = compra * 0.15;
        total = compra + impuesto - descuento;
        Console.WriteLine($"Cliente VIP. \nSu descuento es del 15%");
        Console.WriteLine($"Monto total: {total1:F2}\nDescuento:{descuento:F2}\nTotal a Pagar: {total:F2}");
    }
    else
    {
        Console.WriteLine($"Cliente VIP.");
        Console.WriteLine($"Monto insuficiente para recibir descuento.");
        Console.WriteLine($"Total a pagar: {total1:F2}");
    }
}
else
{
    Console.WriteLine($"Tpo de cliente invalido");
}
