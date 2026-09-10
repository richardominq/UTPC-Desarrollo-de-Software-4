namespace Entrada_al_cine__Programa1Adalberto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // primero pedimos la edad del usuario para determinar si puede entrar al cine o no
            Console.WriteLine($" Bienvendido al cine porfavor ingrese su edad:");
            int edad = Convert.ToInt32(Console.ReadLine());
            if(edad > 0)
            {
                Console.WriteLine($"Ingrese el tipo de pelicula que desea ver: \n 1 = Todo público \n 2 = Mayores de 13 \n 3 = Mayores de 18");
                int tipoPelicula = Convert.ToInt32(Console.ReadLine());

                switch (tipoPelicula)
                {
                    case 1:
                        Console.WriteLine($"Puede entrar a la pelicula de todo público");
                        break;
                    case 2:
                        if (edad >= 13)
                        {
                            Console.WriteLine($"Puede entrar a la pelicula de mayores de 13");
                        }
                        else
                        {
                            Console.WriteLine($"No puede entrar a la pelicula de mayores de 13");
                        }
                        break;
                        // 
                    case 3:
                        if (edad >= 18)
                        {
                            Console.WriteLine($"Puede entrar a la pelicula de mayores de 18");
                        }
                        else
                        {
                            Console.WriteLine($"No puede entrar a la pelicula de mayores de 18");
                        }
                        break;
                    default:
                        Console.WriteLine($"El tipo de pelicula ingresado no es valido");
                        break;
                }
            }
            else
            {
                Console.WriteLine($"La edad ingresada no es valida");
            }
        }
    }
}
