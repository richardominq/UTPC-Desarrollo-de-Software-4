// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Console.WriteLine("     Bienvenido, Ingrese su nombre:      ");
string name = Console.ReadLine();
Console.WriteLine("     Ingrese la Cantidad de boletos:      ");
int boletos = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("         Seleccione la Categoría      \n" +
    "   1- General \n  2- Preferencial \n  3- VIP");
int tipoboleto = Convert.ToInt32(Console.ReadLine());
double precio;

if (boletos > 0 && boletos <= 10)
{
    switch (tipoboleto)
    {
        case 1:
            precio = 15.00;
            calculos(name, boletos, tipoboleto, precio);
            break;
        case 2:
            precio = 30.00;
            calculos(name, boletos, tipoboleto, precio);
            break;
        case 3:
            precio = 50.00;
            calculos(name, boletos, tipoboleto, precio);
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

static void calculos(string name, int boletos, int tipoboleto, double precio)
{
    double descuento = 0;
    double subtotal = boletos * precio;
    if (boletos > 5)
    {
        descuento = 0.12 * subtotal;
    }

    double total = subtotal - descuento; // buscar como redondear o justificar los doubvles

    string facturacont = $"Nombre: {name}\n Subtotal: {subtotal}\n" +
         $"Recargo: {descuento}\nTotal: {total}";

    Console.WriteLine(facturacont);

    //seccion de imprimir en TXT
    string rutaCarpeta = @"D:\DESARROLLO IV\Quiz #3\Programa #2 Quiz3";
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