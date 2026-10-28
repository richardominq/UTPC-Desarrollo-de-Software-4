using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace CrudPersonasPostgreSQL.Forms;

internal static class UiMessages
{
    public static void ShowError(IWin32Window owner, Exception error)
    {
        Debug.WriteLine(error);
        Exception detail = error.GetBaseException();
        string message;
        if (error is DbUpdateConcurrencyException)
            message = "El registro cambió o fue eliminado por otra operación. Actualice la lista e inténtelo de nuevo.";
        else if (detail is PostgresException postgres)
            message = postgres.SqlState switch
            {
                "28P01" => "Usuario o contraseña incorrectos. Revise appsettings.json.",
                "3D000" => "No existe la base crud_personas indicada. Cree la base y revise Name en appsettings.json.",
                "42P01" => "No se encontró la tabla public.people. Ejecute 02_tabla_y_datos.sql en la base configurada.",
                "42501" => "El usuario no tiene los permisos necesarios sobre la base, la tabla o su secuencia.",
                "23514" => "Los datos no cumplen las reglas de nombre o edad de la tabla.",
                _ => "PostgreSQL rechazó la operación. Código: " + postgres.SqlState + ". Revise la salida de depuración."
            };
        else if (error is NpgsqlException || detail is System.Net.Sockets.SocketException || detail is TimeoutException)
            message = "No se pudo conectar con PostgreSQL. Compruebe que el servicio esté iniciado y revise Host, Port, Username y Password.";
        else if (detail is System.Text.Json.JsonException)
            message = "appsettings.json no tiene un formato JSON válido. Revise las comillas y las comas.";
        else if (error is InvalidOperationException || error is ArgumentException)
            message = error.Message;
        else
            message = "No se pudo completar la operación. Revise Ver > Salida > Depurar en Visual Studio.";

        MessageBox.Show(owner, message, "No se completó la operación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
}
