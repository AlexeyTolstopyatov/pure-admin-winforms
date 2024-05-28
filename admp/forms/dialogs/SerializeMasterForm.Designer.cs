namespace admp.forms.dialogs
{
    partial class SerializeMasterForm
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
            this.xsdPath = new DarkUI.Controls.DarkTextBox();
            this.xmlPath = new DarkUI.Controls.DarkTextBox();
            this.checkButton = new DarkUI.Controls.DarkButton();
            this.xsdOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.xmlOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.browseXsdButton = new DarkUI.Controls.DarkButton();
            this.browseXmlButton = new DarkUI.Controls.DarkButton();
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.darkLabel2 = new DarkUI.Controls.DarkLabel();
            this.statusLabel = new DarkUI.Controls.DarkLabel();
            this.SuspendLayout();
            // 
            // xsdPath
            // 
            this.xsdPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.xsdPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xsdPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.xsdPath.Location = new System.Drawing.Point(12, 35);
            this.xsdPath.Name = "xsdPath";
            this.xsdPath.Size = new System.Drawing.Size(222, 20);
            this.xsdPath.TabIndex = 0;
            // 
            // xmlPath
            // 
            this.xmlPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.xmlPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xmlPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.xmlPath.Location = new System.Drawing.Point(12, 80);
            this.xmlPath.Name = "xmlPath";
            this.xmlPath.Size = new System.Drawing.Size(222, 20);
            this.xmlPath.TabIndex = 1;
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(12, 123);
            this.checkButton.Name = "checkButton";
            this.checkButton.Padding = new System.Windows.Forms.Padding(5);
            this.checkButton.Size = new System.Drawing.Size(75, 23);
            this.checkButton.TabIndex = 2;
            this.checkButton.Text = "Проверить";
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // browseXsdButton
            // 
            this.browseXsdButton.Location = new System.Drawing.Point(240, 35);
            this.browseXsdButton.Name = "browseXsdButton";
            this.browseXsdButton.Padding = new System.Windows.Forms.Padding(5);
            this.browseXsdButton.Size = new System.Drawing.Size(43, 23);
            this.browseXsdButton.TabIndex = 3;
            this.browseXsdButton.Text = "...";
            this.browseXsdButton.Click += new System.EventHandler(this.browseXsdButton_Click);
            // 
            // browseXmlButton
            // 
            this.browseXmlButton.Location = new System.Drawing.Point(240, 77);
            this.browseXmlButton.Name = "browseXmlButton";
            this.browseXmlButton.Padding = new System.Windows.Forms.Padding(5);
            this.browseXmlButton.Size = new System.Drawing.Size(43, 23);
            this.browseXmlButton.TabIndex = 4;
            this.browseXmlButton.Text = "...";
            this.browseXmlButton.Click += new System.EventHandler(this.browseXmlButton_Click);
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel1.Location = new System.Drawing.Point(12, 13);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(146, 13);
            this.darkLabel1.TabIndex = 5;
            this.darkLabel1.Text = "Схема определения (*.XSD)";
            // 
            // darkLabel2
            // 
            this.darkLabel2.AutoSize = true;
            this.darkLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel2.Location = new System.Drawing.Point(12, 61);
            this.darkLabel2.Name = "darkLabel2";
            this.darkLabel2.Size = new System.Drawing.Size(96, 13);
            this.darkLabel2.TabIndex = 6;
            this.darkLabel2.Text = "Документ (*.XML)";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.statusLabel.Location = new System.Drawing.Point(93, 128);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(110, 13);
            this.statusLabel.TabIndex = 7;
            this.statusLabel.Text = "Результат проверки";
            // 
            // SerializeMasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 158);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.darkLabel2);
            this.Controls.Add(this.darkLabel1);
            this.Controls.Add(this.browseXmlButton);
            this.Controls.Add(this.browseXsdButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.xmlPath);
            this.Controls.Add(this.xsdPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(324, 197);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(324, 197);
            this.Name = "SerializeMasterForm";
            this.Text = "Мастер проверки документа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DarkUI.Controls.DarkTextBox xsdPath;
        private DarkUI.Controls.DarkTextBox xmlPath;
        private DarkUI.Controls.DarkButton checkButton;
        private System.Windows.Forms.OpenFileDialog xsdOpenDialog;
        private System.Windows.Forms.OpenFileDialog xmlOpenDialog;
        private DarkUI.Controls.DarkButton browseXsdButton;
        private DarkUI.Controls.DarkButton browseXmlButton;
        private DarkUI.Controls.DarkLabel darkLabel1;
        private DarkUI.Controls.DarkLabel darkLabel2;
        private DarkUI.Controls.DarkLabel statusLabel;
    }
}