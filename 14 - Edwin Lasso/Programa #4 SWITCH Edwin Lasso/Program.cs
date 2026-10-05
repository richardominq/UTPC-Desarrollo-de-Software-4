
// See https://aka.ms/new-console-template for more informatio// See https://aka.ms/new-console-template for more information

Console.WriteLine("Se le van a ser solicitados 4 números que debera ingresar."); //
Console.WriteLine("Ingrese el primer número:"); // Se
int num1 = Convert.ToInt32(Console.ReadLine()); // Se recibe el primer número

Console.WriteLine("Ingrese el segundo número:");
int num2 = Convert.ToInt32(Console.ReadLine()); // Se recibe el segundo número

Console.WriteLine("Ingrese el tercer número:");
int num3 = Convert.ToInt32(Console.ReadLine()); // sE recibe el tercer número

Console.WriteLine("Ingrese el cuarto número:");
int num4 = Convert.ToInt32(Console.ReadLine()); // Se recibe el cuarto número

int mayor;

switch (0)
{
    case 0 when num1 >= num2 && num1 >= num3 && num1 >= num4: // Se compara el primer número con los demás
        mayor = num1;
        break;

    case 0 when num2 >= num1 && num2 >= num3 && num2 >= num4: // Se compara el segundo número con los demás
        mayor = num2;
        break;

    case 0 when num3 >= num1 && num3 >= num2 && num3 >= num4: // Se compara el tercer número con los demás
        mayor = num3;
        break;

    default:
        mayor = num4;
        break;
}

Console.WriteLine($"El número mayor es: {mayor}");
