Console.WriteLine("Sistema de Control de Envíos e Impuestos Logísticos");


Console.WriteLine("Ingresa la cantidad de productos:");
int cantproducto = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el peso total en Kilogramos (kg):");
double pesototal = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la distancia de envío en Kilometros (km):");
double distanciakm = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la zona de destino (1, 2 o 3):");
int zonadestino = int.Parse(Console.ReadLine());

double impuestozona = 0;
double costobaseenvio = pesototal * 3.5;
double recargodistancia = distanciakm * 0.15;
double costropreliminar = costobaseenvio + recargodistancia + impuestozona;
double tarifaespecial = 0;
if (pesototal > 50 && distanciakm > 1000)
{
    Console.WriteLine("Carga pesada y larga distancia detectadas, se aplicará una tarifa especial.");
    tarifaespecial = 0.15;
}
else
{
    Console.WriteLine("Carga y distancia estables, no se aplica tarifa especial de 15%.");
}

if (cantproducto < 1 || pesototal < 1)
{
    Console.WriteLine("Envío rechazado, no cumple con los requisitos mínimos de envío.");
    return;
}

int autorizacion;
if (costobaseenvio >= 50)
{
    Console.WriteLine("Costo base de envío mayor a 50$, se necesita autorización (1 = Si, 2 = No)");
    autorizacion = int.Parse(Console.ReadLine());
    if (autorizacion == 1)
    {
        Console.WriteLine("Autorización Aprobada.");
    }
    else if (autorizacion == 2)
    {
        Console.WriteLine("Autorización denegada, se cancela el envío.");
        return;
    }
}

if (zonadestino == 1)
{
    impuestozona = 0.02;
}
else if (zonadestino == 2)
{
    impuestozona = 0.04;
}
else if (zonadestino == 3)
{
    impuestozona = 0.06;
}


double costofinal = costropreliminar + tarifaespecial ;

Console.WriteLine("Costo base de envío: " + costobaseenvio);
Console.WriteLine("Costo preliminar calculado: " + costropreliminar);
Console.WriteLine("Monto de impuesto de la zona elegida: " + impuestozona * 100);
double cargoimpuesto = impuestozona * 100;
Console.WriteLine("Costo final a pagar: " + costofinal + cargoimpuesto);


