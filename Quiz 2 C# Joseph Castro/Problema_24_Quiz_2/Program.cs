class Program
{
    static void Main(string[] args)
    {
        double notaob;
        short tipoevaluacion;

        Console.WriteLine("ingresa la calificacion obtenida");
        notaob = double.Parse(Console.ReadLine());

        Console.WriteLine("si es otra medida elije: (solo numeros)");
        Console.WriteLine("1. Parcial");
        Console.WriteLine("2. Proyecto");
        Console.WriteLine("3. Examen semestral");
        tipoevaluacion = short.Parse(Console.ReadLine());

        string res;
        if (notaob >= 71) 
        {
            res = "Aprobado";
        }
        else
        {
            res = "Reprobado";
        }

        Console.WriteLine($"el resultado de su evaluacion es {res} con la nota de {notaob} que equivale a una {result(notaob)} en la evaluacion de {evaluacion(tipoevaluacion)}");
    }
    static string result(double nota)
    {
        string resultado = nota switch
        {
            >= 91 and <= 100 => "Su nota es una A",
            >= 81 and < 91 => "Su nota es una B",
            >= 71 and < 81 => "Su nota es una C",
            >= 61 and < 71 => "Su nota es una D",
            >= 0 and < 61 => "Su nota es una F",
            _ => "nota no valida" // El guion bajo (_) actúa como el caso predeterminado (default)
        };
        
        return resultado;
    }
    static string evaluacion (short nota)
    {
        string resultado = nota switch
        {
            1 => "Parcial",
            2 => "Proyecto",
            3 => "Examen final",
            _ => "dato no valido" // El guion bajo (_) actúa como el caso predeterminado (default)
        };

        return resultado;
    }

}