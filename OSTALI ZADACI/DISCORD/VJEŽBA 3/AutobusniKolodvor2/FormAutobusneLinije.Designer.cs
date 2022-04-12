
namespace AutobusniKolodvor2
{
    partial class FormAutobusneLinije
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
            this.dataGridViewLinije = new System.Windows.Forms.DataGridView();
            this.textBoxOdrediste = new System.Windows.Forms.TextBox();
            this.buttonPronadji = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKupiKartu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLinije)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLinije
            // 
            this.dataGridViewLinije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLinije.Location = new System.Drawing.Point(12, 41);
            this.dataGridViewLinije.Name = "dataGridViewLinije";
            this.dataGridViewLinije.RowHeadersWidth = 51;
            this.dataGridViewLinije.RowTemplate.Height = 24;
            this.dataGridViewLinije.Size = new System.Drawing.Size(776, 296);
            this.dataGridViewLinije.TabIndex = 0;
            // 
            // textBoxOdrediste
            // 
            this.textBoxOdrediste.Location = new System.Drawing.Point(128, 10);
            this.textBoxOdrediste.Name = "textBoxOdrediste";
            this.textBoxOdrediste.Size = new System.Drawing.Size(221, 22);
            this.textBoxOdrediste.TabIndex = 1;
            // 
            // buttonPronadji
            // 
            this.buttonPronadji.Location = new System.Drawing.Point(366, 10);
            this.buttonPronadji.Name = "buttonPronadji";
            this.buttonPronadji.Size = new System.Drawing.Size(75, 23);
            this.buttonPronadji.TabIndex = 2;
            this.buttonPronadji.Text = "Pronađi";
            this.buttonPronadji.UseVisualStyleBackColor = true;
            this.buttonPronadji.Click += new System.EventHandler(this.buttonPronadji_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Odredište:";
            // 
            // buttonKupiKartu
            // 
            this.buttonKupiKartu.Location = new System.Drawing.Point(696, 359);
            this.buttonKupiKartu.Name = "buttonKupiKartu";
            this.buttonKupiKartu.Size = new System.Drawing.Size(92, 32);
            this.buttonKupiKartu.TabIndex = 4;
            this.buttonKupiKartu.Text = "Kupi kartu";
            this.buttonKupiKartu.UseVisualStyleBackColor = true;
            this.buttonKupiKartu.Click += new System.EventHandler(this.buttonKupiKartu_Click);
            // 
            // FormAutobusneLinije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonKupiKartu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPronadji);
            this.Controls.Add(this.textBoxOdrediste);
            this.Controls.Add(this.dataGridViewLinije);
            this.Name = "FormAutobusneLinije";
            this.Text = "Autobusne linije";
            this.Load += new System.EventHandler(this.FormAutobusneLinije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLinije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLinije;
        private System.Windows.Forms.TextBox textBoxOdrediste;
        private System.Windows.Forms.Button buttonPronadji;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKupiKartu;
    }
}

