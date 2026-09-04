Console.Write("Ingrese el primer numero: ");
double numero1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el segundo numero: ");
double numero2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("1 = Sumar");
Console.WriteLine("2 = Restar");
Console.WriteLine("3 = Multiplicar");
Console.WriteLine("4 = Dividir");
Console.Write("Seleccione una opcion: ");
int opcion = Convert.ToInt32(Console.ReadLine());

double resultado = 0;
bool operacionValida = true;

switch (opcion)
{
    case 1:
        resultado = numero1 + numero2;
        break;
    case 2:
        resultado = numero1 - numero2;
        break;
    case 3:
        resultado = numero1 * numero2;
        break;
    case 4:
        if (numero2 != 0)
        {
            resultado = numero1 / numero2;
        }
        else
        {
            operacionValida = false;
            Console.WriteLine("Error: no se puede dividir entre cero.");
        }
        break;
    default:
        operacionValida = false;
        Console.WriteLine("Opcion invalida.");
        break;
}

if (operacionValida)
{
    Console.WriteLine("El resultado es: " + resultado);
}
