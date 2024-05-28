namespace admp.forms.dialogs
{
    partial class ConnectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionForm));
            this.darkTextBox2 = new DarkUI.Controls.DarkTextBox();
            this.okButton = new DarkUI.Controls.DarkButton();
            this.saveButton = new DarkUI.Controls.DarkButton();
            this.server = new DarkUI.Controls.DarkTextBox();
            this.dbase = new DarkUI.Controls.DarkTextBox();
            this.name = new DarkUI.Controls.DarkTextBox();
            this.password = new DarkUI.Controls.DarkTextBox();
            this.serverBox = new DarkUI.Controls.DarkLabel();
            this.baseBox = new DarkUI.Controls.DarkLabel();
            this.userBox = new DarkUI.Controls.DarkLabel();
            this.passwordBox = new DarkUI.Controls.DarkLabel();
            this.windowsPolicyCheck = new DarkUI.Controls.DarkCheckBox();
            this.connection = new DarkUI.Controls.DarkTextBox();
            this.connectBox = new DarkUI.Controls.DarkCheckBox();
            this.SuspendLayout();
            // 
            // darkTextBox2
            // 
            this.darkTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.darkTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.darkTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkTextBox2.Location = new System.Drawing.Point(12, 12);
            this.darkTextBox2.Multiline = true;
            this.darkTextBox2.Name = "darkTextBox2";
            this.darkTextBox2.ReadOnly = true;
            this.darkTextBox2.Size = new System.Drawing.Size(173, 141);
            this.darkTextBox2.TabIndex = 2;
            this.darkTextBox2.TabStop = false;
            this.darkTextBox2.Text = resources.GetString("darkTextBox2.Text");
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(361, 197);
            this.okButton.Name = "okButton";
            this.okButton.Padding = new System.Windows.Forms.Padding(5);
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "OK";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(280, 197);
            this.saveButton.Name = "saveButton";
            this.saveButton.Padding = new System.Windows.Forms.Padding(5);
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Сохранить";
            // 
            // server
            // 
            this.server.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.server.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.server.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.server.Location = new System.Drawing.Point(300, 12);
            this.server.Name = "server";
            this.server.Size = new System.Drawing.Size(133, 20);
            this.server.TabIndex = 5;
            // 
            // dbase
            // 
            this.dbase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.dbase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dbase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.dbase.Location = new System.Drawing.Point(300, 38);
            this.dbase.Name = "dbase";
            this.dbase.Size = new System.Drawing.Size(133, 20);
            this.dbase.TabIndex = 6;
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.name.Location = new System.Drawing.Point(300, 64);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(133, 20);
            this.name.TabIndex = 7;
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.password.Location = new System.Drawing.Point(300, 90);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(133, 20);
            this.password.TabIndex = 8;
            // 
            // serverBox
            // 
            this.serverBox.AutoSize = true;
            this.serverBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.serverBox.Location = new System.Drawing.Point(192, 18);
            this.serverBox.Name = "serverBox";
            this.serverBox.Size = new System.Drawing.Size(44, 13);
            this.serverBox.TabIndex = 9;
            this.serverBox.Text = "Сервер";
            // 
            // baseBox
            // 
            this.baseBox.AutoSize = true;
            this.baseBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.baseBox.Location = new System.Drawing.Point(192, 45);
            this.baseBox.Name = "baseBox";
            this.baseBox.Size = new System.Drawing.Size(72, 13);
            this.baseBox.TabIndex = 10;
            this.baseBox.Text = "База данных";
            // 
            // userBox
            // 
            this.userBox.AutoSize = true;
            this.userBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.userBox.Location = new System.Drawing.Point(192, 71);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(29, 13);
            this.userBox.TabIndex = 11;
            this.userBox.Text = "Имя";
            // 
            // passwordBox
            // 
            this.passwordBox.AutoSize = true;
            this.passwordBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.passwordBox.Location = new System.Drawing.Point(192, 97);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(45, 13);
            this.passwordBox.TabIndex = 12;
            this.passwordBox.Text = "Пароль";
            // 
            // windowsPolicyCheck
            // 
            this.windowsPolicyCheck.AutoSize = true;
            this.windowsPolicyCheck.Location = new System.Drawing.Point(195, 136);
            this.windowsPolicyCheck.Name = "windowsPolicyCheck";
            this.windowsPolicyCheck.Size = new System.Drawing.Size(160, 17);
            this.windowsPolicyCheck.TabIndex = 13;
            this.windowsPolicyCheck.Text = "Идеинтификация Windows";
            this.windowsPolicyCheck.CheckedChanged += new System.EventHandler(this.windowsPolicyCheck_CheckedChanged);
            // 
            // connection
            // 
            this.connection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.connection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.connection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.connection.Location = new System.Drawing.Point(12, 158);
            this.connection.Name = "connection";
            this.connection.Size = new System.Drawing.Size(173, 20);
            this.connection.TabIndex = 14;
            this.connection.Text = " ";
            // 
            // connectBox
            // 
            this.connectBox.AutoSize = true;
            this.connectBox.Location = new System.Drawing.Point(195, 159);
            this.connectBox.Name = "connectBox";
            this.connectBox.Size = new System.Drawing.Size(132, 17);
            this.connectBox.TabIndex = 15;
            this.connectBox.Text = "Строка подключения";
            this.connectBox.CheckedChanged += new System.EventHandler(this.connectBox_CheckedChanged);
            // 
            // ConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 232);
            this.Controls.Add(this.connectBox);
            this.Controls.Add(this.connection);
            this.Controls.Add(this.windowsPolicyCheck);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.baseBox);
            this.Controls.Add(this.serverBox);
            this.Controls.Add(this.password);
            this.Controls.Add(this.name);
            this.Controls.Add(this.dbase);
            this.Controls.Add(this.server);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.darkTextBox2);
            this.MaximizeBox = false;
            this.Name = "ConnectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Идеинтификация пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DarkUI.Controls.DarkTextBox darkTextBox2;
        private DarkUI.Controls.DarkButton okButton;
        private DarkUI.Controls.DarkButton saveButton;
        private DarkUI.Controls.DarkTextBox server;
        private DarkUI.Controls.DarkTextBox dbase;
        private DarkUI.Controls.DarkTextBox name;
        private DarkUI.Controls.DarkTextBox password;
        private DarkUI.Controls.DarkLabel serverBox;
        private DarkUI.Controls.DarkLabel baseBox;
        private DarkUI.Controls.DarkLabel userBox;
        private DarkUI.Controls.DarkLabel passwordBox;
        private DarkUI.Controls.DarkCheckBox windowsPolicyCheck;
        private DarkUI.Controls.DarkTextBox connection;
        private DarkUI.Controls.DarkCheckBox connectBox;
    }
}