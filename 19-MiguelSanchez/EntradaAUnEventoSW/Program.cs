/*
 * Entrada a un evento: Un sistema necesita verificar si una persona cumple las condiciones necesarias para ingresar a un evento.
 * Solicite la edad, la cantidad de boletos disponibles y el tipo de entrada (1 = General, 2 = VIP, 3 = Invitado).
 * Si la persona tiene 18 años o más y posee al menos un boleto y seleccionó como tipo de entrada la opción 1, 2 o 3, muestre
 *“Entrada autorizada” junto con el tipo seleccionado.
 * De lo contrario, muestre “Entrada rechazada” indicando que no cumple con las condiciones establecidas.
 */

class EntradaAUnEventosSW
{
    public static void Main(string[] args)
    {
        int edad;
        int entrada;
        int boletos;

        Console.WriteLine("Ingrese su edad:");
        edad = Convert.ToInt32(Console.ReadLine());

        if (edad < 18)
        {
            Console.WriteLine("Es menor de edad, no puede entrar");
        }
        else
        {
            Console.WriteLine("Ingres la cantidad de boletos:");
            entrada = Convert.ToInt32(Console.ReadLine());
            
            if (entrada >= 1)
            {
                Console.WriteLine("Que tipo de entrada tiene:");
                Console.WriteLine("1-General");
                Console.WriteLine("2-VIP");
                Console.WriteLine("3-Invitado");
                boletos = Convert.ToInt32(Console.ReadLine());
                
                switch (boletos)
                {
                    case 1:
                        Console.WriteLine("Entrada autorizada.");
                        Console.WriteLine("Tipo de entrada: General");
                        break;

                    case 2:
                        Console.WriteLine("Entrada autorizada.");
                        Console.WriteLine("Tipo de entrada: VIP");
                        break;

                    case 3:
                        Console.WriteLine("Entrada autorizada.");
                        Console.WriteLine("Tipo de entrada: Invitado");
                        break;

                    default:
                        Console.WriteLine("Entrada rechazada.");
                        Console.WriteLine("Tipo de entrada no valido.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("No cumple los requisitos\nEntrada rechazada");
            }

        }
    }
}