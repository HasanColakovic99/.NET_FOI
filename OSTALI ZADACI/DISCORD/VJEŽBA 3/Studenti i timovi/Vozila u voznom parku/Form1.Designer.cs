namespace Vozila_u_voznom_parku
{
    partial class FormGlavna
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
            this.dataGridViewVozila = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonDodajVozilo = new System.Windows.Forms.Button();
            this.ButtonPromijeniNaziv = new System.Windows.Forms.Button();
            this.ButtonObrisiVozilo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVozila)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVozila
            // 
            this.dataGridViewVozila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVozila.Location = new System.Drawing.Point(12, 42);
            this.dataGridViewVozila.Name = "dataGridViewVozila";
            this.dataGridViewVozila.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewVozila.Size = new System.Drawing.Size(535, 238);
            this.dataGridViewVozila.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vozila u voznom parku:";
            // 
            // ButtonDodajVozilo
            // 
            this.ButtonDodajVozilo.Location = new System.Drawing.Point(112, 297);
            this.ButtonDodajVozilo.Name = "ButtonDodajVozilo";
            this.ButtonDodajVozilo.Size = new System.Drawing.Size(141, 34);
            this.ButtonDodajVozilo.TabIndex = 2;
            this.ButtonDodajVozilo.Text = "Dodaj vozilo";
            this.ButtonDodajVozilo.UseVisualStyleBackColor = true;
            this.ButtonDodajVozilo.Click += new System.EventHandler(this.ButtonDodajVozilo_Click);
            // 
            // ButtonPromijeniNaziv
            // 
            this.ButtonPromijeniNaziv.Location = new System.Drawing.Point(259, 297);
            this.ButtonPromijeniNaziv.Name = "ButtonPromijeniNaziv";
            this.ButtonPromijeniNaziv.Size = new System.Drawing.Size(141, 34);
            this.ButtonPromijeniNaziv.TabIndex = 3;
            this.ButtonPromijeniNaziv.Text = "Promijeni naziv";
            this.ButtonPromijeniNaziv.UseVisualStyleBackColor = true;
            this.ButtonPromijeniNaziv.Click += new System.EventHandler(this.ButtonPromijeniNaziv_Click);
            // 
            // ButtonObrisiVozilo
            // 
            this.ButtonObrisiVozilo.Location = new System.Drawing.Point(406, 297);
            this.ButtonObrisiVozilo.Name = "ButtonObrisiVozilo";
            this.ButtonObrisiVozilo.Size = new System.Drawing.Size(141, 34);
            this.ButtonObrisiVozilo.TabIndex = 4;
            this.ButtonObrisiVozilo.Text = "Obriši vozilo";
            this.ButtonObrisiVozilo.UseVisualStyleBackColor = true;
            this.ButtonObrisiVozilo.Click += new System.EventHandler(this.ButtonObrisiVozilo_Click);
            // 
            // FormGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 351);
            this.Controls.Add(this.ButtonObrisiVozilo);
            this.Controls.Add(this.ButtonPromijeniNaziv);
            this.Controls.Add(this.ButtonDodajVozilo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewVozila);
            this.Name = "FormGlavna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled voznog parka";
            this.Load += new System.EventHandler(this.FormGlavna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVozila)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVozila;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonDodajVozilo;
        private System.Windows.Forms.Button ButtonPromijeniNaziv;
        private System.Windows.Forms.Button ButtonObrisiVozilo;
    }
}

