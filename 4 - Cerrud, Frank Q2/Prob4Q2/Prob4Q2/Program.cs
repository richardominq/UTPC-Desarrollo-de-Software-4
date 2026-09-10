/* 4. Acceso a una plataforma
Solicite la edad, el tipo de usuario (1 = Estudiante, 2 = Profesor, 3 = Administrador)
y un valor que indique si posee credencial válida (1 = Sí, 2 = No). Permita el acceso si la 
persona tiene 18 años o más y posee una credencial válida. Utilice switch expression para obtener 
el nombre del tipo de usuario. Muestre el tipo de usuario y si el acceso fue autorizado o rechazado.

Entradas: 3. Salidas: 2.
Utilizar: if, &&, switch expression.
*/

Console.WriteLine("Bienvenido al sistema de acceso");

Console.WriteLine("Ingrese su edad:");
int edad = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el tipo de usuario (1 = Estudiante, 2 = Profesor, 3 = Administrador):");
int tipo = int.Parse(Console.ReadLine());

Console.WriteLine("¿Posee credencial válida? (1 = Sí, 2 = No):");
int credencial = int.Parse(Console.ReadLine());

//  switch expression 
string tipoUsuario = tipo switch
{
    1 => "Estudiante",
    2 => "Profesor",
    3 => "Administrador",
    _ => "Desconocido"
};

Console.WriteLine("El tipo de usuario es: " + tipoUsuario);


if (edad >= 18 && credencial == 1)
{
    Console.WriteLine("El acceso fue: Autorizado");
}
else
{
    Console.WriteLine("El acceso fue: Rechazado");
}

