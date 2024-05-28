using admp.adapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace admp.forms.children
{
    public partial class QueryForm : DarkUI.Forms.DarkForm
    {
        public QueryForm()
        {
            InitializeComponent();
            resultView.Visible = false;
        }

        private async void queryBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                DataTable table = 
                    await QueryManager.ExecuteMapAsync(queryBox.Text);

                resultView.Visible = true;
                resultView.DataSource = table;
            }

        }
    }
}
