namespace Studenti
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
            this.btrDodajStudenta = new System.Windows.Forms.Button();
            this.btrDodajPredmet = new System.Windows.Forms.Button();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.dgvPredmet = new System.Windows.Forms.DataGridView();
            this.tbxIme = new System.Windows.Forms.TextBox();
            this.tbxPrezime = new System.Windows.Forms.TextBox();
            this.tbxNaziv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPredmet)).BeginInit();
            this.SuspendLayout();
            // 
            // btrDodajStudenta
            // 
            this.btrDodajStudenta.Location = new System.Drawing.Point(133, 108);
            this.btrDodajStudenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btrDodajStudenta.Name = "btrDodajStudenta";
            this.btrDodajStudenta.Size = new System.Drawing.Size(135, 28);
            this.btrDodajStudenta.TabIndex = 0;
            this.btrDodajStudenta.Text = "Dodaj Studenta";
            this.btrDodajStudenta.UseVisualStyleBackColor = true;
            this.btrDodajStudenta.Click += new System.EventHandler(this.btrDodajStudenta_Click);
            // 
            // btrDodajPredmet
            // 
            this.btrDodajPredmet.Location = new System.Drawing.Point(544, 60);
            this.btrDodajPredmet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btrDodajPredmet.Name = "btrDodajPredmet";
            this.btrDodajPredmet.Size = new System.Drawing.Size(135, 28);
            this.btrDodajPredmet.TabIndex = 0;
            this.btrDodajPredmet.Text = "Dodaj_Predmet";
            this.btrDodajPredmet.UseVisualStyleBackColor = true;
            this.btrDodajPredmet.Click += new System.EventHandler(this.btrDodajPredmet_Click);
            // 
            // dgvStudent
            // 
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Location = new System.Drawing.Point(547, 144);
            this.dgvStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowHeadersWidth = 51;
            this.dgvStudent.Size = new System.Drawing.Size(332, 185);
            this.dgvStudent.TabIndex = 1;
            // 
            // dgvPredmet
            // 
            this.dgvPredmet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPredmet.Location = new System.Drawing.Point(133, 144);
            this.dgvPredmet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPredmet.Name = "dgvPredmet";
            this.dgvPredmet.RowHeadersWidth = 51;
            this.dgvPredmet.Size = new System.Drawing.Size(304, 185);
            this.dgvPredmet.TabIndex = 1;
            // 
            // tbxIme
            // 
            this.tbxIme.Location = new System.Drawing.Point(136, 31);
            this.tbxIme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxIme.Name = "tbxIme";
            this.tbxIme.Size = new System.Drawing.Size(132, 22);
            this.tbxIme.TabIndex = 2;
            // 
            // tbxPrezime
            // 
            this.tbxPrezime.Location = new System.Drawing.Point(136, 60);
            this.tbxPrezime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxPrezime.Name = "tbxPrezime";
            this.tbxPrezime.Size = new System.Drawing.Size(132, 22);
            this.tbxPrezime.TabIndex = 2;
            // 
            // tbxNaziv
            // 
            this.tbxNaziv.Location = new System.Drawing.Point(547, 28);
            this.tbxNaziv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxNaziv.Name = "tbxNaziv";
            this.tbxNaziv.Size = new System.Drawing.Size(132, 22);
            this.tbxNaziv.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(81, 527);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(722, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Prema projektu kolege Kavura, nemojte ga tražiti njegov projekt jer je to varanje" +
    " (za stegovni sud)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ime studenta:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prezime studenta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(413, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Naziv predmeta:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 579);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxNaziv);
            this.Controls.Add(this.tbxPrezime);
            this.Controls.Add(this.tbxIme);
            this.Controls.Add(this.dgvPredmet);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.btrDodajPredmet);
            this.Controls.Add(this.btrDodajStudenta);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPredmet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btrDodajStudenta;
        private System.Windows.Forms.Button btrDodajPredmet;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.DataGridView dgvPredmet;
        private System.Windows.Forms.TextBox tbxIme;
        private System.Windows.Forms.TextBox tbxPrezime;
        private System.Windows.Forms.TextBox tbxNaziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

