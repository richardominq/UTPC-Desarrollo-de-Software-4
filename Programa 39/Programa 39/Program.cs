using System;

class AlertaDeSeguridad
{
    static void Main(string[] args)
    {
        int intentosFallidos;
        int tipoUsuario;
        int nivelRiesgo;
        int equipoConocido;

        string usuario;
        string riesgo;
        string estadoSeguridad;

        // Ingresar números de intentos
        Console.Write("Ingrese la cantidad de intentos fallidos: ");
        intentosFallidos = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nTipo de usuario:");
        Console.WriteLine("1 = Normal");
        Console.WriteLine("2 = Administrador");
        Console.WriteLine("3 = Invitado");
        Console.Write("Seleccione el tipo de usuario: ");
        tipoUsuario = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nNivel de riesgo:");
        Console.WriteLine("1 = Bajo");
        Console.WriteLine("2 = Medio");
        Console.WriteLine("3 = Alto");
        Console.Write("Seleccione el nivel de riesgo: ");
        nivelRiesgo = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nEquipo conocido:");
        Console.WriteLine("1 = Sí");
        Console.WriteLine("2 = No");
        Console.Write("Seleccione una opción: ");
        equipoConocido = Convert.ToInt32(Console.ReadLine());

        // Tipo de usuario 
        switch (tipoUsuario)
        {
            case 1:
                usuario = "Normal";
                break;

            case 2:
                usuario = "Administrador";
                break;

            case 3:
                usuario = "Invitado";
                break;

            default:
                usuario = "Usuario no válido";
                break;
        }

        // Nivel de riesgo
        switch (nivelRiesgo)
        {
            case 1:
                riesgo = "Bajo";
                break;

            case 2:
                riesgo = "Medio";
                break;

            case 3:
                riesgo = "Alto";
                break;

            default:
                riesgo = "Nivel no válido";
                break;
        }

        // Determinar el estado de seguridad
        if ((intentosFallidos > 3 && equipoConocido == 2) || nivelRiesgo == 3)
        {
            estadoSeguridad = "ALERTA DE SEGURIDAD";
        }
        else
        {
            estadoSeguridad = "Acceso seguro";
        }

        // Mostrar resultados
        Console.WriteLine("\n--- RESULTADOS ---");
        Console.WriteLine("Tipo de usuario: " + usuario);
        Console.WriteLine("Nivel de riesgo: " + riesgo);
        Console.WriteLine("Estado de seguridad: " + estadoSeguridad);
    }
}