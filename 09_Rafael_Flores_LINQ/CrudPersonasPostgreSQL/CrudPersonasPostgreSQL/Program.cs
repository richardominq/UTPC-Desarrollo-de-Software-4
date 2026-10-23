using CrudPersonasPostgreSQL.Forms;

namespace CrudPersonasPostgreSQL;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
    }
}
