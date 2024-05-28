namespace admp.forms.children
{
    partial class RegistryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.paramList = new System.Windows.Forms.ListBox();
            this.darkTextBox1 = new DarkUI.Controls.DarkTextBox();
            this.paramArg = new DarkUI.Controls.DarkTextBox();
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.saveButton = new DarkUI.Controls.DarkButton();
            this.SuspendLayout();
            // 
            // paramList
            // 
            this.paramList.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.paramList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paramList.ForeColor = System.Drawing.SystemColors.Window;
            this.paramList.FormattingEnabled = true;
            this.paramList.Location = new System.Drawing.Point(203, 12);
            this.paramList.Name = "paramList";
            this.paramList.Size = new System.Drawing.Size(198, 119);
            this.paramList.TabIndex = 0;
            this.paramList.DoubleClick += new System.EventHandler(this.paramList_DoubleClick);
            // 
            // darkTextBox1
            // 
            this.darkTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.darkTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.darkTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkTextBox1.Location = new System.Drawing.Point(12, 12);
            this.darkTextBox1.Multiline = true;
            this.darkTextBox1.Name = "darkTextBox1";
            this.darkTextBox1.Size = new System.Drawing.Size(185, 119);
            this.darkTextBox1.TabIndex = 1;
            this.darkTextBox1.Text = "Pure Base API используется \r\nкомпонентами Admin Panel и Drive для запроса\r\nхраним" +
    "ой информации с сервера базы данных.\r\nНастройте ассоциации функций и аргументов\r" +
    "\nдля работы с сервером";
            // 
            // paramArg
            // 
            this.paramArg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.paramArg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paramArg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.paramArg.Location = new System.Drawing.Point(203, 139);
            this.paramArg.Name = "paramArg";
            this.paramArg.Size = new System.Drawing.Size(198, 20);
            this.paramArg.TabIndex = 2;
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel1.Location = new System.Drawing.Point(12, 139);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(120, 13);
            this.darkLabel1.TabIndex = 3;
            this.darkLabel1.Text = "Параметр (не выбран)";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(326, 165);
            this.saveButton.Name = "saveButton";
            this.saveButton.Padding = new System.Windows.Forms.Padding(5);
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Сохранить";
            // 
            // RegistryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 199);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.darkLabel1);
            this.Controls.Add(this.paramArg);
            this.Controls.Add(this.darkTextBox1);
            this.Controls.Add(this.paramList);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistryForm";
            this.ShowIcon = false;
            this.Text = "Редактор Реестра Pure Base API";
            this.Load += new System.EventHandler(this.RegistryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox paramList;
        private DarkUI.Controls.DarkTextBox darkTextBox1;
        private DarkUI.Controls.DarkTextBox paramArg;
        private DarkUI.Controls.DarkLabel darkLabel1;
        private DarkUI.Controls.DarkButton saveButton;
    }
}