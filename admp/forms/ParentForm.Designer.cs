namespace admp
{
    partial class ParentForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.infoBox = new DarkUI.Controls.DarkTextBox();
            this.darkMenuStrip1 = new DarkUI.Controls.DarkMenuStrip();
            this.windowsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инструментыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newQueryItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openConfigItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xsdMasterItem = new System.Windows.Forms.ToolStripMenuItem();
            this.journalItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regobjItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportRegisterItem = new System.Windows.Forms.ToolStripMenuItem();
            this.системаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoBox
            // 
            this.infoBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.infoBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.infoBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.infoBox.Location = new System.Drawing.Point(12, 39);
            this.infoBox.Multiline = true;
            this.infoBox.Name = "infoBox";
            this.infoBox.ReadOnly = true;
            this.infoBox.Size = new System.Drawing.Size(262, 146);
            this.infoBox.TabIndex = 0;
            this.infoBox.TabStop = false;
            // 
            // darkMenuStrip1
            // 
            this.darkMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.darkMenuStrip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windowsItem,
            this.инструментыToolStripMenuItem,
            this.системаToolStripMenuItem});
            this.darkMenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.darkMenuStrip1.Name = "darkMenuStrip1";
            this.darkMenuStrip1.Padding = new System.Windows.Forms.Padding(3, 2, 0, 2);
            this.darkMenuStrip1.Size = new System.Drawing.Size(858, 24);
            this.darkMenuStrip1.TabIndex = 2;
            this.darkMenuStrip1.Text = "darkMenuStrip1";
            // 
            // windowsItem
            // 
            this.windowsItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.windowsItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.windowsItem.Name = "windowsItem";
            this.windowsItem.Size = new System.Drawing.Size(47, 20);
            this.windowsItem.Text = "Окна";
            // 
            // инструментыToolStripMenuItem
            // 
            this.инструментыToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.инструментыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newQueryItem,
            this.openToolsItem,
            this.openConfigItem,
            this.xsdMasterItem,
            this.journalItem,
            this.regobjItem,
            this.exportRegisterItem});
            this.инструментыToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.инструментыToolStripMenuItem.Name = "инструментыToolStripMenuItem";
            this.инструментыToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.инструментыToolStripMenuItem.Text = "Инструменты";
            // 
            // newQueryItem
            // 
            this.newQueryItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.newQueryItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.newQueryItem.Name = "newQueryItem";
            this.newQueryItem.Size = new System.Drawing.Size(211, 22);
            this.newQueryItem.Text = "Новый запрос";
            this.newQueryItem.Click += new System.EventHandler(this.newQueryItem_Click);
            // 
            // openToolsItem
            // 
            this.openToolsItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.openToolsItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.openToolsItem.Name = "openToolsItem";
            this.openToolsItem.Size = new System.Drawing.Size(211, 22);
            this.openToolsItem.Text = "Открыть в окне";
            // 
            // openConfigItem
            // 
            this.openConfigItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.openConfigItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.openConfigItem.Name = "openConfigItem";
            this.openConfigItem.Size = new System.Drawing.Size(211, 22);
            this.openConfigItem.Text = "Открыть user.config";
            // 
            // xsdMasterItem
            // 
            this.xsdMasterItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.xsdMasterItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.xsdMasterItem.Name = "xsdMasterItem";
            this.xsdMasterItem.Size = new System.Drawing.Size(211, 22);
            this.xsdMasterItem.Text = "Мастер проверки XSD";
            this.xsdMasterItem.Click += new System.EventHandler(this.xsdMasterItem_Click);
            // 
            // journalItem
            // 
            this.journalItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.journalItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.journalItem.Name = "journalItem";
            this.journalItem.Size = new System.Drawing.Size(211, 22);
            this.journalItem.Text = "Журнал событий";
            this.journalItem.Click += new System.EventHandler(this.journalItem_Click);
            // 
            // regobjItem
            // 
            this.regobjItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.regobjItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.regobjItem.Name = "regobjItem";
            this.regobjItem.Size = new System.Drawing.Size(211, 22);
            this.regobjItem.Text = "Открыть реестр";
            this.regobjItem.Click += new System.EventHandler(this.regobjItem_Click);
            // 
            // exportRegisterItem
            // 
            this.exportRegisterItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.exportRegisterItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.exportRegisterItem.Name = "exportRegisterItem";
            this.exportRegisterItem.Size = new System.Drawing.Size(211, 22);
            this.exportRegisterItem.Text = "Сохранить файл реестра";
            this.exportRegisterItem.Click += new System.EventHandler(this.exportRegisterItem_Click);
            // 
            // системаToolStripMenuItem
            // 
            this.системаToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.системаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartItem,
            this.exitItem});
            this.системаToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.системаToolStripMenuItem.Name = "системаToolStripMenuItem";
            this.системаToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.системаToolStripMenuItem.Text = "Система";
            // 
            // restartItem
            // 
            this.restartItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.restartItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.restartItem.Name = "restartItem";
            this.restartItem.Size = new System.Drawing.Size(189, 22);
            this.restartItem.Text = "Перезапустить сеанс";
            this.restartItem.Click += new System.EventHandler(this.restartItem_Click);
            // 
            // exitItem
            // 
            this.exitItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.exitItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.exitItem.Name = "exitItem";
            this.exitItem.Size = new System.Drawing.Size(189, 22);
            this.exitItem.Text = "Завершить сеанс";
            this.exitItem.Click += new System.EventHandler(this.exitItem_Click);
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 452);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.darkMenuStrip1);
            this.FlatBorder = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.darkMenuStrip1;
            this.Name = "ParentForm";
            this.Text = "Рабочий стол";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.exitItem_Click);
            this.Load += new System.EventHandler(this.ParentForm_Load);
            this.darkMenuStrip1.ResumeLayout(false);
            this.darkMenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DarkUI.Controls.DarkTextBox infoBox;
        private DarkUI.Controls.DarkMenuStrip darkMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem windowsItem;
        private System.Windows.Forms.ToolStripMenuItem инструментыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newQueryItem;
        private System.Windows.Forms.ToolStripMenuItem openToolsItem;
        private System.Windows.Forms.ToolStripMenuItem openConfigItem;
        private System.Windows.Forms.ToolStripMenuItem xsdMasterItem;
        private System.Windows.Forms.ToolStripMenuItem journalItem;
        private System.Windows.Forms.ToolStripMenuItem regobjItem;
        private System.Windows.Forms.ToolStripMenuItem системаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartItem;
        private System.Windows.Forms.ToolStripMenuItem exitItem;
        private System.Windows.Forms.ToolStripMenuItem exportRegisterItem;
    }
}

