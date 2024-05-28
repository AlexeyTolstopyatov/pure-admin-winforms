using Dark.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace admp
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            DarkNet.Instance.SetCurrentProcessTheme(Theme.Auto);
            
            ParentForm parent = new ParentForm();
            DarkNet.Instance.SetWindowThemeForms(parent, Theme.Auto);

            Application.Run(parent);
        }

    }
}
