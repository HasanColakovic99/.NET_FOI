namespace BankAdvanced
{
    partial class OdaberiKlijentaForm
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
            this.izlazButton = new System.Windows.Forms.Button();
            this.odaberiButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.klijentiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // klijentiDataGridView
            // 
            this.klijentiDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.klijentiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.klijentiDataGridView.Location = new System.Drawing.Point(12, 26);
            this.klijentiDataGridView.Name = "klijentiDataGridView";
            this.klijentiDataGridView.RowHeadersVisible = false;
            this.klijentiDataGridView.RowTemplate.Height = 24;
            this.klijentiDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.klijentiDataGridView.Size = new System.Drawing.Size(489, 174);
            this.klijentiDataGridView.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Popis klijenata:";
            // 
            // izlazButton
            // 
            this.izlazButton.Location = new System.Drawing.Point(411, 206);
            this.izlazButton.Name = "izlazButton";
            this.izlazButton.Size = new System.Drawing.Size(90, 37);
            this.izlazButton.TabIndex = 7;
            this.izlazButton.Text = "Izlaz";
            this.izlazButton.UseVisualStyleBackColor = true;
            this.izlazButton.Click += new System.EventHandler(this.izlazButton_Click);
            // 
            // odaberiButton
            // 
            this.odaberiButton.Location = new System.Drawing.Point(315, 206);
            this.odaberiButton.Name = "odaberiButton";
            this.odaberiButton.Size = new System.Drawing.Size(90, 37);
            this.odaberiButton.TabIndex = 6;
            this.odaberiButton.Text = "Odaberi";
            this.odaberiButton.UseVisualStyleBackColor = true;
            this.odaberiButton.Click += new System.EventHandler(this.odaberiButton_Click);
            // 
            // OdaberiKlijentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 257);
            this.Controls.Add(this.izlazButton);
            this.Controls.Add(this.odaberiButton);
            this.Controls.Add(this.klijentiDataGridView);
            this.Controls.Add(this.label1);
            this.Name = "OdaberiKlijentaForm";
            this.Text = "Odaberi klijenta";
            this.Load += new System.EventHandler(this.OdaberiKlijentaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.klijentiDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView klijentiDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button izlazButton;
        private System.Windows.Forms.Button odaberiButton;
    }
}