using Dark.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;

namespace admp.forms.dialogs
{
    public partial class SerializeMasterForm : DarkUI.Forms.DarkForm
    {
        public SerializeMasterForm()
        {
            InitializeComponent();

            DarkNet.Instance.SetWindowThemeForms(this, Theme.Dark);
        }

        /// <summary>
        /// Записывает путь до экземпляра схемы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void browseXsdButton_Click(object sender, EventArgs e)
        {
            DialogResult result
                = xsdOpenDialog.ShowDialog();
            
            if (result == DialogResult.OK) 
            {
                xsdPath.Text = xsdOpenDialog.FileName;
            }
        }

        /// <summary>
        /// Записывает путь до документа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void browseXmlButton_Click(object sender, EventArgs e)
        {
            DialogResult result = xmlOpenDialog.ShowDialog();
            if (result == DialogResult.OK ) 
            {
                xmlPath.Text = xmlOpenDialog.FileName;
            }
        }

        /// <summary>
        /// Проверяет схему, возвращает результат в statusLabel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkButton_Click(object sender, EventArgs e)
        {
            try
            {
                XmlDocument document = new XmlDocument();
                document.Load(xmlPath.Text);

                document.Schemas.Add(null, xsdPath.Text);

                document.Validate(null);
                statusLabel.ForeColor = Color.Green;
                statusLabel.Text = "Успешно!";
            }
            catch (Exception E)
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = E.Message;
            }
        }

    }
}
