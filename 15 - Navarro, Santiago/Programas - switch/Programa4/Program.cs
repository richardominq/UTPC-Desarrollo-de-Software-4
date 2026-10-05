/*Programa 4: Desarrolle un programa que permita determinar cuál es el número mayor entre varios valores ingresados 
 * por el usuario. Solicite cuatro números diferentes y almacene cada uno en una variable. 
 * Utilizando únicamente sentencias if y el operador lógico and, compare los cuatro valores para determinar 
 * cuál es mayor que los otros tres. Al finalizar, el programa deberá mostrar el mensaje “El número mayor es:” 
 * seguido del valor correspondiente.No utilice funciones como max() ni estructuras repetitivas.
*/


using System;

namespace Programa4
{
    class Program
    {
        static void Main(string[] args)
        {
            double mayor = 0;
            string ubicacion = "";

            Console.Write("Ingrese el número 1: ");
            string dato1 = Console.ReadLine();
            if (!double.TryParse(dato1, out double num1))
            {
                Console.WriteLine("Error: valor no válido, debe ingresar un número");
                return;
            }

            Console.Write("Ingrese el número 2: ");
            string dato2 = Console.ReadLine();
            if (!double.TryParse(dato2, out double num2))
            {
                Console.WriteLine("Error: valor no válido, debe ingresar un número");
                return;
            }

            Console.Write("Ingrese el número 3: ");
            string dato3 = Console.ReadLine();
            if (!double.TryParse(dato3, out double num3))
            {
                Console.WriteLine("Error: valor no válido, debe ingresar un número");
                return;
            }

            Console.Write("Ingrese el número 4: ");
            string dato4 = Console.ReadLine();
            if (!double.TryParse(dato4, out double num4))
            {
                Console.WriteLine("Error: valor no válido, debe ingresar un número");
                return;
            }

            // Comparación por switch anidados (cada nivel valida una condición)
            switch (num1 > num2)
            {
                case true:
                    switch (num1 > num3)
                    {
                        case true:
                            switch (num1 > num4)
                            {
                                case true:
                                    mayor = num1;
                                    ubicacion = "el primer dato";
                                    break;
                            }
                            break;
                    }
                    break;
            }

            switch (num2 > num1)
            {
                case true:
                    switch (num2 > num3)
                    {
                        case true:
                            switch (num2 > num4)
                            {
                                case true:
                                    mayor = num2;
                                    ubicacion = "el segundo dato";
                                    break;
                            }
                            break;
                    }
                    break;
            }

            switch (num3 > num1)
            {
                case true:
                    switch (num3 > num2)
                    {
                        case true:
                            switch (num3 > num4)
                            {
                                case true:
                                    mayor = num3;
                                    ubicacion = "el tercer dato";
                                    break;
                            }
                            break;
                    }
                    break;
            }

            switch (num4 > num1)
            {
                case true:
                    switch (num4 > num2)
                    {
                        case true:
                            switch (num4 > num3)
                            {
                                case true:
                                    mayor = num4;
                                    ubicacion = "el cuarto dato";
                                    break;
                            }
                            break;
                    }
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("El número mayor es: " + mayor);

            switch (ubicacion == "")
            {
                case true:
                    Console.WriteLine("No se pudo detectar la posicion");
                    break;
                case false:
                    Console.WriteLine("Corresponde a " + ubicacion + ".");
                    break;
            }
        }
    }
}