namespace WindowsFormsApp1
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
            this.dodajStanovnikaButton = new System.Windows.Forms.Button();
            this.prikaziAdreseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(56, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(825, 300);
            this.dataGridView1.TabIndex = 0;
            // 
            // dodajStanovnikaButton
            // 
            this.dodajStanovnikaButton.Location = new System.Drawing.Point(56, 364);
            this.dodajStanovnikaButton.Name = "dodajStanovnikaButton";
            this.dodajStanovnikaButton.Size = new System.Drawing.Size(109, 60);
            this.dodajStanovnikaButton.TabIndex = 1;
            this.dodajStanovnikaButton.Text = "Dodaj stanovnika";
            this.dodajStanovnikaButton.UseVisualStyleBackColor = true;
            this.dodajStanovnikaButton.Click += new System.EventHandler(this.dodajStanovnikaButton_Click);
            // 
            // prikaziAdreseButton
            // 
            this.prikaziAdreseButton.Location = new System.Drawing.Point(185, 364);
            this.prikaziAdreseButton.Name = "prikaziAdreseButton";
            this.prikaziAdreseButton.Size = new System.Drawing.Size(109, 60);
            this.prikaziAdreseButton.TabIndex = 2;
            this.prikaziAdreseButton.Text = "Prikaži adrese";
            this.prikaziAdreseButton.UseVisualStyleBackColor = true;
            this.prikaziAdreseButton.Click += new System.EventHandler(this.prikaziAdreseButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 450);
            this.Controls.Add(this.prikaziAdreseButton);
            this.Controls.Add(this.dodajStanovnikaButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Popis stanovnika";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button dodajStanovnikaButton;
        private System.Windows.Forms.Button prikaziAdreseButton;
    }
}

