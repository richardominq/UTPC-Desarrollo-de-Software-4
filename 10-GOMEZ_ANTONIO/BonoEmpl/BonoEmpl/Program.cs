using System;
/*
 10. Bono de empleado
Solicite el salario, los años de servicio, el nivel del empleado (1 = Operativo, 2 = Técnico, 3 = Profesional) y 
su evaluación de desempeño de 1 a 100. Otorgue un bono si posee 3 años o más de servicio y una evaluación igual o 
superior a 85. Utilice switch expression para establecer el porcentaje de bono según el nivel. 
Muestre el porcentaje del bono,el valor del bono y el nuevo salario.
Entradas: 4. Salidas: 3.
Utilizar: if, &&, switch expression.
 */
class Program
{
    static void Main()
    {
        // 1. Solicitar datos básicos del empleado
        Console.Write("Ingrese el salario: ");
        double salario = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese los años de servicios: ");
        int aniosServicio = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese la evaluacion de desempeno (1-100): ");
        int evaluacionDesempeno = Convert.ToInt32(Console.ReadLine());

        // 2. Mostrar opciones de nivel de empleado
        Console.WriteLine("Ingrese su nivel de empleo: \n");
        Console.WriteLine("1 = Operativo.");
        Console.WriteLine("2 = Tecnico.");
        Console.WriteLine("3 = Profesional.");
        int tipoEmpleado = Convert.ToInt32(Console.ReadLine());

        // 3. Variables para almacenar el bono, porcentaje y elegibilidad
        double valorBono = 0;       // Monto del bono calculado
        double porce = 0;           // Porcentaje del bono (ej. 0.05 = 5%)
        Boolean esElegible = false; // Indica si el tipo de empleado es válido 

        // 4. Determinar el porcentaje de bono según el tipo de empleado
        switch (tipoEmpleado)
        {
            case 1: // Operativo
                porce = 0.05;                 // 5% del salario
                valorBono = porce * salario;   // Cálculo del bono
                // esElegible = true;         // (comentado) no se usa
                break;

            case 2: // Técnico
                porce = 0.10;                 // 10% del salario
                valorBono = porce * salario;  // Uso de la variable porce
                // esElegible = true;
                break;

            case 3: // Profesional
                porce = 0.15;                 // 15% del salario
                valorBono = porce * salario;
                esElegible = true;            // Se marca como elegible
                break;

            default: // Cualquier otro número
                esElegible = false;
                //Console.WriteLine("Tipo de empleado no válido.");
                break;
        }

        // 5. Calcular el nuevo salario (salario + bono) aunque luego no se use si no cumple
        double nuevoSalario = salario + valorBono;

        // 6. Verificar las condiciones para recibir el bono:
        //    - antigüedad >= 3 años
        //    - evaluación de desempeño >= 85
        if (aniosServicio >= 3 && evaluacionDesempeno >= 85)
        {
            // Si cumple, se muestra el bono, el nuevo salario y el porcentaje aplicado
            Console.WriteLine($"El bono es: {valorBono:C}. " +
                $"Nuevo salario: {nuevoSalario:C}. " +
                $"Con un porcentaje del bono: {porce:C}");
            // NOTA: {porce:C} muestra el porcentaje como si fuera dinero (ej. $0.05)
            // Sería más adecuado usar {porce:P0} para mostrarlo como 5%.
        }
        else
        {
            // Si no cumple las condiciones, no recibe bono y se muestra el salario original
            Console.WriteLine($"No es elegible para recibir un bono. Salario Neto: {salario:C}");
        }

    }
}