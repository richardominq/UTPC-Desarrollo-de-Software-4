/*Programa 4: Desarrolle un programa que permita determinar cuál es el número mayor entre varios valores 
 * ingresados por el usuario. Solicite cuatro números diferentes y almacene cada uno en una variable. 
 * Utilizando únicamente sentencias if y el operador lógico and, compare los cuatro valores 
 * para determinar cuál es mayor que los otros tres. Al finalizar, el programa deberá mostrar el 
 * mensaje “El número mayor es:” seguido del valor correspondiente. 
 * No utilice funciones como max() ni estructuras repetitivas.
*/



using System;
using System.Text;
namespace Programa1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el número 1: "); //pedir el valor 1
            string dato1 = Console.ReadLine();

            if (!double.TryParse(dato1, out double num1))
            {
                Console.WriteLine("Error: valor no valido. Debe ingresar un número.");
                return;
            }

            Console.Write("Ingrese el número 2: ");//pedir el valor 2
            string dato2 = Console.ReadLine();

            if (!double.TryParse(dato2, out double num2))
            {
                Console.WriteLine("Error: valor no valido. Debe ingresar un número.");
                return;
            }

            Console.Write("Ingrese el número 3: ");//pedir el valor 3
            string dato3 = Console.ReadLine();

            if (!double.TryParse(dato3, out double num3))
            {
                Console.WriteLine("Error: valor no valido. Debe ingresar un número.");
                return;
            }

            Console.Write("Ingrese el número 4: ");//pedir el valor 4
            string dato4 = Console.ReadLine();

            if (!double.TryParse(dato4, out double num4))
            {
                Console.WriteLine("Error: valor no valido. Debe ingresar un número.");
                return;
            }

            double mayor = 0;

            if (num1 > num2 && num1 > num3 && num1 > num4)
            {
                mayor = num1;
            }

            if (num2 > num1 && num2 > num3 && num2 > num4)
            {
                mayor = num2;
            }

            if (num3 > num1 && num3 > num2 && num3 > num4)
            {
                mayor = num3;
            }

            if (num4 > num1 && num4 > num2 && num4 > num3)
            {
                mayor = num4;
            }

            Console.WriteLine("El número mayor es: " + mayor);
        }
    }
}