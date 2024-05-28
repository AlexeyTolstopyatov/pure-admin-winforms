using admp.adapters;
using admp.config;
using admp.forms.children;
using admp.forms.dialogs;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace admp
{
    public partial class ParentForm : DarkUI.Forms.DarkForm
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Форма рабочего стола загрузилась
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ParentForm_Load(object sender, EventArgs e)
        {
            // temp: Вместо задержек будет
            //
            // AuthenticationManager + AuthorizationManager

            infoBox.Text = "Проверка ядра аутентификации";
            await Task.Delay(300); // да, такое существует. Потом уберу :D!

            infoBox.Text = "Проверка ядра авторизации";
            await Task.Delay(400);

            infoBox.Text = "Проверка наличия дампа";
            await Task.Delay(300);
            await InitializeDump();

            infoBox.Text = "Инициализация компонентов";
            await Task.Delay(1000);

            
            await InitializeMenuStrip();

            await ErrorManager.ReportAsync($"Вход совершен: {DateTime.Now}");
        }

        /// <summary>
        /// Создание файла дампа
        /// </summary>
        /// <returns></returns>
        private Task InitializeDump() 
        {
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\report.system"))
            {
                string content =
                    File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "\\report.system");
                
                if (content == string.Empty)
                    return Task.CompletedTask;

                string date = content.Substring(0, content.IndexOf(";"));

                string reason = content.Substring(content.IndexOf(";") + 1);

                File.Delete(AppDomain.CurrentDomain.BaseDirectory + "\\report.system");

                string[] journal = { 
                    date, 
                    "\r\nБыл совершен выход по причине\r\n", 
                    reason 
                };

                new JournalForm(journal).ShowDialog();
            }
            return Task.CompletedTask;
        }

        /// <summary>
        /// Загружает в WindowsItem элементы всех объектов базы данных (таблицы)
        /// </summary>
        /// <returns></returns>
        private async Task InitializeMenuStrip()
        {
            object[] tables = 
                await QueryManager.ExecuteVectorAsync(Query.Default.DboSelection);

            foreach (object table in tables) 
                await CreateMenuItemAsync(table.ToString());
            
        }

        /// <summary>
        /// Список таблиц полученных из базы данных.
        /// </summary>
        private List<string> _tables = new List<string>();

        /// <summary>
        /// Создает элемент меню, заносит его в WindowsItem (MenuStripItem)
        /// </summary>
        /// <param name="text">Название элемента</param>
        /// <returns></returns>
        private Task CreateMenuItemAsync(string text)
        {
            // err: При инициализации меню все теги имеют одно значение.
            // fix: При получении из ExecuteVectorAsync() Все записывается в список.
            //      Список и MenuStrip связаны индексами
            ToolStripMenuItem item = new ToolStripMenuItem();
            _tables.Add(text);

            item.Tag = text;
            item.Text = text;
            item.Click += async(object s, EventArgs e) => 
            {
                DataTable table =
                await QueryManager.ExecuteMapAsync(
                    $"SELECT * FROM " +
                    $"[{_tables.ElementAt(windowsItem.DropDown.Items.IndexOf(item))}]"
                );
                
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

        /// <summary>
        /// Нажали на меню "Новый запрос"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newQueryItem_Click(object sender, EventArgs e)
        {
            _ = OpenChildWindowAsync(new QueryForm());
        }

        /// <summary>
        /// Нажали на меню "Журнал событий"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void journalItem_Click(object sender, EventArgs e)
        {
            _ = OpenChildWindowAsync(new JournalForm(await ErrorManager.GetReportsAsync()));
        }

        /// <summary>
        /// Нажали на меню "Открыть реестр"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void regobjItem_Click(object sender, EventArgs e)
        {
            new RegistryForm().Show();
        }

        /// <summary>
        /// Срабатывает при нажатии "Перезапустить сеанс"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void restartItem_Click(object sender, EventArgs e)
        {
            // any reason for restart set in ShutdownForm
            StartShutdown(true);
        }

        /// <summary>
        /// Срабатывает при нажатии "Завершить сеанс"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitItem_Click(object sender, EventArgs e)
        {
            StartShutdown(false);
        }

        /// <summary>
        /// Срабатывает при выходе из формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitItem_Click(object sender, FormClosingEventArgs e)
        {
            StartShutdown(false);
        }

        /// <summary>
        /// Инициализация завершения сеанса. (запись в журнал)
        /// </summary>
        /// <param name="restart"></param>
        private void StartShutdown(bool restart)
        {
            // err: перезагрузка не происходит.

            ShutdownForm shut =
                new ShutdownForm(false);

            shut.ShowDialog();

            if (shut.DialogResult == DialogResult.OK)
                Environment.Exit(0);

            if (shut.DialogResult == DialogResult.Retry)
                Application.Restart();
        }

        /// <summary>
        /// Экспорт admp.config в файл реестра.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exportRegisterItem_Click(object sender, EventArgs e)
        {
            // Создание файла реестра из Query.setting
            XDocument reg = new XDocument();
            XElement root = new XElement("Objects");
            

            foreach (SettingsProperty x in Query.Default.Properties)
            {
                root.Add(new XElement(x.Name, x.DefaultValue));
            }

            reg.Add(root);

            string containment = reg.Document.ToString();

            new JournalForm(new string[2] 
            { 
                "Cодержимое реестра\r\n", 
                containment
            }).ShowDialog();

            
            reg.Save(AppDomain.CurrentDomain.BaseDirectory + "\\BaseObjects.system");
            Process.Start("explorer.exe", AppDomain.CurrentDomain.BaseDirectory);
        }

        /// <summary>
        /// Вызов мастера проверки схем
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void xsdMasterItem_Click(object sender, EventArgs e)
        {
            _ = OpenChildWindowAsync(new SerializeMasterForm());
        }
    }
}
