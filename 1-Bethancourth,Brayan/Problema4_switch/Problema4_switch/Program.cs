Console.WriteLine($"Programa para determinar número mayor ");

//variables
int numero1;
int numero2;
int numero3;
int numero4;

//solicitar datos al usuario
Console.WriteLine($"Ingrese el primer número: ");
numero1=int.Parse(Console.ReadLine());

Console.WriteLine($"Ingrese el segundo número: ");
numero2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Ingrese el tercer número: ");
numero3 = int.Parse(Console.ReadLine());

Console.WriteLine($"Ingrese el cuarto número: ");
numero4 = int.Parse(Console.ReadLine());

//numero mayor 
switch (numero1 > numero2 && numero1 > numero3 && numero1 > numero4)
{
    case true:
        Console.WriteLine($"El número mayor es: {numero1}");
        break;

    case false:
        switch (numero2 > numero1 && numero2 > numero3 && numero2 > numero4)
        {
            case true:
                Console.WriteLine($"El número mayor es: {numero2}");
                break;
            case false:
                switch (numero3 > numero1 && numero3 > numero2 && numero3 > numero4)
                {
                    case true:
                        Console.WriteLine($"El número mayor es: {numero3}");
                        break;

                    case false:
                        Console.WriteLine($"El número mayor es: {numero4}");
                        break;
                }
                break;
        }
        break;
}
