namespace admp.forms.children
{
    partial class QueryForm
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
            this.resultView = new System.Windows.Forms.DataGridView();
            this.queryBox = new DarkUI.Controls.DarkTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.resultView)).BeginInit();
            this.SuspendLayout();
            // 
            // resultView
            // 
            this.resultView.AllowUserToAddRows = false;
            this.resultView.AllowUserToDeleteRows = false;
            this.resultView.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.resultView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultView.Location = new System.Drawing.Point(12, 174);
            this.resultView.Name = "resultView";
            this.resultView.ReadOnly = true;
            this.resultView.Size = new System.Drawing.Size(556, 163);
            this.resultView.TabIndex = 1;
            // 
            // queryBox
            // 
            this.queryBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.queryBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.queryBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queryBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.queryBox.Location = new System.Drawing.Point(12, 12);
            this.queryBox.Multiline = true;
            this.queryBox.Name = "queryBox";
            this.queryBox.Size = new System.Drawing.Size(556, 156);
            this.queryBox.TabIndex = 2;
            this.queryBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.queryBox_KeyDown);
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 349);
            this.Controls.Add(this.queryBox);
            this.Controls.Add(this.resultView);
            this.Name = "QueryForm";
            this.Text = "QueryForm";
            ((System.ComponentModel.ISupportInitialize)(this.resultView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView resultView;
        private DarkUI.Controls.DarkTextBox queryBox;
    }
}