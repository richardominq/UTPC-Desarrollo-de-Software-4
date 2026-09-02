Console.WriteLine("Bienvenido al sistema");

Console.WriteLine("Ingrese el primer número:");
int n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el segundo número:");
int n2 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el tercer número:");
int n3 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el cuarto número:");
int n4 = int.Parse(Console.ReadLine());

int mayor = 0;
int posicion = 0;

if (n1 > n2 && n1 > n3 && n1 > n4)
{
    mayor = n1;
    posicion = 1;
}
else if (n2 > n1 && n2 > n3 && n2 > n4)
{
    mayor = n2;
    posicion = 2;
}
else if (n3 > n1 && n3 > n2 && n3 > n4)
{
    mayor = n3;
    posicion = 3;
}
else if (n4 > n1 && n4 > n2 && n4 > n3)
{
    mayor = n4;
    posicion = 4;
}

Console.WriteLine("El número mayor es: " + mayor);

switch (posicion)
{
    case 1:
        Console.WriteLine("El número mayor corresponde al número 1 ingresado.");
        break;
    case 2:
        Console.WriteLine("El número mayor corresponde al número 2 ingresado.");
        break;
    case 3:
        Console.WriteLine("El número mayor corresponde al número 3 ingresado.");
        break;
    case 4:
        Console.WriteLine("El número mayor corresponde al número 4 ingresado.");
        break;
    default:
        Console.WriteLine("No se determinó una única posición mayor.");
        break;
}