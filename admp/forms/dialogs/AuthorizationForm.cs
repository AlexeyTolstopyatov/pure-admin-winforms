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

            // firstly dialog result always negative
            // from (this) object only 2 ways to resolve
            //  OK - check passed
            //  Cancel - any reason for close dialog

            DialogResult = DialogResult.Cancel;
        }

        private Task ConnectAsync()
        {
            DialogResult = DialogResult.OK;

            Close();

            return Task.CompletedTask;
        }

        private async Task<bool> IsRight()
        {
            if (string.IsNullOrEmpty(loginBox.Text) || string.IsNullOrEmpty(passwordBox.Text)) ;
            else
            {
                object result =
                    await QueryManager.ExecuteCellAsync("SELECT COUNT(ID) FROM " + Query.Default.UsersObject);

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
                _ = ConnectAsync();
            else
                MessageBox.Show("Не удалось войти в систему", "Ядро Авторизации", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
