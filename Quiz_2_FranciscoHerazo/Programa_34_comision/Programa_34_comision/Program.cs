Console.Write("Ingresa el total de ventas: ");
double ventas = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el tipo de vendedor \n 1 | Junior\n 2 = Senior\n 3 = Supervisor ");
int tipo = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingresa la cantidad de clientes atendidos: ");
int clientes = Convert.ToInt32(Console.ReadLine());

double porcentaje = tipo switch
{
    1 => 0.05,
    2 => 0.10,
    3 => 0.15,
    _ => 0.0
};

double comision = ventas * porcentaje;
double incentivo = 0;

if (ventas > 5000 && clientes > 20)
{
    incentivo = 200;
}

double totalConIncentivo = comision + incentivo;

Console.WriteLine("Porcentaje aplicado: " + (porcentaje * 100) + "%");
Console.WriteLine("Comision: " + comision);
Console.WriteLine("Total con incentivo: " + totalConIncentivo);