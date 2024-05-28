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
    public partial class JournalForm : DarkUI.Forms.DarkForm
    {
        public JournalForm(string[] journal)
        {
            InitializeComponent();

            DarkNet.Instance.SetWindowThemeForms(this, Theme.Dark);

            foreach (string report in journal)
                journalBox.AppendText(report);
        }
    }
}
