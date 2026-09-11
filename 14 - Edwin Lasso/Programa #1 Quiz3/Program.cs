Console.WriteLine("Bienvenido, Ingrese Sú Nombre por Favor.");
string name = Console.ReadLine();
Console.WriteLine("Ingrese la Cantidad de Kv consumidos");
int kv = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Seleccione en tipo de cliente\n" +
    "1- Residencial \n2-Comercial \n3- Industrial");
int clientype = Convert.ToInt32(Console.ReadLine());
double tarifa;

if (kv > 0 && (clientype == 1 || clientype == 2 || clientype == 3))
{
    switch (clientype)
    {
        case 1:
            tarifa = 0.15;
            Console.WriteLine();
            calculos(name, kv, clientype, tarifa);
            break;
        case 2:
            tarifa = 0.30;
            Console.WriteLine();
            calculos(name, kv, clientype, tarifa);
            break;
        case 3:
            tarifa = 0.22;
            Console.WriteLine();
            calculos(name, kv, clientype, tarifa);
            break;
        default:
            Console.WriteLine("Tipo de Cliente Invalido");
            break;
    }
}
else
{
    Console.WriteLine("Datos Ingresados Invalidos.");
}

static void calculos(string name, int kv, int clientype, double tarifa)
{
    double subtotal = kv * tarifa;
    double recargo = subtotal * 0.07;
    double total = recargo + subtotal; // buscar como redondear o justificar los doubvles
    string facturacont = $"Nombre: {name}\nSubtotal: {subtotal}\n" +
         $"Recargo: {recargo}\nTotal: {total}";

    Console.WriteLine(facturacont);

    //seccion de imprimir en TXT
    string rutaCarpeta = @"D:\DESARROLLO IV\Quiz #3\Programa #1 Quiz3";
    string nombreArchivo = "Factura_Electrica.txt";

    // Combinamos la carpeta y el archivo de forma segura
    string rutaCompleta = Path.Combine(rutaCarpeta, nombreArchivo);

    if (!Directory.Exists(rutaCarpeta))
    {
        Directory.CreateDirectory(rutaCarpeta);
    }
    using (StreamWriter escritor = new StreamWriter(rutaCompleta))
    {

        escritor.WriteLine(facturacont);
    }

    Console.WriteLine("Factura Electronica Realizada.");
}