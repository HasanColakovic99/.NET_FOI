namespace Provedba_ispita
{
    partial class FormRezultati
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
            this.dataGridViewRezultati = new System.Windows.Forms.DataGridView();
            this.ButtonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRezultati)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRezultati
            // 
            this.dataGridViewRezultati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRezultati.Location = new System.Drawing.Point(28, 26);
            this.dataGridViewRezultati.Name = "dataGridViewRezultati";
            this.dataGridViewRezultati.Size = new System.Drawing.Size(639, 177);
            this.dataGridViewRezultati.TabIndex = 0;
            // 
            // ButtonClose
            // 
            this.ButtonClose.Location = new System.Drawing.Point(591, 209);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(76, 32);
            this.ButtonClose.TabIndex = 1;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // FormRezultati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 263);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.dataGridViewRezultati);
            this.Name = "FormRezultati";
            this.Text = "FormRezultati";
            this.Load += new System.EventHandler(this.FormRezultati_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRezultati)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRezultati;
        private System.Windows.Forms.Button ButtonClose;
    }
}