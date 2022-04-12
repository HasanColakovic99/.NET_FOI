namespace Vozila_u_voznom_parku
{
    partial class FormDodavanjeVozila
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNazivVozila = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonAutomobil = new System.Windows.Forms.RadioButton();
            this.radioButtonMotocikli = new System.Windows.Forms.RadioButton();
            this.ButtonOdustani = new System.Windows.Forms.Button();
            this.ButtonSpremi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dodavanje novog vozila";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naziv vozila:";
            // 
            // textBoxNazivVozila
            // 
            this.textBoxNazivVozila.Location = new System.Drawing.Point(82, 71);
            this.textBoxNazivVozila.Name = "textBoxNazivVozila";
            this.textBoxNazivVozila.Size = new System.Drawing.Size(133, 20);
            this.textBoxNazivVozila.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonMotocikli);
            this.groupBox1.Controls.Add(this.radioButtonAutomobil);
            this.groupBox1.Location = new System.Drawing.Point(15, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tip vozila:";
            // 
            // radioButtonAutomobil
            // 
            this.radioButtonAutomobil.AutoSize = true;
            this.radioButtonAutomobil.Location = new System.Drawing.Point(67, 30);
            this.radioButtonAutomobil.Name = "radioButtonAutomobil";
            this.radioButtonAutomobil.Size = new System.Drawing.Size(71, 17);
            this.radioButtonAutomobil.TabIndex = 0;
            this.radioButtonAutomobil.TabStop = true;
            this.radioButtonAutomobil.Text = "Automobil";
            this.radioButtonAutomobil.UseVisualStyleBackColor = true;
            // 
            // radioButtonMotocikli
            // 
            this.radioButtonMotocikli.AutoSize = true;
            this.radioButtonMotocikli.Location = new System.Drawing.Point(67, 53);
            this.radioButtonMotocikli.Name = "radioButtonMotocikli";
            this.radioButtonMotocikli.Size = new System.Drawing.Size(67, 17);
            this.radioButtonMotocikli.TabIndex = 1;
            this.radioButtonMotocikli.TabStop = true;
            this.radioButtonMotocikli.Text = "Motocikli";
            this.radioButtonMotocikli.UseVisualStyleBackColor = true;
            // 
            // ButtonOdustani
            // 
            this.ButtonOdustani.Location = new System.Drawing.Point(109, 224);
            this.ButtonOdustani.Name = "ButtonOdustani";
            this.ButtonOdustani.Size = new System.Drawing.Size(106, 28);
            this.ButtonOdustani.TabIndex = 4;
            this.ButtonOdustani.Text = "Odustani";
            this.ButtonOdustani.UseVisualStyleBackColor = true;
            this.ButtonOdustani.Click += new System.EventHandler(this.ButtonOdustani_Click);
            // 
            // ButtonSpremi
            // 
            this.ButtonSpremi.Location = new System.Drawing.Point(109, 258);
            this.ButtonSpremi.Name = "ButtonSpremi";
            this.ButtonSpremi.Size = new System.Drawing.Size(106, 28);
            this.ButtonSpremi.TabIndex = 5;
            this.ButtonSpremi.Text = "Spremi";
            this.ButtonSpremi.UseVisualStyleBackColor = true;
            this.ButtonSpremi.Click += new System.EventHandler(this.ButtonSpremi_Click);
            // 
            // FormDodavanjeVozila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 308);
            this.Controls.Add(this.ButtonSpremi);
            this.Controls.Add(this.ButtonOdustani);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxNazivVozila);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDodavanjeVozila";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodavanje novog vozila";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNazivVozila;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonMotocikli;
        private System.Windows.Forms.RadioButton radioButtonAutomobil;
        private System.Windows.Forms.Button ButtonOdustani;
        private System.Windows.Forms.Button ButtonSpremi;
    }
}