using GenClassesFromQuery.Forms;
using System;
using System.Windows.Forms;

namespace GenClassesFromQuery
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                Application.Run(new frmContainer());
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Unhandled Exception");
            }
        }
    }
}