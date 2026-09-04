/* 35. Alerta de servidor
Solicite el porcentaje de CPU utilizado y el porcentaje de memoria RAM utilizada. 
Si CPU o RAM superan el 90 %, muestre “Alerta crítica”; 
si ambas permanecen por debajo del 70 %, muestre “Servidor estable”; 
en los demás casos, muestre “Revisar servidor”.

Entradas: 2. Salidas: 1.
Utilizar: if, &&, ||. */

Console.WriteLine("Ingrese el porcentaje de CPU utilizado:");
int cpu = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el porcentaje de memoria RAM utilizada:");
int ram = Convert.ToInt32(Console.ReadLine());

if (cpu > 90 || ram > 90) // Si CPU o RAM superan el 90 %, muestre “Alerta crítica”
{
    Console.WriteLine("Alerta crítica!");
}
else if (cpu < 70 && ram < 70) // si ambas permanecen por debajo del 70 %, muestre “Servidor estable”
{
    Console.WriteLine("Servidor estable");
}
else // en los demás casos, muestre “Revisar servidor”.
{
    Console.WriteLine("Revisar servidor");
}


