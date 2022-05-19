namespace StanovniciHrvatske
{
    partial class Form1
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
            this.dodajZaposlenikaButton = new System.Windows.Forms.Button();
            this.prikaziAdreseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(727, 334);
            this.dataGridView1.TabIndex = 0;
            // 
            // dodajZaposlenikaButton
            // 
            this.dodajZaposlenikaButton.Location = new System.Drawing.Point(31, 372);
            this.dodajZaposlenikaButton.Name = "dodajZaposlenikaButton";
            this.dodajZaposlenikaButton.Size = new System.Drawing.Size(106, 52);
            this.dodajZaposlenikaButton.TabIndex = 1;
            this.dodajZaposlenikaButton.Text = "Dodaj zaposlenika";
            this.dodajZaposlenikaButton.UseVisualStyleBackColor = true;
            this.dodajZaposlenikaButton.Click += new System.EventHandler(this.dodajZaposlenikaButton_Click);
            // 
            // prikaziAdreseButton
            // 
            this.prikaziAdreseButton.Location = new System.Drawing.Point(156, 372);
            this.prikaziAdreseButton.Name = "prikaziAdreseButton";
            this.prikaziAdreseButton.Size = new System.Drawing.Size(106, 52);
            this.prikaziAdreseButton.TabIndex = 2;
            this.prikaziAdreseButton.Text = "Prikaži adrese";
            this.prikaziAdreseButton.UseVisualStyleBackColor = true;
            this.prikaziAdreseButton.Click += new System.EventHandler(this.prikaziAdreseButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.prikaziAdreseButton);
            this.Controls.Add(this.dodajZaposlenikaButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Prikaz stanovnika";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button dodajZaposlenikaButton;
        private System.Windows.Forms.Button prikaziAdreseButton;
    }
}

