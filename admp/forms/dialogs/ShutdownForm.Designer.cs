namespace admp.forms.dialogs
{
    partial class ShutdownForm
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
            this.reason = new DarkUI.Controls.DarkTextBox();
            this.darkLabel2 = new DarkUI.Controls.DarkLabel();
            this.exitButton = new DarkUI.Controls.DarkButton();
            this.SuspendLayout();
            // 
            // reason
            // 
            this.reason.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.reason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reason.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.reason.Location = new System.Drawing.Point(15, 25);
            this.reason.Name = "reason";
            this.reason.Size = new System.Drawing.Size(244, 20);
            this.reason.TabIndex = 1;
            // 
            // darkLabel2
            // 
            this.darkLabel2.AutoSize = true;
            this.darkLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel2.Location = new System.Drawing.Point(12, 9);
            this.darkLabel2.Name = "darkLabel2";
            this.darkLabel2.Size = new System.Drawing.Size(247, 13);
            this.darkLabel2.TabIndex = 2;
            this.darkLabel2.Text = "Укажите причину завершения сеанса системы";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(184, 51);
            this.exitButton.Name = "exitButton";
            this.exitButton.Padding = new System.Windows.Forms.Padding(5);
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "OK";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // ShutdownForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 87);
            this.ControlBox = false;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.darkLabel2);
            this.Controls.Add(this.reason);
            this.Name = "ShutdownForm";
            this.Text = "Система";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DarkUI.Controls.DarkTextBox reason;
        private DarkUI.Controls.DarkLabel darkLabel2;
        private DarkUI.Controls.DarkButton exitButton;
    }
}