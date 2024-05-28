using System;
using System.Threading.Tasks;
using System.Windows.Forms;

using admp.adapters;
using admp.config;

namespace admp.forms.dialogs
{
    public partial class AuthorizationForm : DarkUI.Forms.DarkForm
    {
        public AuthorizationForm()
        {
            InitializeComponent();

            // при инициализации диалог имеет всегда отрицательный результат
            // Результат должен быть или положительный (только ОК) или отрицательный (только Cancel)
            //  OK - Личность существует, авторизация пройдена
            //  Cancel - Любая причина отмены авторизации
            //          Отмена процесса авторизации завершает работу приложения.
            //          (ReportAsync() + Shutdown())

            DialogResult = DialogResult.Cancel;
        }

        private Task ConnectAsync()
        {
            DialogResult = DialogResult.OK;
            Hide(); // Close() завершает работу приложения

            return Task.CompletedTask;
        }

        private async Task<bool> IsRight()
        {
            if (string.IsNullOrEmpty(loginBox.Text) || string.IsNullOrEmpty(passwordBox.Text)) ;
            else
            {
                object result =
                    await QueryManager.ExecuteCellAsync("SELECT COUNT(ID) FROM " + Query.Default.UsersObject);

                // Логика авторизации описана в LoginProcess.md 
                if (result.Equals(1))
                    return true;

            }

            return false;
        }

        private async void loginButton_Click(object sender, EventArgs e)
        {
            bool state = 
                await IsRight();

            if (state)
            {
                // Вызов ConnectAsync() как отдельной задачи без ожидания.
                //
                // loginButton_Click обязан завершиться, независимо от ConnectAsync()
                _ = ConnectAsync();
            }
            else
                MessageBox.Show("Не удалось войти в систему", "Ядро Авторизации", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
