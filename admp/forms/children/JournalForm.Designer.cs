namespace admp.forms.children
{
    partial class JournalForm
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
            this.darkContextMenu1 = new DarkUI.Controls.DarkContextMenu();
            this.journalBox = new DarkUI.Controls.DarkTextBox();
            this.SuspendLayout();
            // 
            // darkContextMenu1
            // 
            this.darkContextMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.darkContextMenu1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkContextMenu1.Name = "darkContextMenu1";
            this.darkContextMenu1.Size = new System.Drawing.Size(61, 4);
            // 
            // journalBox
            // 
            this.journalBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.journalBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.journalBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.journalBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.journalBox.Location = new System.Drawing.Point(12, 12);
            this.journalBox.Multiline = true;
            this.journalBox.Name = "journalBox";
            this.journalBox.ReadOnly = true;
            this.journalBox.Size = new System.Drawing.Size(510, 322);
            this.journalBox.TabIndex = 1;
            this.journalBox.TabStop = false;
            // 
            // JournalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 346);
            this.Controls.Add(this.journalBox);
            this.Name = "JournalForm";
            this.Text = "JournalForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DarkUI.Controls.DarkContextMenu darkContextMenu1;
        private DarkUI.Controls.DarkTextBox journalBox;
    }
}