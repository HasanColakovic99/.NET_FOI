namespace StanovniciHrvatske
{
    partial class PrikazivanjeAdresa
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
            this.dodajAdresuButton = new System.Windows.Forms.Button();
            this.odustaniButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(694, 302);
            this.dataGridView1.TabIndex = 0;
            // 
            // dodajAdresuButton
            // 
            this.dodajAdresuButton.Location = new System.Drawing.Point(38, 360);
            this.dodajAdresuButton.Name = "dodajAdresuButton";
            this.dodajAdresuButton.Size = new System.Drawing.Size(108, 61);
            this.dodajAdresuButton.TabIndex = 1;
            this.dodajAdresuButton.Text = "Dodaj adresu";
            this.dodajAdresuButton.UseVisualStyleBackColor = true;
            this.dodajAdresuButton.Click += new System.EventHandler(this.dodajAdresuButton_Click);
            // 
            // odustaniButton
            // 
            this.odustaniButton.Location = new System.Drawing.Point(624, 360);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(108, 61);
            this.odustaniButton.TabIndex = 2;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // PrikazivanjeAdresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.dodajAdresuButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PrikazivanjeAdresa";
            this.Text = "Adrese";
            this.Load += new System.EventHandler(this.PrikazivanjeAdresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button dodajAdresuButton;
        private System.Windows.Forms.Button odustaniButton;
    }
}