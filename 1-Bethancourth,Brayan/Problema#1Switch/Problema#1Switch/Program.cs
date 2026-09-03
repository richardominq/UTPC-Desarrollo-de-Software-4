Console.WriteLine($"Sitema Tienda");
//variables para definir los datos que ingresara el cliente
double compra;
int cliente;
Console.WriteLine($"Ingrese el monto de la compra realizada");
compra = double.Parse(Console.ReadLine());//Instrucción "Console.ReadLine" para recibir datos del usuario.
Console.WriteLine($"Ingrese el tipo de cliente: \n 1:Cliente Regular. \n 2:Cliente Frecuente. \n 3:Cliente VIP.");
cliente= int.Parse(Console.ReadLine());//Instrucción "Console.Readline" para recibir datos del usuario.
//Calculos
double impuesto = compra * 0.07;
double descuento = compra * 0.15;
double total1 = compra + impuesto;
double total;

//Menú principal para Seleccionar el tipo de cliente
switch (cliente)
{
    case 1://cliente regular
        Console.WriteLine($"Cliente regular. \nNo cuenta con el beneficio de descuento.");
        Console.WriteLine($"Total a pagar: {total1:F2}");
        break;

    case 2://Cliente Frecuente
        switch (compra > 100)//Validacion
        {
            //Definir si el cliente tiene derecho a un descuento o no.
            case true:
                descuento = compra * 0.15;
                total = compra + impuesto - descuento;
                Console.WriteLine($"Cliente frecuente. \nSu descuento es del 15%");
                Console.WriteLine($"Monto total: {total1:F2}\nDescuento:{descuento:F2}\nTotal a Pagar: {total:F2}");
                break;

            case false:
                descuento = 0;
                Console.WriteLine($"Total a pagar: {total1:F2}");
                break;
        }
        break;

    case 3://cliente VIP
        switch (compra > 100)//Validacion 
        {
            //Definir si el cliente tiene derecho a un descuento o no.
            case true:
                descuento = compra * 0.15;
                total = compra + impuesto - descuento;
                Console.WriteLine($"Cliente frecuente. \nSu descuento es del 15%");
                Console.WriteLine($"Monto total: {total1:F2}\nDescuento:{descuento:F2}\nTotal a Pagar: {total:F2}");
                break;

            case false:
                descuento = 0;
               
                Console.WriteLine($"Total a pagar: {total1:F2}");
                break;
        }

        break;

    default:
        Console.WriteLine($"Tipo de cliente no valido");
        break;
}