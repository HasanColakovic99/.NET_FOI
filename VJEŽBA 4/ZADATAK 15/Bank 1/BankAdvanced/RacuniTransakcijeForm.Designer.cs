namespace BankAdvanced
{
    partial class RacuniTransakcijeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.transakcijeDataGridView = new System.Windows.Forms.DataGridView();
            this.zatvoriButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.transakcijeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Popis transakcija:";
            // 
            // transakcijeDataGridView
            // 
            this.transakcijeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transakcijeDataGridView.Location = new System.Drawing.Point(15, 29);
            this.transakcijeDataGridView.Name = "transakcijeDataGridView";
            this.transakcijeDataGridView.RowTemplate.Height = 24;
            this.transakcijeDataGridView.Size = new System.Drawing.Size(773, 348);
            this.transakcijeDataGridView.TabIndex = 1;
            // 
            // zatvoriButton
            // 
            this.zatvoriButton.Location = new System.Drawing.Point(688, 383);
            this.zatvoriButton.Name = "zatvoriButton";
            this.zatvoriButton.Size = new System.Drawing.Size(100, 35);
            this.zatvoriButton.TabIndex = 2;
            this.zatvoriButton.Text = "Zatvori";
            this.zatvoriButton.UseVisualStyleBackColor = true;
            this.zatvoriButton.Click += new System.EventHandler(this.zatvoriButton_Click);
            // 
            // RacuniTransakcijeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 434);
            this.Controls.Add(this.zatvoriButton);
            this.Controls.Add(this.transakcijeDataGridView);
            this.Controls.Add(this.label1);
            this.Name = "RacuniTransakcijeForm";
            this.Text = "Transakcije";
            this.Load += new System.EventHandler(this.RacuniTransakcijeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transakcijeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView transakcijeDataGridView;
        private System.Windows.Forms.Button zatvoriButton;
    }
}