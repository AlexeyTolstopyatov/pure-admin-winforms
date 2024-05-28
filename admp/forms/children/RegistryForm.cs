using admp.config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace admp.forms.children
{
    public partial class RegistryForm : DarkUI.Forms.DarkForm
    {
        public RegistryForm()
        {
            InitializeComponent();

            Dark.Net.DarkNet.Instance.SetWindowThemeForms(this, Dark.Net.Theme.Dark);
        }

        private void RegistryForm_Load(object sender, EventArgs e)
        {
            foreach (SettingsProperty parameter in Query.Default.Properties)
                paramList.Items.Add(parameter.Name.ToString());
        }

        private void paramList_DoubleClick(object sender, EventArgs e)
        {
            paramArg.Text = Query.Default.Properties[paramList.SelectedItem.ToString()]
                .DefaultValue.ToString();
        }
    }
}
