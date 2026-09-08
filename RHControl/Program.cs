using System;
using System.Windows.Forms;
using RHControl.Data;

namespace RHControl
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            Database.Inicializar();

            Application.Run(new FrmLoading());
        }
    }
}