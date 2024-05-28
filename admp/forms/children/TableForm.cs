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

namespace admp.forms.children
{
    public partial class TableForm : DarkUI.Forms.DarkForm
    {
        public TableForm(DataTable table)
        {
            InitializeComponent();
            
            tableView.DataSource = table;
            DarkNet.Instance.SetWindowThemeForms(this, Theme.Dark);
        }

    }
}
