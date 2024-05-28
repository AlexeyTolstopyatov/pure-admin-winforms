using Dark.Net;
using System;
using System.Windows.Forms;
using admp.security;
using admp.forms.dialogs;

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

            if (AuthenticationManager.InitializePersonal() == true)
                Application.Run(parent);
            else
                Connect();
        }

        /// <summary>
        /// Вызывает мастера настройки соединения.
        /// </summary>
        private static void Connect()
        {

            DialogResult masterneeded = MessageBox.Show(
                "При проверке соединения с сервером произошла ошибка.",
                "Приложение остановлено",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Stop
            );

            if (masterneeded != DialogResult.Yes)
                Application.Exit();

            ConnectionForm cf = new ConnectionForm();
            DarkNet.Instance.SetWindowThemeForms(cf, Theme.Dark);

            Application.Run(cf);
        }
    }
}
