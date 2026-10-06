
class Progama1
{
    static void Main()
    {
        string nombre,tipoclienteTexto;
        int kilovatios, tipo_cliente;
        double subtotal = 0, total_pagar = 0;

        Console.WriteLine($"Ingrese el nombre del cliente: ");
        nombre = Console.ReadLine();

        Console.WriteLine($"Ingrese la cantidad de Kilovatios consumidos: ");
        kilovatios = int.Parse(Console.ReadLine());


        if (kilovatios <= 0)
        {
            Console.WriteLine($"La cantidad de Kilvatios debe ser mayor a cero!");
            return;
        }
        else
        {
        }

        Console.WriteLine($"Ingrese el tipo de cliente: ");
        Console.WriteLine($"1= Residencial");
        Console.WriteLine($"2= Comercial");
        Console.WriteLine($"3= Industrial");
        tipo_cliente = int.Parse(Console.ReadLine());
        switch (tipo_cliente)
        {
            case 1:
                tipoclienteTexto = "Residencial";
                subtotal = kilovatios * 0.15;
                break;

            case 2:
                tipoclienteTexto = "Comercial";
                subtotal = kilovatios * 0.22;
                break;
            case 3:
                tipoclienteTexto = "Industrial";
                subtotal = kilovatios * 0.30;
                break;

            default:
                Console.WriteLine($"Opción invalida");
                return;
        }


        total_pagar = subtotal + (subtotal * 0.07);

        Console.WriteLine($"Subtotl: ${subtotal:F2}");
        Console.WriteLine($"Total a pagar: ${total_pagar:F2}");

        string datos = "nombre del cliente: " + nombre + "\n" +
        "consumo: " + kilovatios + " kv" + "\n" +
        "Tipo de cliente: " + tipoclienteTexto + "\n" +
        "Resultados: " + "\n" +
        "Subtotal: " + subtotal.ToString("F2") + "\n" +
        "Total a pagar: " + total_pagar.ToString("F2") + "\n" +
        "Fecha y hora: " + DateTime.Now.ToString("dd/MM/yyyy\n" +
        "HH:mm:ss");

        File.WriteAllText("factura_elecrica.txt", datos);
    }
}