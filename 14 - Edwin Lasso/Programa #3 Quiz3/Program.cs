
Console.WriteLine("Bienvenido, Ingrese Sú Número de Placa.");
string name = Console.ReadLine();
Console.WriteLine("Ingrese la Cantidad de HORAS estacionado");
int horas = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Seleccione en tipo de Vehículo\n" +
    "1- Moto \n2- Auto \n3- Camnioneta");
int clientype = Convert.ToInt32(Console.ReadLine());
double tarifa;

if (horas > 0 && horas < 24)
{
    switch (clientype)
    {
        case 1:
            tarifa = 0.75;
            calculos(name, horas, clientype, tarifa);
            break;
        case 2:
            tarifa = 1.50;
            calculos(name, horas, clientype, tarifa);
            break;
        case 3:
            tarifa = 2.25;
            calculos(name, horas, clientype, tarifa);
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

static void calculos(string name, int horas, int clientype, double tarifa)
{
    double descuento = 0;
    double subtotal = horas * tarifa;
    if (horas > 8)
    {
        descuento = 0.08 * subtotal;
    }
    double total = descuento + subtotal; // buscar como redondear o justificar los doubvles

    string facturacont = $"Nombre: {name}\n Subtotal: {subtotal}\n" +
         $"Recargo: {descuento}\nTotal: {total}";

    Console.WriteLine(facturacont);

    //seccion de imprimir en TXT
    string rutaCarpeta = @"C:\\DESARROLLO 4 EDWIN LASSO\\ConsoleApp1";
    string nombreArchivo = "Reporte_Estacionamiento.txt";

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
