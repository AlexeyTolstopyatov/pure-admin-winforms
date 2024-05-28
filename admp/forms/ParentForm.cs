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

        /// <summary>
        /// Собирает сведения о системе, для отображения их на форме родителе
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Загружает в WindowsItem элементы всех объектов базы данных (таблицы)
        /// </summary>
        /// <returns></returns>
        private async Task LoadObjectsAsync()
        {
            object[] tables = 
                await QueryManager.ExecuteVectorAsync(Query.Default.DboSelection);

            foreach (object table in tables) 
                await CreateMenuItemAsync(table.ToString());
            
        }

        private string _itemTag = "";

        /// <summary>
        /// Создает элемент меню, заносит его в WindowsItem (MenuStripItem)
        /// </summary>
        /// <param name="text">Название элемента</param>
        /// <returns></returns>
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

        /// <summary>
        /// Открывает форму внутри MDI родителя
        /// </summary>
        /// <param name="window">Экземпляр формы</param>
        /// <returns></returns>
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
