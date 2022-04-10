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
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPredmet)).BeginInit();
            this.SuspendLayout();
            // 
            // btrDodajStudenta
            // 
            this.btrDodajStudenta.Location = new System.Drawing.Point(64, 88);
            this.btrDodajStudenta.Name = "btrDodajStudenta";
            this.btrDodajStudenta.Size = new System.Drawing.Size(101, 23);
            this.btrDodajStudenta.TabIndex = 0;
            this.btrDodajStudenta.Text = "Dodaj Studenta";
            this.btrDodajStudenta.UseVisualStyleBackColor = true;
            this.btrDodajStudenta.Click += new System.EventHandler(this.btrDodajStudenta_Click);
            // 
            // btrDodajPredmet
            // 
            this.btrDodajPredmet.Location = new System.Drawing.Point(376, 49);
            this.btrDodajPredmet.Name = "btrDodajPredmet";
            this.btrDodajPredmet.Size = new System.Drawing.Size(101, 23);
            this.btrDodajPredmet.TabIndex = 0;
            this.btrDodajPredmet.Text = "Dodaj_Predmet";
            this.btrDodajPredmet.UseVisualStyleBackColor = true;
            this.btrDodajPredmet.Click += new System.EventHandler(this.btrDodajPredmet_Click);
            // 
            // dgvStudent
            // 
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Location = new System.Drawing.Point(376, 117);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.Size = new System.Drawing.Size(249, 150);
            this.dgvStudent.TabIndex = 1;
            // 
            // dgvPredmet
            // 
            this.dgvPredmet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPredmet.Location = new System.Drawing.Point(65, 117);
            this.dgvPredmet.Name = "dgvPredmet";
            this.dgvPredmet.Size = new System.Drawing.Size(228, 150);
            this.dgvPredmet.TabIndex = 1;
            this.dgvPredmet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPredmet_CellContentClick);
            // 
            // tbxIme
            // 
            this.tbxIme.Location = new System.Drawing.Point(65, 23);
            this.tbxIme.Name = "tbxIme";
            this.tbxIme.Size = new System.Drawing.Size(100, 20);
            this.tbxIme.TabIndex = 2;
            // 
            // tbxPrezime
            // 
            this.tbxPrezime.Location = new System.Drawing.Point(65, 49);
            this.tbxPrezime.Name = "tbxPrezime";
            this.tbxPrezime.Size = new System.Drawing.Size(100, 20);
            this.tbxPrezime.TabIndex = 2;
            // 
            // tbxNaziv
            // 
            this.tbxNaziv.Location = new System.Drawing.Point(376, 23);
            this.tbxNaziv.Name = "tbxNaziv";
            this.tbxNaziv.Size = new System.Drawing.Size(100, 20);
            this.tbxNaziv.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(61, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Prema projektu kolege Kavura, nemojte ga tražiti njegov projekt jer je to varanje (za stegovni sud)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxNaziv);
            this.Controls.Add(this.tbxPrezime);
            this.Controls.Add(this.tbxIme);
            this.Controls.Add(this.dgvPredmet);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.btrDodajPredmet);
            this.Controls.Add(this.btrDodajStudenta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPredmet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void DgvPredmet_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            throw new System.NotImplementedException();
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
    }
}

