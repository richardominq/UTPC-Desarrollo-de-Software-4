class Program
{
    static void Main(string[] args)
    {
        double temp;
        short elec;

        Console.WriteLine("ingresa la temperatura en grados centigrados");
        temp = double.Parse(Console.ReadLine());

        Console.WriteLine("si es otra medida elije: (solo numeros)");
        Console.WriteLine("1. Celcius");
        Console.WriteLine("2. Fareheit");
        Console.WriteLine("3. Kelvin");
        elec = short.Parse(Console.ReadLine());

        switch (elec){
            case 1:
                if (temp > -273.15) 
                {
                    if (temp < 15)
                    {
                        Console.WriteLine("la temperatura es fria");
                    }else if (temp>=15 && temp <=30)
                    {
                        Console.WriteLine("la temperatura es agradable");
                    }
                    else
                    {
                        Console.WriteLine("la temperatura es caliente");
                    }
                }else
                {
                    Console.WriteLine("la temperatura es demasiado baja y no existe");
                }
                return;
            case 2:
                temp = (temp*(9/5))+32;
                if (temp > -459.67)
                {
                    if (temp < 59)
                    {
                        Console.WriteLine("la temperatura es fria");
                    }
                    else if (temp >= 59 && temp <= 86)
                    {
                        Console.WriteLine("la temperatura es agradable");
                    }
                    else
                    {
                        Console.WriteLine("la temperatura es caliente");
                    }
                }
                else
                {
                    Console.WriteLine("la temperatura es demasiado baja y no existe");
                }
                return;
            case 3:
                temp = temp + 273.15;
                if (temp > 0)
                {
                    if (temp < 288.15)
                    {
                        Console.WriteLine("la temperatura es fria");
                    }
                    else if (temp >= 288.15 && temp <= 303.15)
                    {
                        Console.WriteLine("la temperatura es agradable");
                    }
                    else
                    {
                        Console.WriteLine("la temperatura es caliente");
                    }
                }
                else
                {
                    Console.WriteLine("la temperatura es demasiado baja y no existe");
                }
                return;
            
            default:
                return;
        }
    }
}