namespace BankAdvanced
{
    partial class KlijentiForm
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
            this.klijentiDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.detaljiButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.klijentiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // klijentiDataGridView
            // 
            this.klijentiDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.klijentiDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.klijentiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.klijentiDataGridView.Location = new System.Drawing.Point(12, 32);
            this.klijentiDataGridView.Name = "klijentiDataGridView";
            this.klijentiDataGridView.RowHeadersVisible = false;
            this.klijentiDataGridView.RowTemplate.Height = 24;
            this.klijentiDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.klijentiDataGridView.Size = new System.Drawing.Size(776, 355);
            this.klijentiDataGridView.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Popis klijenata:";
            // 
            // detaljiButton
            // 
            this.detaljiButton.Location = new System.Drawing.Point(713, 393);
            this.detaljiButton.Name = "detaljiButton";
            this.detaljiButton.Size = new System.Drawing.Size(75, 33);
            this.detaljiButton.TabIndex = 4;
            this.detaljiButton.Text = "Detalji";
            this.detaljiButton.UseVisualStyleBackColor = true;
            this.detaljiButton.Click += new System.EventHandler(this.detaljiButton_Click);
            // 
            // KlijentiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.detaljiButton);
            this.Controls.Add(this.klijentiDataGridView);
            this.Controls.Add(this.label1);
            this.Name = "KlijentiForm";
            this.Text = "Klijenti";
            this.Load += new System.EventHandler(this.KlijentiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.klijentiDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView klijentiDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button detaljiButton;
    }
}