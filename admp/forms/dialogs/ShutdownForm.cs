using Dark.Net;
using System;
using System.IO;
using System.Windows.Forms;

namespace admp.forms.dialogs
{
    public partial class ShutdownForm : DarkUI.Forms.DarkForm
    {
        /// <summary>
        /// Передает значение перезагрузки
        /// </summary>
        bool _restartFlag = false;

        public ShutdownForm(bool isrestart)
        {
            InitializeComponent();

            DarkNet.Instance.SetWindowThemeForms(this, Theme.Dark);
            
            _restartFlag = isrestart;
        }

        /// <summary>
        /// Создает файл отчета о завершении сессии
        /// </summary>
        private void WriteReason()
        {
            if (reason.Text == string.Empty)
            {
                reason.Text = "Причина завершения сеанса не была указана";
            }
            string path = AppDomain.CurrentDomain.BaseDirectory + "\\report.system";

            if (File.Exists(path))
                File.CreateText(path);
            
            File.WriteAllText(
                path, 
                $"{DateTime.UtcNow};{reason.Text}"
            );

        }

        /// <summary>
        /// Изменяет результат диалога в зависимости от причины вызова
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            WriteReason();

            if (_restartFlag)
                DialogResult = DialogResult.Retry;
            else
                DialogResult = DialogResult.OK;
        }
    }
}
