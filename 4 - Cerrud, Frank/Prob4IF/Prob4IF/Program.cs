Console.WriteLine("Bienvenido Ll asistema");

Console.WriteLine("Ingrese el primer número:");
int n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el segundo número:");
int n2 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el tercer número:");
int n3 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el cuarto número:");
int n4 = int.Parse(Console.ReadLine());

int mayor = 0;

if (n1 > n2 && n1 > n3 && n1 > n4)
{
    mayor = n1;
    Console.WriteLine("El número mayor es: " + mayor);
    Console.WriteLine("El número mayor corresponde al número 1 ingresado.");
}
else if (n2 > n1 && n2 > n3 && n2 > n4)
{
    mayor = n2;
    Console.WriteLine("El número mayor es: " + mayor);
    Console.WriteLine("El número mayor corresponde al número 2 ingresado.");
}
else if (n3 > n1 && n3 > n2 && n3 > n4)
{
    mayor = n3;
    Console.WriteLine("El número mayor es: " + mayor);
    Console.WriteLine("El número mayor corresponde al número 3 ingresado.");
}
else if (n4 > n1 && n4 > n2 && n4 > n3)
{
    mayor = n4;
    Console.WriteLine("El número mayor es: " + mayor);
    Console.WriteLine("El número mayor corresponde al número 4 ingresado.");
}
else
{
    Console.WriteLine("Hay números iguales o no se pudo determinar un único mayor.");
}