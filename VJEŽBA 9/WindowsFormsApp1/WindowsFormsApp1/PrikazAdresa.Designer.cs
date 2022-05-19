namespace WindowsFormsApp1
{
    partial class PrikazAdresa
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.zatvoriButton = new System.Windows.Forms.Button();
            this.dodajAdresuButton = new System.Windows.Forms.Button();
            this.azurirajButton = new System.Windows.Forms.Button();
            this.obrisiAdresuButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(683, 333);
            this.dataGridView1.TabIndex = 0;
            // 
            // zatvoriButton
            // 
            this.zatvoriButton.Location = new System.Drawing.Point(627, 399);
            this.zatvoriButton.Name = "zatvoriButton";
            this.zatvoriButton.Size = new System.Drawing.Size(99, 52);
            this.zatvoriButton.TabIndex = 1;
            this.zatvoriButton.Text = "Zatvori";
            this.zatvoriButton.UseVisualStyleBackColor = true;
            this.zatvoriButton.Click += new System.EventHandler(this.zatvoriButton_Click);
            // 
            // dodajAdresuButton
            // 
            this.dodajAdresuButton.Location = new System.Drawing.Point(43, 399);
            this.dodajAdresuButton.Name = "dodajAdresuButton";
            this.dodajAdresuButton.Size = new System.Drawing.Size(99, 52);
            this.dodajAdresuButton.TabIndex = 2;
            this.dodajAdresuButton.Text = "Dodaj adresu";
            this.dodajAdresuButton.UseVisualStyleBackColor = true;
            this.dodajAdresuButton.Click += new System.EventHandler(this.dodajAdresuButton_Click);
            // 
            // azurirajButton
            // 
            this.azurirajButton.Location = new System.Drawing.Point(157, 399);
            this.azurirajButton.Name = "azurirajButton";
            this.azurirajButton.Size = new System.Drawing.Size(99, 52);
            this.azurirajButton.TabIndex = 3;
            this.azurirajButton.Text = "Ažuriraj adresu";
            this.azurirajButton.UseVisualStyleBackColor = true;
            this.azurirajButton.Click += new System.EventHandler(this.azurirajButton_Click);
            // 
            // obrisiAdresuButton
            // 
            this.obrisiAdresuButton.Location = new System.Drawing.Point(273, 399);
            this.obrisiAdresuButton.Name = "obrisiAdresuButton";
            this.obrisiAdresuButton.Size = new System.Drawing.Size(99, 52);
            this.obrisiAdresuButton.TabIndex = 4;
            this.obrisiAdresuButton.Text = "Obriši adresu";
            this.obrisiAdresuButton.UseVisualStyleBackColor = true;
            this.obrisiAdresuButton.Click += new System.EventHandler(this.obrisiAdresuButton_Click);
            // 
            // PrikazAdresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.obrisiAdresuButton);
            this.Controls.Add(this.azurirajButton);
            this.Controls.Add(this.dodajAdresuButton);
            this.Controls.Add(this.zatvoriButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PrikazAdresa";
            this.Text = "Popis adresa";
            this.Load += new System.EventHandler(this.PrikazAdresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button zatvoriButton;
        private System.Windows.Forms.Button dodajAdresuButton;
        private System.Windows.Forms.Button azurirajButton;
        private System.Windows.Forms.Button obrisiAdresuButton;
    }
}