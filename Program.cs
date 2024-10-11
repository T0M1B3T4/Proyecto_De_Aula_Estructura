using System;
using System.Windows.Forms;
using static System.Console;
using static System.Convert;

namespace Gestión_Museo
{
    static class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());
        }
    }
}