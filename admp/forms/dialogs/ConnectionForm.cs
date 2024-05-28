using Dark.Net;
using System;


namespace admp.forms.dialogs
{
    public partial class ConnectionForm : DarkUI.Forms.DarkForm
    {
        public ConnectionForm()
        {
            InitializeComponent();
            DarkNet.Instance.SetWindowThemeForms(this, Theme.Dark);
        }

        /// <summary>
        /// Запрещает или разрешает свойство строки соединения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void connectBox_CheckedChanged(object sender, EventArgs e)
        {
            if (connectBox.Checked == true)
            {
                connectBox.Enabled = true;
            }
            else
            { 
                connectBox.Enabled = false;
            }
        }

        /// <summary>
        /// Уберает или добавляет возможность совершить идеинтификацию на основе политики Windows
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void windowsPolicyCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (windowsPolicyCheck.Checked == true) 
            {
                name.Enabled = false;
                name.Text = string.Empty;

                password.Enabled = false;
                password.Text = string.Empty;
            }
            
        }
    }
}
