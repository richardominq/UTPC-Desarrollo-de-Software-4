Console.WriteLine($"Programa para determinar el número mayor");

// Declaración de las variables
int numero1;
int numero2;
int numero3;
int numero4;

// Solicitar los cuatro números
Console.WriteLine($"Ingrese el primer número:");
numero1 = int.Parse(Console.ReadLine());

Console.WriteLine($"Ingrese el segundo número:");
numero2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Ingrese el tercer número:");
numero3 = int.Parse(Console.ReadLine());

Console.WriteLine($"Ingrese el cuarto número:");
numero4 = int.Parse(Console.ReadLine());

// Comparar los cuatro números
if (numero1 > numero2 && numero1 > numero3 && numero1 > numero4)
{
    Console.WriteLine($"El número mayor es: {numero1}");
}
else if (numero2 > numero1 && numero2 > numero3 && numero2 > numero4)
{
    Console.WriteLine($"El número mayor es: {numero2}");
}
else if (numero3 > numero1 && numero3 > numero2 && numero3 > numero4)
{
    Console.WriteLine($"El número mayor es: {numero3}");
}
else
{
    Console.WriteLine($"El número mayor es: {numero4}");
}