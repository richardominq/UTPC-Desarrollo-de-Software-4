Console.WriteLine("--- Mayor de cuatro numeros ---");

Console.WriteLine("\nIngrese el numero 1");
int numero1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nIngrese el numero 2");
int numero2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nIngrese el numero 3");
int numero3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nIngrese el numero 4");
int numero4 = Convert.ToInt32(Console.ReadLine());

int mayor;
int posicionMayor;

if (numero1 > numero2 && numero1 > numero3 && numero1 > numero4)
{
    mayor = numero1;
    posicionMayor = 1;
}
else if (numero2 > numero1 && numero2 > numero3 && numero2 > numero4)
{
    mayor = numero2;
    posicionMayor = 2;
}
else if (numero3 > numero1 && numero3 > numero2 && numero3 > numero4)
{
    mayor = numero3;
    posicionMayor = 3;
}
else
{
    mayor = numero4;
    posicionMayor = 4;
}

Console.WriteLine("\nEl numero mayor es: " + mayor);

switch (posicionMayor)
{
    case 1:
        Console.WriteLine("El numero mayor corresponde al numero 1 ingresado.");
        break;
    case 2:
        Console.WriteLine("El numero mayor corresponde al numero 2 ingresado.");
        break;
    case 3:
        Console.WriteLine("El numero mayor corresponde al numero 3 ingresado.");
        break;
    case 4:
        Console.WriteLine("El numero mayor corresponde al numero 4 ingresado.");
        break;
}