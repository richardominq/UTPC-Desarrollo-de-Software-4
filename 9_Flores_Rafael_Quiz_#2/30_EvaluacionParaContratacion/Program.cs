Console.Write("Ingrese la edad: ");
int edad = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingrese los años de experiencia: ");
int aniosExperiencia = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingrese la puntuacion de entrevista: ");
double puntuacion = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("1 = Tecnico");
Console.WriteLine("2 = Licenciatura");
Console.WriteLine("3 = Posgrado");
Console.Write("Ingrese el nivel educativo: ");
int nivelEducativo = Convert.ToInt32(Console.ReadLine());

string nombreNivel;

switch (nivelEducativo)
{
    case 1:
        nombreNivel = "Tecnico";
        break;
    case 2:
        nombreNivel = "Licenciatura";
        break;
    case 3:
        nombreNivel = "Posgrado";
        break;
    default:
        nombreNivel = "No valido";
        break;
}

if (nivelEducativo < 1 || nivelEducativo > 3)
{
    Console.WriteLine("Nivel educativo invalido.");
}
else
{
    bool recomendado = (aniosExperiencia >= 2 && puntuacion >= 80) || (nivelEducativo == 3 && puntuacion >= 75);

    Console.WriteLine("Nivel educativo: " + nombreNivel);
    Console.WriteLine("Puntuacion de entrevista: " + puntuacion);
    Console.WriteLine(recomendado ? "Resultado: Candidato recomendado" : "Resultado: Candidato no recomendado");
}
