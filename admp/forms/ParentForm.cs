using admp.adapters;
using admp.config;
using admp.forms.children;

using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace admp
{
    public partial class ParentForm : DarkUI.Forms.DarkForm
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {
            _ = CollectInformationAsync();
            _ = LoadObjectsAsync();
        }

        private Task CollectInformationAsync()
        {
            infoBox.Text =
                $"Puredrive Admin Panel A1 (alpha) \r\n" +
                $"Операционная Система: {Environment.OSVersion} \r\n" +
                $"Имя компьютера: {Environment.MachineName}\r\n" +
                $"64 разрядный процесс: {Environment.Is64BitProcess}\r\n" +
                $"Домен: {Environment.UserDomainName} \r\n" +
                $"Пользователь: {Environment.UserName} \r\n" + 
                $"Выделенная область памяти: {Environment.WorkingSet}  \r\n";


            return Task.CompletedTask;
        }

        private async Task LoadObjectsAsync()
        {
            object[] tables = 
                await QueryManager.ExecuteVectorAsync(Query.Default.DboSelection);

            foreach (object table in tables) 
                await CreateMenuItemAsync(table.ToString());
            
        }

        private string _itemTag = "";

        private Task CreateMenuItemAsync(string text)
        {
            ToolStripMenuItem item = new ToolStripMenuItem();

            item.Tag = _itemTag = text;
            item.Text = text;
            item.Click += async(object s, EventArgs e) => 
            {
                DataTable table =
                await QueryManager.ExecuteMapAsync($"SELECT * FROM [{_itemTag}]");

                await OpenChildWindowAsync(new TableForm(table));
            };
            

            windowsItem.DropDownItems.Add(item);

            return Task.CompletedTask;
        }

        private Task OpenChildWindowAsync(Form window)
        {
            IsMdiContainer = true;
            window.MdiParent = this;

            window.Show();

            return Task.CompletedTask;
        }

        private void newQueryItem_Click(object sender, EventArgs e)
        {
            _ = OpenChildWindowAsync(new QueryForm());
        }

        private async void journalItem_Click(object sender, EventArgs e)
        {
            _ = OpenChildWindowAsync(new JournalForm(await ErrorManager.GetReportsAsync()));
        }

        private void regobjItem_Click(object sender, EventArgs e)
        {
            new RegistryForm().Show();
        }
    }
}
